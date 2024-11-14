using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class home : Form
    {
        private List<Panel> panels;
        private List<Label> labels;
        private List<PictureBox> pictureBoxes;
        private TeacherBLL teacherBLL;
        private TeacherDTO currentTeacher;
        public home()
        {
            InitializeComponent();
            panels = new List<Panel> { panel_fc1, panel_fc2, panel_fc3, panel_fc4, panel_fc5, panel_fc6, panel_fc7, panel_fc8, panel_fc9, panel_fc10 };
            labels = new List<Label> { label_fc1, label_fc2, label_fc3, label_fc4, label_fc5, label_fc6, label_fc7, label_fc8, label_fc9, label_fc10 };
            pictureBoxes = new List<PictureBox> { pictureBox_fc1, pictureBox_fc2, pictureBox_fc3, pictureBox_fc4, pictureBox_fc5, pictureBox_fc6, pictureBox_fc7, pictureBox_fc8, pictureBox_fc9, pictureBox_fc10 };

            // Áp dụng sự kiện hover cho tất cả các Panel
            for (int i = 0; i < panels.Count; i++)
            {
                ApplyHoverEffect(panels[i], labels[i]);
            }
            teacherBLL = new TeacherBLL();
            currentTeacher = teacherBLL.getInforTeacher(SessionLogin.LoggedInUsername);

            if (currentTeacher != null)
            {
                label13.Text = currentTeacher.GetFulltName();
            }
            else
            {
                label13.Text = "User";
            }
        }


        private void ApplyHoverEffect(Panel panel, Label label)
        {
            // Đặt sự kiện cho chính Panel
            panel.MouseEnter += (sender, e) => SetHoverState(panel, label, true);
            panel.MouseLeave += (sender, e) => SetHoverState(panel, label, false);

            // Đặt sự kiện cho các phần tử con trong Panel
            foreach (Control control in panel.Controls)
            {
                control.MouseEnter += (sender, e) => SetHoverState(panel, label, true);
                control.MouseLeave += (sender, e) => SetHoverState(panel, label, false);
            }
        }

        private void SetHoverState(Panel panel, Label label, bool isHovering)
        {
            if (isHovering)
            {
                panel.BackColor = Color.LightGray; // Đổi màu nền Panel khi hover
                label.ForeColor = Color.Black; // Đổi màu chữ của Label khi hover
            }
            else
            {
                panel.BackColor = Color.Transparent; // Trả về màu nền ban đầu khi không hover
                label.ForeColor = Color.White; // Trả về màu chữ ban đầu khi không hover
            }
        }

        private void label_fc5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dashboard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_fc9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
