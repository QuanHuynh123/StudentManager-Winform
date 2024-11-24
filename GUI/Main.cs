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
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace GUI
{

    public partial class home : Form
    {
        private List<Panel> panels;
        private List<Label> labels;
        private List<PictureBox> pictureBoxes;
        private Size formSize;
        public home()
        {
            InitializeComponent();
            panels = new List<Panel> { panel_student, panel_timetable, panel_classlist, panel_subject, panel_department, panel_program, panel_account, panel_settings, panel_logout, panel_home };
            labels = new List<Label> { label_studentlist, label_timetable, label_classlist, label_subject, label_department, label_program, label_account, label_settings, label_logout, label_home };
            pictureBoxes = new List<PictureBox> { pictureBox_studentlist, pictureBox_timetable, pictureBox_classlist, pictureBox_subject, pictureBox_department, pictureBox_program, pictureBox_account, pictureBox_settings, pictureBox_logout, pictureBox_home };

            // Áp dụng sự kiện hover cho tất cả các Panel
            for (int i = 0; i < panels.Count; i++)
            {
                ApplyHoverEffect(panels[i], labels[i]);
            }
            openHome();
            loadAllFunction();
            setNameUser();
        }

        private void loadAllFunction()
        {

            panel_home.Click += (sender, e) => openHome();
            foreach (Control control in panel_department.Controls)
            {
                control.Click += (sender, e) => openHome();
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

            panel_classlist.Click += (sender, e) => openClassList();
            foreach (Control control in panel_classlist.Controls)
            {
                control.Click += (sender, e) => openClassList();
            }

            panel_program.Click += (sender, e) => openProgram();
            foreach (Control control in panel_program.Controls)
            {
                control.Click += (sender, e) => openProgram();
            }

            panel_account.Click += (sender, e) => openAccount();
            foreach (Control control in panel_account.Controls)
            {
                control.Click += (sender, e) => openAccount();
            }

            panel_logout.Click += (sender, e) => Logout();
            foreach (Control control in panel_logout.Controls)
            {
                control.Click += (sender, e) => Logout();
            }
        }

        private void loadPanel(string title, System.Windows.Forms.Form iForm)
        {
            label_headertitle.Text = title;
            userPanel.Controls.Clear();
            userPanel.Controls.Add(iForm);
            iForm.Show();
        }

        private void openAccount()
        {
            Account accountWindow = new Account() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadPanel("QUẢN LÝ TÀI KHOẢN", accountWindow);
        }

        private void openProgram()
        {
            TrainingProgram programWindow = new TrainingProgram() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadPanel("QUẢN LÝ CHƯƠNG TRÌNH ĐÀO TẠO", programWindow);
        }

        private void openHome()
        {
            Dashboard dashboardWindow = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadPanel("XIN CHÀO", dashboardWindow);
        }
        private void openDepartment()
        {
            if (SessionLogin.LoggedInTeacher.RoleID == 4)
            {
                //    this.Close();
                //    new Department().Show();
                Department departmentWindow = new Department() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                loadPanel("QUẢN LÝ KHOA", departmentWindow);
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền hạn để truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void openStudentList()
        {
            Student studentWindow = new Student() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadPanel("QUẢN LÝ SINH VIÊN", studentWindow);
        }
        private void openClassList()
        {
            Class classWindow = new Class() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadPanel("QUẢN LÝ LỚP", classWindow);
        }

        private void setNameUser()
        {
            if (SessionLogin.IsLoggedIn != null)
            {
                label_name.Text = SessionLogin.LoggedInTeacher.FullName;
            }
            else
            {
                label_name.Text = "User";
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

        private void label_home_Click(object sender, EventArgs e)
        {

        }

        private void label_subject_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_studentlist_Click(object sender, EventArgs e)
        {

        }
    }
    public class GradientPanel : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new
            LinearGradientBrush(this.ClientRectangle, this.ColorTop,
            this.ColorBottom, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
