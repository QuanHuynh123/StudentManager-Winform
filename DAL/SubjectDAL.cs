using DAL.Models;
using Dapper;
using DTO;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class SubjectDAL : SqlConnectionData
    {
        public SearchResponse<SubjectDTO> Search(SearchRequest request, int departmentID = 0)
        {
            string keyWord = !string.IsNullOrWhiteSpace(request.KeyWord) ? request.KeyWord.ToLower() : "";
            string query = $@"Select * from subject 
                    where SubjectName like @SubjectName
                        {(departmentID != 0 ? $" and subject.DepartmentID = {departmentID}" : "")}";

            using (var connection = Connection())
            {
                connection.Open();

                // Lấy tất cả môn học phù hợp với từ khóa tìm kiếm
                List<SubjectDTO> foundSubjects = connection.Query<SubjectDTO>(
                    query,
                    new
                    {
                        SubjectName = $"%{keyWord}%"
                    }
                ).ToList();

                // Trả về kết quả tìm kiếm
                return new SearchResponse<SubjectDTO>
                {
                    Data = foundSubjects,
                    TotalRecord = foundSubjects.Count // Tổng số bản ghi tìm được
                };
            }
        }

        public void Add(SubjectDTO subject)
        {
            string query = @"INSERT INTO subject (SubjectName,Credits, DepartmentID , ProgramID) 
                     VALUES (@SubjectName,@Credits ,@DepartmentID , @ProgramID)";

            using (var connection = Connection())
            {
                connection.Open();
                connection.Execute(query, new
                {
                    SubjectName = subject.SubjectName,
                    Credits = subject.Credits,
                    DepartmentID = subject.DepartmentID,
                    ProgramID = subject.ProgramID,
                });
            }
        }

        public void Delete(int subjectId)
        {
            string query = @"DELETE FROM subject WHERE SubjectID = @SubjectID";

            using (var connection = Connection())
            {
                connection.Open();
                connection.Execute(query, new { SubjectID = subjectId });
            }
        }

        public void Update(SubjectDTO subject)
        {
            string query = @"UPDATE subject 
                     SET SubjectName = @SubjectName, DepartmentID = @DepartmentID , Credits = @Credits , ProgramID = @ProgramID
                     WHERE SubjectID = @SubjectID";

            using (var connection = Connection())
            {
                connection.Open();
                connection.Execute(query, new
                {
                    SubjectName = subject.SubjectName,
                    Credits = subject.Credits,
                    DepartmentID = subject.DepartmentID,
                    ProgramID = subject.ProgramID,
                });
            }
        }

        public List<SubjectDTO> GetSubjectByDepartmentID(int departmentId)
        {
            string query = @"SELECT * FROM subject WHERE DepartmentID = @DepartmentID";

            using (var connection = Connection())
            {
                connection.Open();
                var subjects = connection.Query<SubjectDTO>(query, new { DepartmentID = departmentId }).ToList();
                return subjects;
            }
        }

        public SubjectDTO GetSubjectByID(int subjectId)
        {
            string query = @"SELECT * FROM subject WHERE SubjectID = @SubjectID";

            using (var connection = Connection())
            {
                connection.Open();
                // Thực hiện truy vấn lấy thông tin môn học dựa trên SubjectID
                var subject = connection.QueryFirstOrDefault<SubjectDTO>(query, new { SubjectID = subjectId });
                return subject;
            }
        }
        public List<SubjectDTO> GetSubjectByTeacherID(int teacherId)
        {
            string query = @"  SELECT 
                                [SubjectID],
                                [SubjectName],
                                [Credits],
                                [ProgramID],
                                [DepartmentID]
                            FROM 
	                            [Subject]
                            WHERE 
                                [SubjectID] IN (
                                    SELECT [SubjectID]
                                    FROM [Class]
                                    WHERE TeacherID = @TeacherID
                                    AND SubjectID IS NOT NULL
                                )";

            using (var connection = Connection())
            {
                connection.Open();
                var subjects = connection.Query<SubjectDTO>(query, new { @TeacherID = teacherId }).ToList();
                return subjects;
            }
        }

        public List<Student_TranscriptDTO> GetStudentAndTranscriptBySubjectId(int subjectId)
        {
            // Lấy năm hiện tại
            int year = DateTime.Now.Year;

            string query = @"SELECT 
                        T.TranscriptID, 
                        T.MidtermScore, 
                        T.FinalScore, 
                        T.TotalScore,
                        S.FullName
                    FROM 
                        Transcript T
                    JOIN 
                        Student S
                    ON 
                        T.StudentID = S.StudentID
                    WHERE 
                        T.SubjectID = @SubjectId
                        AND T.YearTranscript = @Year";

            using (var connection = Connection())
            {
                connection.Open();
                // Truyền thêm tham số Year vào truy vấn
                var transcript = connection.Query<Student_TranscriptDTO>(query, new { SubjectId = subjectId, Year = year }).ToList();
                return transcript;
            }
        }

        public bool UpdateTranscriptScoresAndStatus(int transcriptId, float midtermScore, float finalScore)
        {
            // Tính TotalScore
            float totalScore = (midtermScore + finalScore) / 2;

            // Xác định trạng thái
            int status = totalScore > 4 ? 1 : 0;

            string query = @"UPDATE Transcript
                     SET 
                         MidtermScore = @MidtermScore,
                         FinalScore = @FinalScore,
                         TotalScore = @TotalScore,
                         Status = @Status
                     WHERE 
                         TranscriptID = @TranscriptID";

            using (var connection = Connection())
            {
                connection.Open();
                int rowsAffected = connection.Execute(query, new
                {
                    MidtermScore = midtermScore,
                    FinalScore = finalScore,
                    TotalScore = totalScore,
                    Status = status,
                    TranscriptID = transcriptId
                });

                return rowsAffected > 0;
            }
        }


    }
}
