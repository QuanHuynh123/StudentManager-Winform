using System.Reflection;
using System.Windows.Forms;

namespace GUI
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            tableLayoutPanel = new TableLayoutPanel();
            leftPanel = new Panel();
            flowLayoutPanelMenu = new FlowLayoutPanel();
            panelSpace = new Panel();
            panel_student = new Panel();
            pictureBox_studentlist = new PictureBox();
            label_studentlist = new Label();
            panel_timetable = new Panel();
            pictureBox_timetable = new PictureBox();
            label_timetable = new Label();
            panel_classlist = new Panel();
            pictureBox_classlist = new PictureBox();
            label_classlist = new Label();
            panel_subject = new Panel();
            pictureBox_subject = new PictureBox();
            label_subject = new Label();
            panel_department = new Panel();
            pictureBox_department = new PictureBox();
            label_department = new Label();
            panel_program = new Panel();
            pictureBox_program = new PictureBox();
            label_program = new Label();
            panel_account = new Panel();
            pictureBox_account = new PictureBox();
            label_account = new Label();
            panel_settings = new Panel();
            pictureBox_settings = new PictureBox();
            label_settings = new Label();
            panel_logout = new Panel();
            pictureBox_logout = new PictureBox();
            label_logout = new Label();
            panel1 = new Panel();
            panel_home = new Panel();
            pictureBox_home = new PictureBox();
            label_home = new Label();
            panel_apptitle = new Panel();
            label1 = new Label();
            pictureBox_school = new PictureBox();
            topPanel = new Panel();
            panel_avatar = new Panel();
            pictureBox_avatar = new PictureBox();
            panel_header = new Panel();
            label_name = new Label();
            panel_name = new Panel();
            label_role = new Label();
            label_headertitle = new Label();
            mainPanel = new Panel();
            userPanel = new Panel();
            tableLayoutPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            flowLayoutPanelMenu.SuspendLayout();
            panel_student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_studentlist).BeginInit();
            panel_timetable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_timetable).BeginInit();
            panel_classlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_classlist).BeginInit();
            panel_subject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_subject).BeginInit();
            panel_department.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_department).BeginInit();
            panel_program.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_program).BeginInit();
            panel_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_account).BeginInit();
            panel_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_settings).BeginInit();
            panel_logout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logout).BeginInit();
            panel1.SuspendLayout();
            panel_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_home).BeginInit();
            panel_apptitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_school).BeginInit();
            topPanel.SuspendLayout();
            panel_avatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_avatar).BeginInit();
            panel_header.SuspendLayout();
            panel_name.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.White;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel.Controls.Add(leftPanel, 0, 0);
            tableLayoutPanel.Controls.Add(topPanel, 1, 0);
            tableLayoutPanel.Controls.Add(mainPanel, 1, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8335285F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 86.16647F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel.Size = new Size(1208, 692);
            tableLayoutPanel.TabIndex = 0;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(45, 45, 49);
            leftPanel.Controls.Add(flowLayoutPanelMenu);
            leftPanel.Controls.Add(panel1);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(3, 2);
            leftPanel.Margin = new Padding(3, 2, 3, 2);
            leftPanel.MaximumSize = new Size(350, 1485);
            leftPanel.MinimumSize = new Size(236, 635);
            leftPanel.Name = "leftPanel";
            tableLayoutPanel.SetRowSpan(leftPanel, 2);
            leftPanel.Size = new Size(236, 688);
            leftPanel.TabIndex = 0;
            // 
            // flowLayoutPanelMenu
            // 
            flowLayoutPanelMenu.BackColor = Color.FromArgb(45, 45, 49);
            flowLayoutPanelMenu.Controls.Add(panelSpace);
            flowLayoutPanelMenu.Controls.Add(panel_student);
            flowLayoutPanelMenu.Controls.Add(panel_timetable);
            flowLayoutPanelMenu.Controls.Add(panel_classlist);
            flowLayoutPanelMenu.Controls.Add(panel_subject);
            flowLayoutPanelMenu.Controls.Add(panel_department);
            flowLayoutPanelMenu.Controls.Add(panel_program);
            flowLayoutPanelMenu.Controls.Add(panel_account);
            flowLayoutPanelMenu.Controls.Add(panel_settings);
            flowLayoutPanelMenu.Controls.Add(panel_logout);
            flowLayoutPanelMenu.Dock = DockStyle.Bottom;
            flowLayoutPanelMenu.Location = new Point(0, 158);
            flowLayoutPanelMenu.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            flowLayoutPanelMenu.Size = new Size(236, 530);
            flowLayoutPanelMenu.TabIndex = 22;
            // 
            // panelSpace
            // 
            panelSpace.BackColor = Color.White;
            panelSpace.Dock = DockStyle.Top;
            panelSpace.Location = new Point(3, 2);
            panelSpace.Margin = new Padding(3, 2, 3, 2);
            panelSpace.Name = "panelSpace";
            panelSpace.Size = new Size(236, 4);
            panelSpace.TabIndex = 0;
            // 
            // panel_student
            // 
            panel_student.Controls.Add(pictureBox_studentlist);
            panel_student.Controls.Add(label_studentlist);
            panel_student.Dock = DockStyle.Top;
            panel_student.Location = new Point(0, 13);
            panel_student.Margin = new Padding(0, 5, 0, 5);
            panel_student.Name = "panel_student";
            panel_student.Size = new Size(236, 45);
            panel_student.TabIndex = 20;
            // 
            // pictureBox_studentlist
            // 
            pictureBox_studentlist.Image = (Image)resources.GetObject("pictureBox_studentlist.Image");
            pictureBox_studentlist.Location = new Point(4, 0);
            pictureBox_studentlist.Margin = new Padding(3, 2, 3, 2);
            pictureBox_studentlist.Name = "pictureBox_studentlist";
            pictureBox_studentlist.Size = new Size(52, 45);
            pictureBox_studentlist.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_studentlist.TabIndex = 5;
            pictureBox_studentlist.TabStop = false;
            // 
            // label_studentlist
            // 
            label_studentlist.AutoSize = true;
            label_studentlist.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_studentlist.ForeColor = Color.White;
            label_studentlist.Location = new Point(67, 8);
            label_studentlist.Name = "label_studentlist";
            label_studentlist.Size = new Size(97, 21);
            label_studentlist.TabIndex = 4;
            label_studentlist.Text = "Student List";
            // 
            // panel_timetable
            // 
            panel_timetable.Controls.Add(pictureBox_timetable);
            panel_timetable.Controls.Add(label_timetable);
            panel_timetable.Dock = DockStyle.Top;
            panel_timetable.Location = new Point(0, 68);
            panel_timetable.Margin = new Padding(0, 5, 0, 5);
            panel_timetable.Name = "panel_timetable";
            panel_timetable.Size = new Size(236, 45);
            panel_timetable.TabIndex = 21;
            // 
            // pictureBox_timetable
            // 
            pictureBox_timetable.Image = (Image)resources.GetObject("pictureBox_timetable.Image");
            pictureBox_timetable.InitialImage = (Image)resources.GetObject("pictureBox_timetable.InitialImage");
            pictureBox_timetable.Location = new Point(4, 0);
            pictureBox_timetable.Margin = new Padding(3, 2, 3, 2);
            pictureBox_timetable.Name = "pictureBox_timetable";
            pictureBox_timetable.Size = new Size(52, 45);
            pictureBox_timetable.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_timetable.TabIndex = 5;
            pictureBox_timetable.TabStop = false;
            // 
            // label_timetable
            // 
            label_timetable.AutoSize = true;
            label_timetable.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label_timetable.ForeColor = Color.White;
            label_timetable.Location = new Point(67, 10);
            label_timetable.Name = "label_timetable";
            label_timetable.Size = new Size(84, 21);
            label_timetable.TabIndex = 6;
            label_timetable.Text = "TimeTable";
            // 
            // panel_classlist
            // 
            panel_classlist.Controls.Add(pictureBox_classlist);
            panel_classlist.Controls.Add(label_classlist);
            panel_classlist.Dock = DockStyle.Top;
            panel_classlist.Location = new Point(0, 123);
            panel_classlist.Margin = new Padding(0, 5, 0, 5);
            panel_classlist.Name = "panel_classlist";
            panel_classlist.Size = new Size(236, 45);
            panel_classlist.TabIndex = 22;
            // 
            // pictureBox_classlist
            // 
            pictureBox_classlist.Image = (Image)resources.GetObject("pictureBox_classlist.Image");
            pictureBox_classlist.Location = new Point(-2, 2);
            pictureBox_classlist.Margin = new Padding(3, 2, 3, 2);
            pictureBox_classlist.Name = "pictureBox_classlist";
            pictureBox_classlist.Size = new Size(52, 45);
            pictureBox_classlist.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_classlist.TabIndex = 7;
            pictureBox_classlist.TabStop = false;
            // 
            // label_classlist
            // 
            label_classlist.AutoSize = true;
            label_classlist.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label_classlist.ForeColor = Color.White;
            label_classlist.Location = new Point(67, 13);
            label_classlist.Name = "label_classlist";
            label_classlist.Size = new Size(75, 21);
            label_classlist.TabIndex = 8;
            label_classlist.Text = "Class List";
            // 
            // panel_subject
            // 
            panel_subject.Controls.Add(pictureBox_subject);
            panel_subject.Controls.Add(label_subject);
            panel_subject.Dock = DockStyle.Top;
            panel_subject.Location = new Point(0, 178);
            panel_subject.Margin = new Padding(0, 5, 0, 5);
            panel_subject.Name = "panel_subject";
            panel_subject.Size = new Size(235, 45);
            panel_subject.TabIndex = 23;
            // 
            // pictureBox_subject
            // 
            pictureBox_subject.Image = (Image)resources.GetObject("pictureBox_subject.Image");
            pictureBox_subject.Location = new Point(4, 0);
            pictureBox_subject.Margin = new Padding(3, 2, 3, 2);
            pictureBox_subject.Name = "pictureBox_subject";
            pictureBox_subject.Size = new Size(52, 45);
            pictureBox_subject.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_subject.TabIndex = 9;
            pictureBox_subject.TabStop = false;
            // 
            // label_subject
            // 
            label_subject.AutoSize = true;
            label_subject.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label_subject.ForeColor = Color.White;
            label_subject.Location = new Point(67, 10);
            label_subject.Name = "label_subject";
            label_subject.Size = new Size(65, 21);
            label_subject.TabIndex = 10;
            label_subject.Text = "Subject";
            // 
            // panel_department
            // 
            panel_department.Controls.Add(pictureBox_department);
            panel_department.Controls.Add(label_department);
            panel_department.Dock = DockStyle.Top;
            panel_department.Location = new Point(0, 233);
            panel_department.Margin = new Padding(0, 5, 0, 5);
            panel_department.Name = "panel_department";
            panel_department.Size = new Size(236, 45);
            panel_department.TabIndex = 25;
            // 
            // pictureBox_department
            // 
            pictureBox_department.Image = (Image)resources.GetObject("pictureBox_department.Image");
            pictureBox_department.Location = new Point(4, -1);
            pictureBox_department.Margin = new Padding(3, 2, 3, 2);
            pictureBox_department.Name = "pictureBox_department";
            pictureBox_department.Size = new Size(52, 45);
            pictureBox_department.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_department.TabIndex = 13;
            pictureBox_department.TabStop = false;
            // 
            // label_department
            // 
            label_department.AutoSize = true;
            label_department.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label_department.ForeColor = Color.White;
            label_department.Location = new Point(67, 9);
            label_department.Name = "label_department";
            label_department.Size = new Size(98, 21);
            label_department.TabIndex = 14;
            label_department.Text = "Department";
            // 
            // panel_program
            // 
            panel_program.Controls.Add(pictureBox_program);
            panel_program.Controls.Add(label_program);
            panel_program.Dock = DockStyle.Top;
            panel_program.Location = new Point(0, 288);
            panel_program.Margin = new Padding(0, 5, 0, 5);
            panel_program.Name = "panel_program";
            panel_program.Size = new Size(236, 45);
            panel_program.TabIndex = 24;
            // 
            // pictureBox_program
            // 
            pictureBox_program.Image = (Image)resources.GetObject("pictureBox_program.Image");
            pictureBox_program.Location = new Point(5, 5);
            pictureBox_program.Margin = new Padding(3, 2, 3, 2);
            pictureBox_program.Name = "pictureBox_program";
            pictureBox_program.Size = new Size(52, 45);
            pictureBox_program.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_program.TabIndex = 11;
            pictureBox_program.TabStop = false;
            // 
            // label_program
            // 
            label_program.AutoSize = true;
            label_program.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label_program.ForeColor = Color.White;
            label_program.Location = new Point(67, 13);
            label_program.Name = "label_program";
            label_program.Size = new Size(130, 21);
            label_program.TabIndex = 12;
            label_program.Text = "TrainingProgram";
            // 
            // panel_account
            // 
            panel_account.Controls.Add(pictureBox_account);
            panel_account.Controls.Add(label_account);
            panel_account.Dock = DockStyle.Top;
            panel_account.Location = new Point(0, 343);
            panel_account.Margin = new Padding(0, 5, 0, 5);
            panel_account.Name = "panel_account";
            panel_account.Size = new Size(235, 45);
            panel_account.TabIndex = 26;
            // 
            // pictureBox_account
            // 
            pictureBox_account.Image = (Image)resources.GetObject("pictureBox_account.Image");
            pictureBox_account.Location = new Point(2, 5);
            pictureBox_account.Margin = new Padding(3, 2, 3, 2);
            pictureBox_account.Name = "pictureBox_account";
            pictureBox_account.Size = new Size(52, 45);
            pictureBox_account.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_account.TabIndex = 15;
            pictureBox_account.TabStop = false;
            // 
            // label_account
            // 
            label_account.AutoSize = true;
            label_account.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label_account.ForeColor = Color.White;
            label_account.Location = new Point(67, 13);
            label_account.Name = "label_account";
            label_account.Size = new Size(71, 21);
            label_account.TabIndex = 16;
            label_account.Text = "Account";
            // 
            // panel_settings
            // 
            panel_settings.Controls.Add(pictureBox_settings);
            panel_settings.Controls.Add(label_settings);
            panel_settings.Dock = DockStyle.Top;
            panel_settings.Location = new Point(0, 398);
            panel_settings.Margin = new Padding(0, 5, 0, 5);
            panel_settings.Name = "panel_settings";
            panel_settings.Size = new Size(235, 45);
            panel_settings.TabIndex = 27;
            // 
            // pictureBox_settings
            // 
            pictureBox_settings.Image = (Image)resources.GetObject("pictureBox_settings.Image");
            pictureBox_settings.Location = new Point(4, 0);
            pictureBox_settings.Margin = new Padding(3, 2, 3, 2);
            pictureBox_settings.Name = "pictureBox_settings";
            pictureBox_settings.Size = new Size(52, 45);
            pictureBox_settings.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_settings.TabIndex = 17;
            pictureBox_settings.TabStop = false;
            // 
            // label_settings
            // 
            label_settings.AutoSize = true;
            label_settings.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label_settings.ForeColor = Color.White;
            label_settings.Location = new Point(67, 11);
            label_settings.Name = "label_settings";
            label_settings.Size = new Size(70, 21);
            label_settings.TabIndex = 18;
            label_settings.Text = "Settings";
            // 
            // panel_logout
            // 
            panel_logout.Controls.Add(pictureBox_logout);
            panel_logout.Controls.Add(label_logout);
            panel_logout.Dock = DockStyle.Top;
            panel_logout.Location = new Point(0, 453);
            panel_logout.Margin = new Padding(0, 5, 0, 5);
            panel_logout.Name = "panel_logout";
            panel_logout.Size = new Size(236, 45);
            panel_logout.TabIndex = 28;
            // 
            // pictureBox_logout
            // 
            pictureBox_logout.Image = (Image)resources.GetObject("pictureBox_logout.Image");
            pictureBox_logout.Location = new Point(4, 2);
            pictureBox_logout.Margin = new Padding(3, 2, 3, 2);
            pictureBox_logout.Name = "pictureBox_logout";
            pictureBox_logout.Size = new Size(52, 45);
            pictureBox_logout.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_logout.TabIndex = 19;
            pictureBox_logout.TabStop = false;
            // 
            // label_logout
            // 
            label_logout.AutoSize = true;
            label_logout.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label_logout.ForeColor = SystemColors.Window;
            label_logout.Location = new Point(67, 10);
            label_logout.Name = "label_logout";
            label_logout.Size = new Size(63, 21);
            label_logout.TabIndex = 20;
            label_logout.Text = "Logout";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel_home);
            panel1.Controls.Add(panel_apptitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.MaximumSize = new Size(306, 1114);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 6);
            panel1.Size = new Size(236, 154);
            panel1.TabIndex = 0;
            // 
            // panel_home
            // 
            panel_home.Controls.Add(pictureBox_home);
            panel_home.Controls.Add(label_home);
            panel_home.Dock = DockStyle.Bottom;
            panel_home.Location = new Point(0, 104);
            panel_home.Margin = new Padding(3, 2, 3, 2);
            panel_home.Name = "panel_home";
            panel_home.Size = new Size(236, 44);
            panel_home.TabIndex = 21;
            // 
            // pictureBox_home
            // 
            pictureBox_home.Image = (Image)resources.GetObject("pictureBox_home.Image");
            pictureBox_home.Location = new Point(6, 0);
            pictureBox_home.Margin = new Padding(3, 2, 3, 2);
            pictureBox_home.Name = "pictureBox_home";
            pictureBox_home.Size = new Size(52, 44);
            pictureBox_home.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_home.TabIndex = 1;
            pictureBox_home.TabStop = false;
            // 
            // label_home
            // 
            label_home.AutoSize = true;
            label_home.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_home.ForeColor = Color.White;
            label_home.Location = new Point(66, 12);
            label_home.Name = "label_home";
            label_home.Size = new Size(56, 20);
            label_home.TabIndex = 3;
            label_home.Text = "Home";
            // 
            // panel_apptitle
            // 
            panel_apptitle.Controls.Add(label1);
            panel_apptitle.Controls.Add(pictureBox_school);
            panel_apptitle.Dock = DockStyle.Top;
            panel_apptitle.Location = new Point(0, 0);
            panel_apptitle.Margin = new Padding(3, 2, 3, 2);
            panel_apptitle.Name = "panel_apptitle";
            panel_apptitle.Padding = new Padding(10, 3, 0, 0);
            panel_apptitle.Size = new Size(236, 58);
            panel_apptitle.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Himalaya", 22F, FontStyle.Bold);
            label1.Location = new Point(67, 3);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 22, 0, 0);
            label1.Size = new Size(145, 52);
            label1.TabIndex = 0;
            label1.Text = "UNIVERSITY";
            // 
            // pictureBox_school
            // 
            pictureBox_school.Dock = DockStyle.Left;
            pictureBox_school.Image = (Image)resources.GetObject("pictureBox_school.Image");
            pictureBox_school.Location = new Point(10, 3);
            pictureBox_school.Margin = new Padding(16, 2, 3, 2);
            pictureBox_school.Name = "pictureBox_school";
            pictureBox_school.Size = new Size(57, 55);
            pictureBox_school.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_school.TabIndex = 0;
            pictureBox_school.TabStop = false;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.Controls.Add(panel_avatar);
            topPanel.Controls.Add(panel_header);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(244, 2);
            topPanel.Margin = new Padding(3, 2, 3, 2);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(0, 0, 13, 0);
            topPanel.Size = new Size(961, 91);
            topPanel.TabIndex = 1;
            // 
            // panel_avatar
            // 
            panel_avatar.Controls.Add(pictureBox_avatar);
            panel_avatar.Dock = DockStyle.Right;
            panel_avatar.Location = new Point(804, 0);
            panel_avatar.Margin = new Padding(3, 2, 3, 2);
            panel_avatar.Name = "panel_avatar";
            panel_avatar.Size = new Size(144, 91);
            panel_avatar.TabIndex = 22;
            // 
            // pictureBox_avatar
            // 
            pictureBox_avatar.Dock = DockStyle.Fill;
            pictureBox_avatar.Image = (Image)resources.GetObject("pictureBox_avatar.Image");
            pictureBox_avatar.InitialImage = null;
            pictureBox_avatar.Location = new Point(0, 0);
            pictureBox_avatar.Margin = new Padding(3, 2, 3, 2);
            pictureBox_avatar.Name = "pictureBox_avatar";
            pictureBox_avatar.Padding = new Padding(0, 8, 0, 0);
            pictureBox_avatar.Size = new Size(144, 91);
            pictureBox_avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_avatar.TabIndex = 19;
            pictureBox_avatar.TabStop = false;
            pictureBox_avatar.Click += pictureBox_avatar_Click;
            // 
            // panel_header
            // 
            panel_header.Controls.Add(label_name);
            panel_header.Controls.Add(panel_name);
            panel_header.Controls.Add(label_headertitle);
            panel_header.Dock = DockStyle.Left;
            panel_header.Location = new Point(0, 0);
            panel_header.Margin = new Padding(3, 2, 3, 2);
            panel_header.Name = "panel_header";
            panel_header.Padding = new Padding(9, 15, 0, 0);
            panel_header.Size = new Size(685, 91);
            panel_header.TabIndex = 21;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.BackColor = Color.Transparent;
            label_name.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label_name.ForeColor = Color.MidnightBlue;
            label_name.Location = new Point(34, 48);
            label_name.Name = "label_name";
            label_name.Padding = new Padding(1, 0, 0, 0);
            label_name.Size = new Size(142, 20);
            label_name.TabIndex = 6;
            label_name.Text = "Trương Thị Mỹ Lan";
            // 
            // panel_name
            // 
            panel_name.Controls.Add(label_role);
            panel_name.Dock = DockStyle.Top;
            panel_name.Location = new Point(9, 52);
            panel_name.Margin = new Padding(3, 2, 3, 2);
            panel_name.MaximumSize = new Size(244, 22);
            panel_name.Name = "panel_name";
            panel_name.Size = new Size(244, 22);
            panel_name.TabIndex = 20;
            // 
            // label_role
            // 
            label_role.AutoSize = true;
            label_role.BackColor = Color.Transparent;
            label_role.Dock = DockStyle.Left;
            label_role.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_role.ForeColor = Color.Black;
            label_role.Location = new Point(0, 0);
            label_role.Name = "label_role";
            label_role.Size = new Size(31, 19);
            label_role.TabIndex = 5;
            label_role.Text = "GV.";
            // 
            // label_headertitle
            // 
            label_headertitle.AutoSize = true;
            label_headertitle.BackColor = Color.Transparent;
            label_headertitle.Dock = DockStyle.Top;
            label_headertitle.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            label_headertitle.ForeColor = Color.MidnightBlue;
            label_headertitle.Location = new Point(9, 15);
            label_headertitle.Name = "label_headertitle";
            label_headertitle.Size = new Size(145, 37);
            label_headertitle.TabIndex = 4;
            label_headertitle.Text = "XIN CHÀO";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Transparent;
            mainPanel.Controls.Add(userPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(244, 97);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(0, 0, 13, 0);
            mainPanel.Size = new Size(961, 593);
            mainPanel.TabIndex = 2;
            // 
            // userPanel
            // 
            userPanel.BackColor = Color.Transparent;
            userPanel.Dock = DockStyle.Fill;
            userPanel.Location = new Point(0, 0);
            userPanel.Margin = new Padding(3, 2, 3, 2);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(948, 593);
            userPanel.TabIndex = 10;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 692);
            Controls.Add(tableLayoutPanel);
            ForeColor = SystemColors.ControlLightLight;
            IsMdiContainer = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HOME";
            tableLayoutPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            flowLayoutPanelMenu.ResumeLayout(false);
            panel_student.ResumeLayout(false);
            panel_student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_studentlist).EndInit();
            panel_timetable.ResumeLayout(false);
            panel_timetable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_timetable).EndInit();
            panel_classlist.ResumeLayout(false);
            panel_classlist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_classlist).EndInit();
            panel_subject.ResumeLayout(false);
            panel_subject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_subject).EndInit();
            panel_department.ResumeLayout(false);
            panel_department.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_department).EndInit();
            panel_program.ResumeLayout(false);
            panel_program.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_program).EndInit();
            panel_account.ResumeLayout(false);
            panel_account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_account).EndInit();
            panel_settings.ResumeLayout(false);
            panel_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_settings).EndInit();
            panel_logout.ResumeLayout(false);
            panel_logout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logout).EndInit();
            panel1.ResumeLayout(false);
            panel_home.ResumeLayout(false);
            panel_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_home).EndInit();
            panel_apptitle.ResumeLayout(false);
            panel_apptitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_school).EndInit();
            topPanel.ResumeLayout(false);
            panel_avatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_avatar).EndInit();
            panel_header.ResumeLayout(false);
            panel_header.PerformLayout();
            panel_name.ResumeLayout(false);
            panel_name.PerformLayout();
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Panel leftPanel;
        private Panel topPanel;
        private Panel mainPanel;
        private PictureBox pictureBox_school;
        private PictureBox pictureBox_home;
        private Label label_home;
        private Panel panel1;
        private Panel userPanel;
        private Label label_headertitle;
        private Label label_role;
        private PictureBox pictureBox_avatar;
        private Label label_name;
        private Panel panel_apptitle;
        private Panel panel_home;
        private Panel panel_logout;
        private PictureBox pictureBox_logout;
        private Label label_logout;
        private Panel panel_settings;
        private PictureBox pictureBox_settings;
        private Label label_settings;
        private Panel panel_student;
        private PictureBox pictureBox_studentlist;
        private Label label_studentlist;
        private Panel panel_account;
        private PictureBox pictureBox_account;
        private Label label_account;
        private Panel panel_program;
        private PictureBox pictureBox_program;
        private Label label_program;
        private Panel panel_subject;
        private PictureBox pictureBox_subject;
        private Label label_subject;
        private Panel panel_department;
        private PictureBox pictureBox_department;
        private Label label_department;
        private Panel panel_timetable;
        private PictureBox pictureBox_timetable;
        private Label label_timetable;
        private Panel panel_classlist;
        private PictureBox pictureBox_classlist;
        private Label label_classlist;
        private Panel panel_name;
        private Panel panel_header;
        private Panel panel_avatar;
        private GradientPanel boardPanel;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanelMenu;
        private Panel panelSpace;
    }
}