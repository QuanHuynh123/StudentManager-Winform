using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class StudentDetail : Form
    {
        private StudentBLL studentBLL;
        private DepartmentBLL departmentBLL;
        private TrainingProgramBLL trainingProgramBLL;
        StudentDTO student;
        //private TrainingProgramBLL trainingProgramBLL;
        private int studentID;
        public StudentDetail(int studentID)
        {
            InitializeComponent();
            studentBLL = new StudentBLL();
            departmentBLL = new DepartmentBLL();
            trainingProgramBLL = new TrainingProgramBLL();
            this.studentID = studentID;
            student = studentBLL.getStudentInfo(studentID);
            loadInfoStudent();
            loadAllFunction();
        }
        private void loadInfoStudent()
        {
            labelStudentID.Text = student.StudentID.ToString();
            labelNameStudent.Text = student.FullName.ToString();
            if (student.Gender)
                labelGender.Text = "Nam";
            else labelGender.Text = "Nữ";
            labelPhone.Text = student.PhoneNumber.ToString();
            labelEmail.Text = student.Email.ToString();
            labelHometown.Text = student.Hometown.ToString();
            labelAddress.Text = student.PermanentAddress.ToString();
            labelClass.Text = student.Class.ToString();

            DepartmentDTO department = departmentBLL.findByIdDepartment(student.DepartmentID);
            labelDepartment.Text = department.DepartmentName.ToString();
            labelDepartment2.Text = department.DepartmentName.ToString();
            TrainingProgramDTO trainingProgram = trainingProgramBLL.FindByIdTrainingProgram(student.ProgramID);
            labelTrainingProgram.Text = trainingProgram.ProgramName.ToString();
            labelYear.Text = trainingProgram.StartYear.ToString() + "-" + trainingProgram.EndYear.ToString();

            labelGPA.Text = student.Gpa.ToString();
            labelTotalCredits.Text = student.TotalCreditsEarned.ToString();

            label_nameTeacher.Text = SessionLogin.LoggedInTeacher.FullName.ToString();
            label_phone.Text = SessionLogin.LoggedInTeacher.PhoneNumber.ToString();
            label_emailTeacher.Text = SessionLogin.LoggedInTeacher.Email.ToString();
        }

        private void loadAllFunction()
        {
            panelTimetable.Click += (sender, e) => openTimetable();
            foreach (Control control in panelTimetable.Controls)
            {
                control.Click += (sender, e) => openTimetable();
            }

            panelTranscript.Click += (sender, e) => openTranscript();
            foreach (Control control in panelTranscript.Controls)
            {
                control.Click += (sender, e) => openTranscript();
            }
        }

        private void openTranscript()
        {
            new Transcript(studentID, student.TotalCreditsEarned, student.Gpa).Show();
        }

        private void openTimetable()
        {
            new Timetable(studentID).Show();
        }
    }
}
