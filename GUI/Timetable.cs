using BLL;
using DAL;
using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class Timetable : Form
    {
        StudentBLL studentBLL;
        SubjectBLL subjectBLL;
        int studentId;

        public Timetable(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            studentBLL = new StudentBLL();
            subjectBLL = new SubjectBLL();

            // Lấy danh sách thời khóa biểu
            List<ClassDTO> timetable = studentBLL.getTimetableStudent(studentId);
            loadTimetableStudent(timetable);
        }

        public void loadTimetableStudent(List<ClassDTO> timetable)
        {
            foreach (ClassDTO classDTO in timetable)
            {
                SubjectDTO subject = subjectBLL.GetSubjectByID(classDTO.SubjectID);
                Panel panel = new Panel
                {
                    BackColor = System.Drawing.Color.Khaki,
                    Dock = DockStyle.Fill,
                    Margin = new Padding(2),
                };

                Label subjectLabel = new Label
                {
                    Text = $"Môn: {subject.SubjectName}",
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                };

                Label roomLabel = new Label
                {
                    Text = classDTO.Room,
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                };
                panel.Controls.Add(subjectLabel);
                panel.Controls.Add(roomLabel);
                tableLayoutPanelTimetable.Controls.Add(panel, classDTO.Day - 1, classDTO.StartPeriod);
                tableLayoutPanelTimetable.SetRowSpan(panel, (classDTO.EndPeriod - classDTO.StartPeriod) + 1);
            }
        }

        private void tableLayoutPanelTimetable_Paint(object sender, PaintEventArgs e)
        {
        
        }

  
    }
}


