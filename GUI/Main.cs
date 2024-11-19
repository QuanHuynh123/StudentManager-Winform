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
        public home()
        {
            InitializeComponent();
            panels = new List<Panel> { panel_student, panel_fc2, panel_fc3, panel_fc4, panel_department, panel_fc6, panel_fc7, panel_fc8, panel_logout, panel_fc10 };
            labels = new List<Label> { label_fc1, label_fc2, label_fc3, label_fc4, label_fc5, label_fc6, label_fc7, label_fc8, label_fc9, label_fc10 };
            pictureBoxes = new List<PictureBox> { pictureBox_fc1, pictureBox_fc2, pictureBox_fc3, pictureBox_fc4, pictureBox_fc5, pictureBox_fc6, pictureBox_fc7, pictureBox_fc8, pictureBox_fc9, pictureBox_fc10 };

            panel_logout.Click += (sender, e) => Logout();
            foreach (Control control in panel_logout.Controls)
            {
                control.Click += (sender, e) => Logout();
            }

            panel_department.Click += (sender, e) => openDepartment();
            foreach (Control control in panel_department.Controls)
            {
                control.Click += (sender, e) => openDepartment();
            }

            panel_student.Click += (sender, e) => openStudentList();
            foreach (Control control in panel_student.Controls)
            {
                control.Click += (sender, e) => openStudentList();
            }

            // Áp dụng sự kiện hover cho tất cả các Panel
            for (int i = 0; i < panels.Count; i++)
            {
                ApplyHoverEffect(panels[i], labels[i]);
            }

            setNameUser();
        }

        private void openDepartment()
        {
            if (SessionLogin.LoggedInTeacher.RoleID == 4)
            {
                this.Close();
                new Department().Show();
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền hạn để truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void openStudentList()
        {

                this.Close();
                new Student().Show();
        }

        private void setNameUser()
        {
            if (SessionLogin.IsLoggedIn != null)
            {
                label13.Text = SessionLogin.LoggedInTeacher.FullName;
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

        private void Logout()
        {
            SessionLogin.Logout();
            MessageBox.Show("Bạn đã đăng xuất thành công!", "Đăng xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            new Login().Show(); // Mở lại form đăng nhập
        }

        private void label_fc1_Click(object sender, EventArgs e)
        {

        }
    }
}
