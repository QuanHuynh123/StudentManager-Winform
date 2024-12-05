using BLL;
using System.Drawing.Drawing2D;

namespace GUI
{

    public partial class home : Form
    {
        private Dictionary<string, (Panel, Label)> panels = [];
        private List<string> defaultVisible = [];
        //private List<PictureBox> pictureBoxes;
        private Size formSize;
        public home()
        {
            InitializeComponent();
            //pictureBoxes = new List<PictureBox> { pictureBox_studentlist, pictureBox_timetable, pictureBox_classlist, pictureBox_subject, pictureBox_department, pictureBox_program, pictureBox_account, pictureBox_settings, pictureBox_logout, pictureBox_home };

            panels.Add(Constants.Student, (panel_student, label_studentlist));
            panels.Add(Constants.TimeTable, (panel_timetable, label_timetable));
            panels.Add(Constants.Class, (panel_classlist, label_classlist));
            panels.Add(Constants.Subject, (panel_subject, label_subject));
            panels.Add(Constants.Department, (panel_department, label_department));
            panels.Add(Constants.TrainingProgram, (panel_program, label_program));
            panels.Add(Constants.Account, (panel_account, label_account));
            panels.Add(Constants.Setting, (panel_settings, label_settings));
            panels.Add(Constants.Logout, (panel_logout, label_logout));
            panels.Add(Constants.Home, (panel_home, label_home));

            defaultVisible.AddRange([Constants.Home, Constants.Setting, Constants.Logout]);

            openHome();

            // Áp dụng sự kiện hover cho tất cả các Panel
            ApplyHoverEffect();
            LoadAllFunction();

            // Decentralize
            LoadPanelForUser();
        }

        private void LoadAllFunction()
        {

            panel_home.Click += (sender, e) => openHome();
            foreach (Control control in panel_home.Controls)
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

            panel_account.Click += (sender, e) => openAccount();
            foreach (Control control in panel_account.Controls)
            {
                control.Click += (sender, e) => openAccount();
            }

            panel_program.Click += (sender, e) => openProgram();
            foreach (Control control in panel_program.Controls)
            {
                control.Click += (sender, e) => openProgram();
            }

            panel_logout.Click += (sender, e) => Logout();
            foreach (Control control in panel_logout.Controls)
            {
                control.Click += (sender, e) => Logout();
            }
            panel_subject.Click += (sender, e) => openSubject();
            foreach (Control control in panel_subject.Controls)
            {
                control.Click += (sender, e) => openSubject();
            }

        }

        private void loadPanel(string title, System.Windows.Forms.Form iForm)
        {
            label_headertitle.Text = title;
            userPanel.Controls.Clear();
            userPanel.Controls.Add(iForm);
            iForm.Show();
        }

        private void openProfile()
        {
            Profile accountWindow = new Profile() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadPanel("QUẢN LÝ TÀI KHOẢN", accountWindow);
        }

        private void openProgram()
        {
            TrainingProgram programWindow = new TrainingProgram() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadPanel("QUẢN LÝ CHƯƠNG TRÌNH ĐÀO TẠO", programWindow);
        }

        private void openSubject()
        {
            Subject subjectWindow = new Subject() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadPanel("QUẢN LÝ MÔN", subjectWindow);
        }

        private void openHome()
        {
            Dashboard dashboardWindow = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadPanel("XIN CHÀO", dashboardWindow);
        }
        private void openDepartment()
        {
            Department departmentWindow = new Department() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadPanel("QUẢN LÝ KHOA", departmentWindow);
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

        private void openAccount()
        {
            Account accountWindow = new Account() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loadPanel("QUẢN LÝ TÀI KHOẢN", accountWindow);
        }

        private void ApplyHoverEffect()
        {
            foreach (var panel in panels)
            {
                // Đặt sự kiện cho chính Panel
                panel.Value.Item1.MouseEnter += (sender, e) => SetHoverState(panel.Value.Item1, panel.Value.Item2, true);
                panel.Value.Item1.MouseLeave += (sender, e) => SetHoverState(panel.Value.Item1, panel.Value.Item2, false);

                // Đặt sự kiện cho các phần tử con trong Panel
                foreach (Control control in panel.Value.Item1.Controls)
                {
                    control.MouseEnter += (sender, e) => SetHoverState(panel.Value.Item1, panel.Value.Item2, true);
                    control.MouseLeave += (sender, e) => SetHoverState(panel.Value.Item1, panel.Value.Item2, false);
                }
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

        private void LoadPanelForUser()
        {
            if (SessionLogin.IsLoggedIn)
            {
                label_name.Text = SessionLogin.LoggedInTeacher.FullName;

                var myFeatures = SessionLogin.LoggedInTeacher.Role.RoleActivities.GroupBy(ra => ra.Feature).ToList().Where(x => x.Key != null);

                foreach (var item in defaultVisible)
                {
                    panels.Remove(item);
                }

                var unavailable = panels.ExceptBy(myFeatures.Select(mf => mf.Key.ToLower()), p => p.Key.ToLower());

                foreach (var panel in unavailable)
                {
                    panel.Value.Item1.Visible = false;
                    panel.Value.Item2.Visible = false;
                }
            }
            else
            {
                label_name.Text = "User";
            }
        }

        private void pictureBox_avatar_Click(object sender, EventArgs e)
        {
            openProfile();
        }

        private void flowLayoutPanelMenu_Paint(object sender, PaintEventArgs e)
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
