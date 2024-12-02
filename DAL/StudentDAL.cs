using Dapper;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class StudentDAL : SqlConnectionData
    {
        public List<StudentDTO> GetStudentFromHomeroom(int teacherID)
        {
            string query = @"SELECT 
                            s.StudentID,
                            s.FullName,
                            s.Gender,
                            s.Age,
                            s.Email,
                            s.PhoneNumber,
                            s.EnrollmentDate,
                            s.Hometown,
                            s.PermanentAddress,
                            s.DepartmentID,
                            s.ProgramID,
                            s.GPA,
	                        s.ClassID,
                            s.TotalCreditsEarned
                        FROM [Student] s
                        JOIN [Class] c ON s.ClassID = c.ClassID
                        WHERE c.TeacherID = @TeacherID";

            using (var connection = Connection())
            {
                connection.Open();
                List<StudentDTO> foundStudents = 
                    connection.Query<StudentDTO>(query,new{ TeacherID = teacherID } ).ToList();
                return foundStudents;
            }
        }

        public StudentDTO getStudentInfo(int studentID)
        {
            using (var connection = Connection())
            {
                connection.Open();

                string query = "SELECT *FROM Student WHERE StudentID = @StudentID";

                StudentDTO student = connection.QuerySingle<StudentDTO>(query, new { StudentID = studentID });

                return student;
            }
        }

        public List<StudentDTO> GetStudentByIdDeparment(int departmentID)
        {
            string query = @"Select * from student where DepartmentID = @departmentID";

            using (var connection = Connection())
            {
                connection.Open();

                List<StudentDTO> foundStudents = 
                    connection.Query<StudentDTO>( query, new{ departmentID = departmentID}).ToList();

                return foundStudents;

            }
        }

        public bool AddStudent(StudentDTO studentDTO)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = @"INSERT INTO Student 
                         (FullName, Age, Gender, Email, DepartmentID, ProgramID, PhoneNumber, EnrollmentDate, Hometown, PermanentAddress)
                         VALUES 
                         (@FullName, @Age, @Gender, @Email, @DepartmentID, @ProgramID, @PhoneNumber, @EnrollmentDate, @Hometown, @PermanentAddress)";

                int rowsAffected = connection.Execute(query, new
                {
                    FullName = studentDTO.FullName,
                    Age = studentDTO.Age,              
                    Gender = studentDTO.Gender ,  
                    Email = studentDTO.Email,
                    DepartmentID = studentDTO.DepartmentID, 
                    ProgramID = studentDTO.ProgramID,     
                    PhoneNumber = studentDTO.PhoneNumber,
                    EnrollmentDate = studentDTO.EnrollmentDate, 
                    Hometown = studentDTO.Hometown,
                    PermanentAddress = studentDTO.PermanentAddress
                });

                return rowsAffected > 0; 
            }
        }


        public bool DeleteStudent(int studentID)
        {
            using (var connection = Connection())
            {
                connection.Open();

                string query = "DELETE FROM Student WHERE StudentID = @StudentID";

                int rowsAffected = connection.Execute(query, new { StudentID = studentID });

                return rowsAffected > 0; 
            }
        }


        public bool UpdateStudent(StudentDTO student)
        {
            using (var connection = Connection())
            {
                connection.Open();

                string query = @"UPDATE Student 
                         SET FullName = @FullName, Age = @Age, Gender = @Gender, 
                             PermanentAddress = @PermanentAddress, PhoneNumber = @PhoneNumber ,
                             EnrollmentDate = @EnrollmentDate, Hometown = @Hometown , Email = @Email
                         WHERE StudentID = @StudentID";

                int rowsAffected = connection.Execute(query, student);

                return rowsAffected > 0; 
            }
        }

        public List<StudentDTO> SearchStudentsByNameOfDepartment(string name , int departmentId)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = @"SELECT * 
                                FROM Student 
                                WHERE FullName LIKE CONCAT('%', @FullName, '%') 
                                AND DepartmentId = @DepartmentId";
                List<StudentDTO> foundStudents = connection.Query<StudentDTO>(
                    query,
                    new { FullName = name , DepartmentId = departmentId }
                ).ToList();

                return foundStudents;
            }
        }

        public List<StudentDTO> SearchStudentsByNameOfMyStudent(string name, int teacherId)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = @"SELECT s.[StudentID],
                                   s.[Gender],
                                   s.[Age],
                                   s.[Email],
                                   s.[PhoneNumber],
                                   s.[EnrollmentDate],
                                   s.[Hometown],
                                   s.[PermanentAddress],
                                   s.[DepartmentID],
                                   s.[ProgramID],
                                   s.[FullName],
                                   s.[GPA],
                                   s.[TotalCreditsEarned],
                                   s.[ClassID]
                            FROM [Student] s
                            JOIN [Class] c ON s.ClassID = c.ClassID
                            JOIN [Teacher] t ON c.TeacherID = t.TeacherID
                            WHERE t.TeacherID = @TeacherID 
                              AND s.FullName LIKE '%' + @FullName + '%'";
                List<StudentDTO> foundStudents = connection.Query<StudentDTO>(
                    query,
                    new { TeacherId = teacherId, FullName = name }
                ).ToList();

                return foundStudents;
            }
        }

        public List<StudentDTO> getListStudentByIdClass(int classId)
        {
            using (var connection = Connection())
            {
                connection.Open();

                string query = @"SELECT 
                                s.StudentID,
                                s.FullName,
                                s.Gender,
                                s.Age,
                                s.Email,
                                s.PhoneNumber,
                                s.EnrollmentDate,
                                s.Hometown,
                                s.PermanentAddress,
                                s.DepartmentID,
                                s.ProgramID,
                                s.GPA,
                                s.TotalCreditsEarned,
                                c.ClassID,
                                c.ClassName,
                                c.Room,
                                c.SubjectID,
                                c.TeacherID,
                                c.StartPeriod,
                                c.EndPeriod,
                                c.Day
                            FROM [Student] s
                            JOIN [Class] c ON s.ClassID = c.ClassID
                            WHERE c.ClassID = @ClassID";

                List<StudentDTO> foundStudents = connection.Query<StudentDTO>(
                    query,
                    new { ClassID = classId }
                ).ToList();

                return foundStudents;
            }
        }

        public List<ClassDTO> getTimetableStudent(int studentId)
        {
            using (var connection = Connection())
            {
                connection.Open();

                string query = @"SELECT 
                                c.ClassID,
                                c.ClassName,
                                c.Room,
                                c.SubjectID,
                                c.StartPeriod,
                                c.EndPeriod,
                                c.Day,
                                s.SubjectName,
                                s.Credits
                            FROM [Class_Student] cs
                            JOIN [Class] c ON cs.ClassID = c.ClassID
                            JOIN [Subject] s ON c.SubjectID = s.SubjectID
                            WHERE cs.StudentID = @StudentID 
                            AND c.SubjectID IS NOT NULL
                            ORDER BY c.Day, c.StartPeriod";

                List<ClassDTO> timetable = connection.Query<ClassDTO>(
                    query,
                    new { StudentID = studentId }
                ).ToList();

                return timetable;
            }
        }


    }
}
