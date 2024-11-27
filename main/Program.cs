using DTO;
using BLL;
using System;
using System.Collections.Generic;
using DAL;
using System.Security.Principal;

namespace YourNamespace // Thay YourNamespace bằng namespace của bạn
{
    class Program
    {
        static void Main(string[] args)
        {
            SubjectBLL subjectBLL = new SubjectBLL();
            List<SubjectDTO> subjects = subjectBLL.GetSubjectByTeacherID(1);
            Console.WriteLine(subjects[0].SubjectName);
        }
    }
}
