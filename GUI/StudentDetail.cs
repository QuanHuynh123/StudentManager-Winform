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
        private TeacherBLL teacherBLL;
        private ClassBLL classBLL;
        StudentDTO student;
        //private TrainingProgramBLL trainingProgramBLL;
        private int studentID;
        public StudentDetail(int studentID)
        {
            InitializeComponent();
            this.studentID = studentID;
            init(this.studentID);
        }

        private void init(int studentId)
        {
            studentBLL = new StudentBLL();
            departmentBLL = new DepartmentBLL();
            trainingProgramBLL = new TrainingProgramBLL();
            teacherBLL = new TeacherBLL();
            classBLL = new ClassBLL();
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
            ClassDTO classDTO = classBLL.getClassById(student.ClassID);
            labelClass.Text = classDTO.ClassName.ToString();

            DepartmentDTO department = departmentBLL.findByIdDepartment(student.DepartmentID);
            labelDepartment.Text = department.DepartmentName.ToString();
            labelDepartment2.Text = department.DepartmentName.ToString();
            TrainingProgramDTO trainingProgram = trainingProgramBLL.FindByIdTrainingProgram(student.ProgramID);
            labelTrainingProgram.Text = trainingProgram.ProgramName.ToString();
            labelYear.Text = trainingProgram.StartYear.ToString() + "-" + trainingProgram.EndYear.ToString();

            labelGPA.Text = student.Gpa.ToString();
            labelTotalCredits.Text = student.TotalCreditsEarned.ToString();

            TeacherDTO teacherDTO = teacherBLL.GetInforTeacherByIdStudent(studentID);
            label_nameTeacher.Text = teacherDTO.FullName.ToString();
            label_phone.Text = teacherDTO.PhoneNumber.ToString();
            label_emailTeacher.Text = teacherDTO.Email.ToString();
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

            //Transcript transcript = 
                new Transcript(studentID, student.TotalCreditsEarned, student.Gpa).Show();
            //{
            //    TopLevel = false, 
            //    FormBorderStyle = FormBorderStyle.None,
            //    Dock = DockStyle.Fill 
            //};

            //List<Control> oldControls = new List<Control>();
            //foreach (Control control in tableLayoutPanel1.Controls)
            //{
            //    oldControls.Add(control);
            //}

            //transcript.Show();
            ////transcript.BringToFront();
            //tableLayoutPanel1.Controls.Clear();
            //tableLayoutPanel1.ColumnCount = 1;
            //tableLayoutPanel1.RowCount = 1; 
            //tableLayoutPanel1.Controls.Add(transcript, 0, 0);

            //transcript.FormClosed += (sender, e) =>
            //{
            //    // Khôi phục các control cũ sau khi đóng
            //    tableLayoutPanel1.Controls.Clear();
            //    tableLayoutPanel1.RowCount = 1;
            //    tableLayoutPanel1.ColumnCount = 2;
            //    foreach (var control in oldControls)
            //    {
            //        tableLayoutPanel1.Controls.Add(control);
            //    }
               
            //    init(this.studentID);
            //    oldControls.Clear();
            //};

        }


        private void openTimetable()
        {
            //Timetable timetable =  
                new Timetable(studentID).Show();
            //{
            //    TopLevel = false,
            //    FormBorderStyle = FormBorderStyle.None, 
            //    Dock = DockStyle.Fill 
            //};

            //timetable.BringToFront();
            //tableLayoutPanel1.Controls.Add(timetable, 0, 0);
            //tableLayoutPanel1.SetColumnSpan(timetable, 2);

            //timetable.FormClosed += (sender, e) =>
            //{
            //    tableLayoutPanel1.Controls.Remove(timetable);
            //    init(this.studentID);
            //};

            //timetable.Show();
        }
    }
}
