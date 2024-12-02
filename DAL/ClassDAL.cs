using DAL.Models;
using Dapper;
using DTO;
using DTO.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class ClassDAL : SqlConnectionData
    {
        public SearchResponse<ClassDTO> Search(SearchRequest request, int teacherID = 0, int departmentID = 0)
        {
            string keyWord = !string.IsNullOrWhiteSpace(request.KeyWord) ? request.KeyWord.ToLower() : "";
            string query = $@"Select * from class 
                                left join subject on subject.SubjectID = class.ClassID 
                                left join teacher on teacher.TeacherID = class.TeacherID 
                            where 
                                ClassName like @ClassName {(teacherID != 0 ? $" and class.TeacherID = {teacherID}" : "")}
                                                          {(departmentID != 0 ? $" and teacher.DepartmentID = {departmentID}" : "")}
                            order by ClassID offset @Offset rows fetch next @Limit rows only";

            string queryNumberOfRecord = $@"Select count(*) from class 
                                                left join subject on subject.SubjectID = class.ClassID 
                                                left join teacher on teacher.TeacherID = class.TeacherID 
                                            where ClassName like @ClassName 
                                                {(teacherID != 0 ? $" and class.TeacherID = {teacherID}" : "")}
                                                {(departmentID != 0 ? $" and teacher.DepartmentID = {departmentID}" : "")}";

            using(var connection = Connection())
            {
                connection.Open();

                 List<ClassDTO> foundClasses = connection.Query<ClassDTO, SubjectDTO, TeacherDTO, ClassDTO>(
                     query, (c, s, t) => {
                         c.Subject = s;
                         c.Teacher = t;
                         return c;
                     }, new {
                         ClassName = $"%{keyWord}%", 
                         Offset = request.PageSize * request.PageIndex, 
                         Limit = request.PageSize
                     }, splitOn: "SubjectID,TeacherID"
                 ).ToList();

                int numberOfRecord = connection.QueryFirst<int>(
                     queryNumberOfRecord,
                     new
                     {
                         ClassName = $"%{keyWord}%",
                     }
                 );

                if (foundClasses.Count > 0)
                {
                    return new SearchResponse<ClassDTO>
                    {
                        Data = foundClasses,
                        TotalRecord = numberOfRecord
                    };
                }

                return new SearchResponse<ClassDTO>
                {
                    Data = foundClasses,
                    TotalRecord = numberOfRecord
                };
            }
        }

        public ClassDTO GetByID(int classID)
        {
            using (var connection = Connection())
            {
                connection.Open();

                string query = "Select * from class where ClassID = @ID";
                ClassDTO foundClass = connection.QueryFirstOrDefault<ClassDTO>(query, new { ID = classID });

                return foundClass;
            }
        }


        public bool Create(ClassDTO classDTO)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "INSERT INTO class (ClassName, Room, SubjectID, TeacherID, StartPeriod, EndPeriod, Day) " +
                               "VALUES (@ClassName, @Room, @SubjectID, @TeacherID, @StartPeriod, @EndPeriod, @Day)";

                int affectedRows = connection.Execute(query, classDTO);

                if (affectedRows <= 0)
                {
                    return false;
                }

                return true;
            }
        }

        public bool Delete(int classID)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "DELETE FROM class WHERE ClassID = @ClassID";

                int rowDeleted = connection.Execute(query, new { ClassID = classID });

                if (rowDeleted <= 0)
                {
                    return false;
                }

                return true;
            }
        }

        public bool Update(ClassDTO classDTO)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = @"UPDATE class SET ClassName = @ClassName, 
                                    Room = @Room, 
                                    SubjectID = @SubjectID, 
                                    TeacherID = @TeacherID, 
                                    StartPeriod = @StartPeriod, 
                                    EndPeriod = @EndPeriod,
                                    Day = @Day
                                WHERE ClassID = @ClassID";

                int rowUpdated = connection.Execute(query, classDTO);

                if (rowUpdated <= 0)
                {
                    return false;
                }

                return true;
            }
        }

    }
}
