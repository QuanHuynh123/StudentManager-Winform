namespace GUI
{
    partial class Student
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
            panelTop = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button_export = new Button();
            button_departmentList = new Button();
            button_edit = new Button();
            button_delete = new Button();
            button_classList = new Button();
            button_add = new Button();
            panel_search = new Panel();
            panel_searchBar = new Panel();
            textBox_search = new TextBox();
            panel_searchBtn = new Panel();
            button_search = new Button();
            panel_form = new TableLayoutPanel();
            panel3 = new Panel();
            label4 = new Label();
            textBox_phone = new TextBox();
            panel9 = new Panel();
            label10 = new Label();
            textBox_birthplace = new TextBox();
            panel8 = new Panel();
            comboBox_program = new ComboBox();
            label9 = new Label();
            panel10 = new Panel();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel6 = new Panel();
            comboBox_gender = new ComboBox();
            label7 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            textBox_email = new TextBox();
            panel1 = new Panel();
            label_fullName = new Label();
            textBox_name = new TextBox();
            panel5 = new Panel();
            textBox_address = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            textBox_age = new TextBox();
            panel_title = new Panel();
            label_panelTitle = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            panelBottom = new Panel();
            panelTop.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel_search.SuspendLayout();
            panel_searchBar.SuspendLayout();
            panel_searchBtn.SuspendLayout();
            panel_form.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel_title.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(tableLayoutPanel1);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1081, 361);
            panelTop.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(35, 48, 103);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(panel_search, 0, 1);
            tableLayoutPanel1.Controls.Add(panel_form, 0, 2);
            tableLayoutPanel1.Controls.Add(panel_title, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4044323F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.2825489F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42.1052628F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.8538017F));
            tableLayoutPanel1.Size = new Size(1081, 361);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.4883728F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.139534F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.279068F));
            tableLayoutPanel2.Controls.Add(button_export, 2, 1);
            tableLayoutPanel2.Controls.Add(button_departmentList, 1, 1);
            tableLayoutPanel2.Controls.Add(button_edit, 1, 0);
            tableLayoutPanel2.Controls.Add(button_delete, 2, 0);
            tableLayoutPanel2.Controls.Add(button_classList, 0, 1);
            tableLayoutPanel2.Controls.Add(button_add, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 270);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1081, 91);
            tableLayoutPanel2.TabIndex = 23;
            // 
            // button_export
            // 
            button_export.BackColor = Color.FromArgb(73, 69, 104);
            button_export.Dock = DockStyle.Left;
            button_export.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button_export.ForeColor = SystemColors.ButtonHighlight;
            button_export.Location = new Point(647, 48);
            button_export.Name = "button_export";
            button_export.Size = new Size(203, 40);
            button_export.TabIndex = 17;
            button_export.Text = "Xuất Excel";
            button_export.UseVisualStyleBackColor = false;
            // 
            // button_departmentList
            // 
            button_departmentList.BackColor = Color.FromArgb(83, 185, 174);
            button_departmentList.Dock = DockStyle.Fill;
            button_departmentList.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button_departmentList.ForeColor = SystemColors.ButtonFace;
            button_departmentList.Location = new Point(451, 48);
            button_departmentList.Name = "button_departmentList";
            button_departmentList.Size = new Size(190, 40);
            button_departmentList.TabIndex = 1;
            button_departmentList.Text = "Danh sách theo Khoa";
            button_departmentList.UseVisualStyleBackColor = false;
            // 
            // button_edit
            // 
            button_edit.BackColor = Color.FromArgb(53, 97, 158);
            button_edit.Dock = DockStyle.Fill;
            button_edit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button_edit.ForeColor = SystemColors.ButtonHighlight;
            button_edit.Location = new Point(451, 3);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(190, 39);
            button_edit.TabIndex = 16;
            button_edit.Text = "Sửa";
            button_edit.UseVisualStyleBackColor = false;
            button_edit.Click += button2_Click;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.FromArgb(255, 128, 128);
            button_delete.Dock = DockStyle.Left;
            button_delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button_delete.ForeColor = SystemColors.ButtonHighlight;
            button_delete.Location = new Point(647, 3);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(203, 39);
            button_delete.TabIndex = 15;
            button_delete.Text = "Xóa";
            button_delete.UseVisualStyleBackColor = false;
            // 
            // button_classList
            // 
            button_classList.BackColor = Color.FromArgb(112, 169, 188);
            button_classList.Dock = DockStyle.Right;
            button_classList.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button_classList.ForeColor = SystemColors.ButtonFace;
            button_classList.Location = new Point(248, 48);
            button_classList.Name = "button_classList";
            button_classList.Size = new Size(197, 40);
            button_classList.TabIndex = 2;
            button_classList.Text = "Danh sách theo lớp ";
            button_classList.UseVisualStyleBackColor = false;
            button_classList.Click += buttonMyStudent_Click;
            // 
            // button_add
            // 
            button_add.BackColor = Color.FromArgb(70, 90, 100);
            button_add.Dock = DockStyle.Right;
            button_add.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button_add.ForeColor = SystemColors.ButtonHighlight;
            button_add.Location = new Point(248, 3);
            button_add.Name = "button_add";
            button_add.Size = new Size(197, 39);
            button_add.TabIndex = 14;
            button_add.Text = "Thêm";
            button_add.UseVisualStyleBackColor = false;
            // 
            // panel_search
            // 
            panel_search.BackColor = Color.Transparent;
            panel_search.Controls.Add(panel_searchBar);
            panel_search.Controls.Add(panel_searchBtn);
            panel_search.Dock = DockStyle.Fill;
            panel_search.ForeColor = SystemColors.ControlLight;
            panel_search.Location = new Point(3, 55);
            panel_search.Name = "panel_search";
            panel_search.Padding = new Padding(200, 0, 0, 0);
            panel_search.Size = new Size(1075, 60);
            panel_search.TabIndex = 18;
            panel_search.Paint += panel_search_Paint;
            // 
            // panel_searchBar
            // 
            panel_searchBar.Controls.Add(textBox_search);
            panel_searchBar.Dock = DockStyle.Fill;
            panel_searchBar.Location = new Point(200, 0);
            panel_searchBar.MaximumSize = new Size(1200, 43);
            panel_searchBar.Name = "panel_searchBar";
            panel_searchBar.Size = new Size(502, 43);
            panel_searchBar.TabIndex = 9;
            // 
            // textBox_search
            // 
            textBox_search.BorderStyle = BorderStyle.FixedSingle;
            textBox_search.Dock = DockStyle.Fill;
            textBox_search.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_search.Location = new Point(0, 0);
            textBox_search.MaximumSize = new Size(1200, 38);
            textBox_search.MinimumSize = new Size(496, 38);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(502, 38);
            textBox_search.TabIndex = 4;
            textBox_search.TextAlign = HorizontalAlignment.Center;
            // 
            // panel_searchBtn
            // 
            panel_searchBtn.Controls.Add(button_search);
            panel_searchBtn.Dock = DockStyle.Right;
            panel_searchBtn.Location = new Point(702, 0);
            panel_searchBtn.Name = "panel_searchBtn";
            panel_searchBtn.Size = new Size(373, 60);
            panel_searchBtn.TabIndex = 8;
            // 
            // button_search
            // 
            button_search.BackColor = Color.FromArgb(101, 116, 137);
            button_search.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button_search.ForeColor = SystemColors.ButtonHighlight;
            button_search.Location = new Point(24, -2);
            button_search.Name = "button_search";
            button_search.Size = new Size(150, 45);
            button_search.TabIndex = 7;
            button_search.Text = "Tìm kiếm";
            button_search.UseVisualStyleBackColor = false;
            // 
            // panel_form
            // 
            panel_form.BackColor = Color.Transparent;
            panel_form.ColumnCount = 3;
            panel_form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.8372078F));
            panel_form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.16279F));
            panel_form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            panel_form.Controls.Add(panel3, 2, 1);
            panel_form.Controls.Add(panel9, 0, 2);
            panel_form.Controls.Add(panel8, 1, 0);
            panel_form.Controls.Add(panel10, 2, 2);
            panel_form.Controls.Add(panel6, 1, 2);
            panel_form.Controls.Add(panel4, 0, 1);
            panel_form.Controls.Add(panel1, 0, 0);
            panel_form.Controls.Add(panel5, 2, 0);
            panel_form.Controls.Add(panel2, 1, 1);
            panel_form.Dock = DockStyle.Fill;
            panel_form.Location = new Point(3, 121);
            panel_form.Name = "panel_form";
            panel_form.RowCount = 3;
            panel_form.RowStyles.Add(new RowStyle(SizeType.Percent, 48.18182F));
            panel_form.RowStyles.Add(new RowStyle(SizeType.Percent, 51.81818F));
            panel_form.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            panel_form.Size = new Size(1075, 146);
            panel_form.TabIndex = 20;
            panel_form.Paint += panel_form_Paint;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox_phone);
            panel3.Location = new Point(648, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(424, 41);
            panel3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.5F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(9, 9);
            label4.Name = "label4";
            label4.Size = new Size(118, 21);
            label4.TabIndex = 2;
            label4.Text = "Phone Num.";
            // 
            // textBox_phone
            // 
            textBox_phone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_phone.BorderStyle = BorderStyle.FixedSingle;
            textBox_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_phone.Location = new Point(133, 4);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(288, 34);
            textBox_phone.TabIndex = 2;
            textBox_phone.TextChanged += textBox2_TextChanged;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel9.Controls.Add(label10);
            panel9.Controls.Add(textBox_birthplace);
            panel9.Location = new Point(3, 95);
            panel9.Name = "panel9";
            panel9.Size = new Size(347, 46);
            panel9.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10.5F);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(3, 12);
            label10.Name = "label10";
            label10.Size = new Size(97, 21);
            label10.TabIndex = 2;
            label10.Text = "Birthplace";
            label10.Click += label10_Click;
            // 
            // textBox_birthplace
            // 
            textBox_birthplace.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_birthplace.BorderStyle = BorderStyle.FixedSingle;
            textBox_birthplace.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_birthplace.Location = new Point(104, 8);
            textBox_birthplace.Name = "textBox_birthplace";
            textBox_birthplace.Size = new Size(240, 34);
            textBox_birthplace.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.Controls.Add(comboBox_program);
            panel8.Controls.Add(label9);
            panel8.Location = new Point(356, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(286, 38);
            panel8.TabIndex = 6;
            panel8.Paint += panel8_Paint;
            // 
            // comboBox_program
            // 
            comboBox_program.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_program.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_program.FormattingEnabled = true;
            comboBox_program.Location = new Point(161, 1);
            comboBox_program.Name = "comboBox_program";
            comboBox_program.Size = new Size(125, 36);
            comboBox_program.TabIndex = 5;
            comboBox_program.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.5F);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(10, 9);
            label9.Name = "label9";
            label9.Size = new Size(149, 21);
            label9.TabIndex = 2;
            label9.Text = "TrainingProgram";
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel10.Controls.Add(label11);
            panel10.Controls.Add(dateTimePicker1);
            panel10.Location = new Point(648, 95);
            panel10.Name = "panel10";
            panel10.Size = new Size(424, 46);
            panel10.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 10.5F);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(10, 16);
            label11.Name = "label11";
            label11.Size = new Size(145, 21);
            label11.TabIndex = 2;
            label11.Text = "EnrollmentDate";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(158, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(265, 27);
            dateTimePicker1.TabIndex = 18;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.Controls.Add(comboBox_gender);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(356, 95);
            panel6.Name = "panel6";
            panel6.Size = new Size(286, 46);
            panel6.TabIndex = 5;
            // 
            // comboBox_gender
            // 
            comboBox_gender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_gender.FormattingEnabled = true;
            comboBox_gender.Location = new Point(94, 7);
            comboBox_gender.Name = "comboBox_gender";
            comboBox_gender.Size = new Size(189, 36);
            comboBox_gender.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.5F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(10, 15);
            label7.Name = "label7";
            label7.Size = new Size(78, 21);
            label7.TabIndex = 2;
            label7.Text = "Gender";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(textBox_email);
            panel4.Location = new Point(3, 47);
            panel4.Name = "panel4";
            panel4.Size = new Size(347, 41);
            panel4.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.5F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 9);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 2;
            label5.Text = "Email";
            // 
            // textBox_email
            // 
            textBox_email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_email.BorderStyle = BorderStyle.FixedSingle;
            textBox_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_email.Location = new Point(104, 7);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(240, 34);
            textBox_email.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label_fullName);
            panel1.Controls.Add(textBox_name);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 38);
            panel1.TabIndex = 9;
            // 
            // label_fullName
            // 
            label_fullName.AutoSize = true;
            label_fullName.Font = new Font("Century Gothic", 10.5F);
            label_fullName.ForeColor = Color.White;
            label_fullName.Location = new Point(3, 9);
            label_fullName.Name = "label_fullName";
            label_fullName.Size = new Size(95, 21);
            label_fullName.TabIndex = 2;
            label_fullName.Text = "Full Name";
            // 
            // textBox_name
            // 
            textBox_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_name.BorderStyle = BorderStyle.FixedSingle;
            textBox_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_name.Location = new Point(104, 3);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(240, 34);
            textBox_name.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(textBox_address);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(648, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(424, 38);
            panel5.TabIndex = 13;
            // 
            // textBox_address
            // 
            textBox_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_address.BorderStyle = BorderStyle.FixedSingle;
            textBox_address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_address.Location = new Point(133, 3);
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(288, 34);
            textBox_address.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.5F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(10, 9);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 2;
            label6.Text = "Addr.";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox_age);
            panel2.Location = new Point(356, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 41);
            panel2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.5F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(10, 9);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // textBox_age
            // 
            textBox_age.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_age.BorderStyle = BorderStyle.FixedSingle;
            textBox_age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_age.Location = new Point(93, 7);
            textBox_age.Name = "textBox_age";
            textBox_age.Size = new Size(193, 34);
            textBox_age.TabIndex = 2;
            textBox_age.TextChanged += textBox1_TextChanged;
            // 
            // panel_title
            // 
            panel_title.BackColor = Color.Transparent;
            panel_title.Controls.Add(label_panelTitle);
            panel_title.Dock = DockStyle.Fill;
            panel_title.ForeColor = SystemColors.AppWorkspace;
            panel_title.Location = new Point(3, 3);
            panel_title.Name = "panel_title";
            panel_title.Size = new Size(1075, 46);
            panel_title.TabIndex = 21;
            panel_title.Paint += panel_panelTitle_Paint;
            // 
            // label_panelTitle
            // 
            label_panelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_panelTitle.AutoSize = true;
            label_panelTitle.BackColor = Color.Transparent;
            label_panelTitle.Font = new Font("Cambria", 20F, FontStyle.Bold);
            label_panelTitle.ForeColor = Color.White;
            label_panelTitle.Location = new Point(337, -4);
            label_panelTitle.Name = "label_panelTitle";
            label_panelTitle.Padding = new Padding(0, 10, 0, 0);
            label_panelTitle.Size = new Size(365, 50);
            label_panelTitle.TabIndex = 8;
            label_panelTitle.Text = "THÔNG TIN SINH VIÊN";
            label_panelTitle.TextAlign = ContentAlignment.MiddleCenter;
            label_panelTitle.Click += label1_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.WhiteSmoke;
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView1.Dock = DockStyle.Fill;
            listView1.Font = new Font("Verdana", 10F);
            listView1.GridLines = true;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(1081, 381);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "FullName";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Age";
            columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email";
            columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "PhoneNumber";
            columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Gender";
            columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Class";
            columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Program";
            columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "EnrollmentDate";
            columnHeader9.Width = 140;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "PermanentAddress";
            columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "HomeTown";
            columnHeader11.Width = 100;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = SystemColors.ButtonFace;
            panelBottom.Controls.Add(listView1);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 361);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1081, 381);
            panelBottom.TabIndex = 0;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 742);
            Controls.Add(panelTop);
            Controls.Add(panelBottom);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student";
            Text = "Student";
            panelTop.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel_search.ResumeLayout(false);
            panel_searchBar.ResumeLayout(false);
            panel_searchBar.PerformLayout();
            panel_searchBtn.ResumeLayout(false);
            panel_form.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel_title.ResumeLayout(false);
            panel_title.PerformLayout();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTop;
        private Label label_panelTitle;
        private Button button_departmentList;
        private Button button_classList;
        private Panel panel10;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private Panel panel9;
        private Label label10;
        private TextBox textBox_birthplace;
        private Panel panel8;
        private ComboBox comboBox_program;
        private Label label9;
        private TextBox textBox_search;
        private Button button_search;
        private Button button_export;
        private Button button_edit;
        private Button button_delete;
        private Button button_add;
        private Panel panel6;
        private ComboBox comboBox_gender;
        private Label label7;
        private Panel panel5;
        private Label label6;
        private TextBox textBox_address;
        private Panel panel4;
        private Label label5;
        private TextBox textBox_email;
        private Panel panel3;
        private Label label4;
        private TextBox textBox_phone;
        private Panel panel2;
        private Label label3;
        private TextBox textBox_age;
        private Panel panel1;
        private Label label_fullName;
        private TextBox textBox_name;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel_search;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel_searchBtn;
        private TableLayoutPanel panel_form;
        private Panel panel_title;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Panel panelBottom;
        private Panel panel_searchBar;
    }
}