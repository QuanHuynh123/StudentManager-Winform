namespace GUI
{
    partial class Subject
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel_search = new Panel();
            listViewSubject = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel_control = new Panel();
            button_delete = new Button();
            button_update = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            comboBox_credit = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label_programName = new Label();
            textBox_subjectName = new TextBox();
            panel4 = new Panel();
            comboBox_department = new ComboBox();
            label4 = new Label();
            panel3 = new Panel();
            comboBox_program = new ComboBox();
            label3 = new Label();
            button_add = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            listView_student = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            label5 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel_transcript = new Panel();
            label6 = new Label();
            panel_window = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel_control.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel_window.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.7711067F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.22889F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1133, 731);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel_search, 0, 0);
            tableLayoutPanel3.Controls.Add(listViewSubject, 0, 1);
            tableLayoutPanel3.Controls.Add(panel_control, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(385, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 85.471405F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5285931F));
            tableLayoutPanel3.Size = new Size(745, 725);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel_search
            // 
            panel_search.Dock = DockStyle.Fill;
            panel_search.Location = new Point(3, 3);
            panel_search.Name = "panel_search";
            panel_search.Size = new Size(739, 74);
            panel_search.TabIndex = 0;
            // 
            // listViewSubject
            // 
            listViewSubject.BackColor = Color.WhiteSmoke;
            listViewSubject.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewSubject.Dock = DockStyle.Fill;
            listViewSubject.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewSubject.GridLines = true;
            listViewSubject.Location = new Point(3, 83);
            listViewSubject.Name = "listViewSubject";
            listViewSubject.Size = new Size(739, 545);
            listViewSubject.TabIndex = 1;
            listViewSubject.UseCompatibleStateImageBehavior = false;
            listViewSubject.View = View.Details;
            listViewSubject.SelectedIndexChanged += listViewSubject_SelectedIndexChanged;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "ID";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên môn học";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số chỉ";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Chương trình đào tạo";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Khoa";
            columnHeader4.Width = 150;
            // 
            // panel_control
            // 
            panel_control.Controls.Add(button_delete);
            panel_control.Controls.Add(button_update);
            panel_control.Dock = DockStyle.Right;
            panel_control.Location = new Point(319, 634);
            panel_control.Name = "panel_control";
            panel_control.Size = new Size(423, 88);
            panel_control.TabIndex = 2;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button_delete.BackColor = Color.Red;
            button_delete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = SystemColors.ButtonHighlight;
            button_delete.Location = new Point(250, 26);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(142, 40);
            button_delete.TabIndex = 9;
            button_delete.Text = "Xóa";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button_update.BackColor = Color.FromArgb(0, 0, 192);
            button_update.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_update.ForeColor = SystemColors.ButtonHighlight;
            button_update.Location = new Point(77, 26);
            button_update.Name = "button_update";
            button_update.Size = new Size(145, 40);
            button_update.TabIndex = 7;
            button_update.Text = "Sửa";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(35, 48, 103);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 2);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 1);
            tableLayoutPanel2.Controls.Add(panel4, 0, 4);
            tableLayoutPanel2.Controls.Add(panel3, 0, 3);
            tableLayoutPanel2.Controls.Add(button_add, 0, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(376, 725);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox_credit);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 213);
            panel2.Margin = new Padding(3, 3, 3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 57);
            panel2.TabIndex = 2;
            // 
            // comboBox_credit
            // 
            comboBox_credit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_credit.FormattingEnabled = true;
            comboBox_credit.Location = new Point(98, 17);
            comboBox_credit.Name = "comboBox_credit";
            comboBox_credit.Size = new Size(261, 26);
            comboBox_credit.TabIndex = 2;
            comboBox_credit.SelectedIndexChanged += comboBox_credit_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 23);
            label2.Name = "label2";
            label2.Size = new Size(73, 22);
            label2.TabIndex = 1;
            label2.Text = "Credits";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(370, 150);
            label1.TabIndex = 1;
            label1.Text = "THÔNG TIN MÔN HỌC";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label_programName);
            panel1.Controls.Add(textBox_subjectName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 153);
            panel1.Margin = new Padding(3, 3, 3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 57);
            panel1.TabIndex = 0;
            // 
            // label_programName
            // 
            label_programName.AutoSize = true;
            label_programName.Font = new Font("Century Gothic", 11F);
            label_programName.ForeColor = SystemColors.ButtonHighlight;
            label_programName.Location = new Point(3, 22);
            label_programName.Name = "label_programName";
            label_programName.Size = new Size(66, 22);
            label_programName.TabIndex = 1;
            label_programName.Text = "Name";
            label_programName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_subjectName
            // 
            textBox_subjectName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_subjectName.BorderStyle = BorderStyle.FixedSingle;
            textBox_subjectName.Location = new Point(98, 17);
            textBox_subjectName.Name = "textBox_subjectName";
            textBox_subjectName.Size = new Size(261, 26);
            textBox_subjectName.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(comboBox_department);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 333);
            panel4.Margin = new Padding(3, 3, 3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(370, 57);
            panel4.TabIndex = 2;
            // 
            // comboBox_department
            // 
            comboBox_department.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_department.FormattingEnabled = true;
            comboBox_department.Location = new Point(132, 16);
            comboBox_department.Name = "comboBox_department";
            comboBox_department.Size = new Size(227, 26);
            comboBox_department.TabIndex = 3;
            comboBox_department.SelectedIndexChanged += comboBox_department_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(3, 22);
            label4.Name = "label4";
            label4.Size = new Size(123, 22);
            label4.TabIndex = 1;
            label4.Text = "Department";
            // 
            // panel3
            // 
            panel3.Controls.Add(comboBox_program);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 273);
            panel3.Margin = new Padding(3, 3, 3, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 57);
            panel3.TabIndex = 2;
            // 
            // comboBox_program
            // 
            comboBox_program.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_program.FormattingEnabled = true;
            comboBox_program.Location = new Point(98, 16);
            comboBox_program.Name = "comboBox_program";
            comboBox_program.Size = new Size(261, 26);
            comboBox_program.TabIndex = 2;
            comboBox_program.SelectedIndexChanged += comboBox_program_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 23);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 1;
            label3.Text = "Program";
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Top;
            button_add.BackColor = Color.FromArgb(0, 192, 0);
            button_add.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = SystemColors.ControlLightLight;
            button_add.Location = new Point(14, 410);
            button_add.Margin = new Padding(3, 20, 3, 3);
            button_add.Name = "button_add";
            button_add.Size = new Size(348, 37);
            button_add.TabIndex = 6;
            button_add.Text = "Thêm";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1147, 769);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1139, 737);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Subject";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel5);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1139, 737);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Class";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.87467F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.1253319F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1133, 731);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.FromArgb(35, 48, 103);
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(listView_student, 0, 1);
            tableLayoutPanel4.Controls.Add(label5, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5335159F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 89.4664841F));
            tableLayoutPanel4.Size = new Size(831, 725);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // listView_student
            // 
            listView_student.BackColor = Color.WhiteSmoke;
            listView_student.CheckBoxes = true;
            listView_student.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16 });
            listView_student.Dock = DockStyle.Fill;
            listView_student.Font = new Font("Verdana", 10F);
            listView_student.GridLines = true;
            listView_student.Location = new Point(3, 79);
            listView_student.Name = "listView_student";
            listView_student.Size = new Size(825, 643);
            listView_student.TabIndex = 1;
            listView_student.UseCompatibleStateImageBehavior = false;
            listView_student.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ID";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "FullName";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Age";
            columnHeader7.Width = 70;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Email";
            columnHeader9.Width = 160;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "PhoneNumber";
            columnHeader10.Width = 130;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Gender";
            columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Class";
            columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Program";
            columnHeader13.Width = 120;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "EnrollmentDate";
            columnHeader14.Width = 140;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "PermanentAddress";
            columnHeader15.Width = 150;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "HomeTown";
            columnHeader16.Width = 100;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 21);
            label5.Name = "label5";
            label5.Size = new Size(314, 34);
            label5.TabIndex = 2;
            label5.Text = "DANH SÁCH SINH VIÊN";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.FromArgb(35, 48, 103);
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(panel_transcript, 0, 1);
            tableLayoutPanel6.Controls.Add(label6, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(840, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4827585F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 89.51724F));
            tableLayoutPanel6.Size = new Size(290, 725);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // panel_transcript
            // 
            panel_transcript.BackColor = Color.FromArgb(35, 48, 103);
            panel_transcript.Dock = DockStyle.Fill;
            panel_transcript.Location = new Point(3, 79);
            panel_transcript.Name = "panel_transcript";
            panel_transcript.Size = new Size(284, 643);
            panel_transcript.TabIndex = 4;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 21);
            label6.Name = "label6";
            label6.Size = new Size(149, 34);
            label6.TabIndex = 3;
            label6.Text = "SỬA ĐIỂM";
            // 
            // panel_window
            // 
            panel_window.Controls.Add(tabControl1);
            panel_window.Dock = DockStyle.Fill;
            panel_window.Location = new Point(0, 0);
            panel_window.Name = "panel_window";
            panel_window.Size = new Size(1147, 769);
            panel_window.TabIndex = 3;
            // 
            // Subject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1147, 769);
            Controls.Add(panel_window);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Subject";
            Text = "Subject";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel_control.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            panel_window.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel_search;
        private ListView listViewSubject;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Panel panel_control;
        private Button button_delete;
        private Button button_update;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private ComboBox comboBox_credit;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label_programName;
        private TextBox textBox_subjectName;
        private Panel panel4;
        private ComboBox comboBox_department;
        private Label label4;
        private Panel panel3;
        private ComboBox comboBox_program;
        private Label label3;
        private Button button_add;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel_window;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel4;
        private ListView listView_student;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label6;
        private Panel panel_transcript;
    }
}