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
        //private TrainingProgramBLL trainingProgramBLL;
        private int studentID; 
        public StudentDetail(int studentiD)
        {
            InitializeComponent();
            studentBLL = new StudentBLL();
            this.studentID = studentiD;
            loadInfoStudent();
            loadAllFunction();
        }
        private void loadInfoStudent() { 
            StudentDTO  student = studentBLL.getStudentInfo(studentID);
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

            //DepartmentDTO departmentDTO;
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
            //new Transcript().Show();
        }

        private void openTimetable()
        {
            new Timetable().Show();
        }
    }
}
