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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            panelBottom = new Panel();
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
            panelTop = new Panel();
            buttonDepartment = new Button();
            buttonMyStudent = new Button();
            panel10 = new Panel();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel9 = new Panel();
            label10 = new Label();
            textBox6 = new TextBox();
            panel8 = new Panel();
            comboBox2 = new ComboBox();
            label9 = new Label();
            textBoxSearch = new TextBox();
            button_search = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button_add = new Button();
            panel6 = new Panel();
            comboBox1 = new ComboBox();
            label7 = new Label();
            panel5 = new Panel();
            panel7 = new Panel();
            label8 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            panel4 = new Panel();
            label5 = new Label();
            textBox3 = new TextBox();
            panel3 = new Panel();
            label4 = new Label();
            textBox2 = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            textBoxDepartmentName = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelBottom.SuspendLayout();
            panelTop.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelBottom
            // 
            panelBottom.BackColor = SystemColors.ButtonFace;
            panelBottom.Controls.Add(listView1);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 478);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1280, 322);
            panelBottom.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(1280, 322);
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
            // panelTop
            // 
            panelTop.BackColor = Color.LightGray;
            panelTop.Controls.Add(buttonDepartment);
            panelTop.Controls.Add(buttonMyStudent);
            panelTop.Controls.Add(panel10);
            panelTop.Controls.Add(panel9);
            panelTop.Controls.Add(panel8);
            panelTop.Controls.Add(textBoxSearch);
            panelTop.Controls.Add(button_search);
            panelTop.Controls.Add(button3);
            panelTop.Controls.Add(button2);
            panelTop.Controls.Add(button1);
            panelTop.Controls.Add(button_add);
            panelTop.Controls.Add(panel6);
            panelTop.Controls.Add(panel5);
            panelTop.Controls.Add(panel4);
            panelTop.Controls.Add(panel3);
            panelTop.Controls.Add(panel2);
            panelTop.Controls.Add(panel1);
            panelTop.Controls.Add(label1);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1280, 472);
            panelTop.TabIndex = 1;
            // 
            // buttonDepartment
            // 
            buttonDepartment.BackColor = Color.DarkGreen;
            buttonDepartment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDepartment.ForeColor = SystemColors.ButtonFace;
            buttonDepartment.Location = new Point(623, 416);
            buttonDepartment.Name = "buttonDepartment";
            buttonDepartment.Size = new Size(234, 55);
            buttonDepartment.TabIndex = 1;
            buttonDepartment.Text = "Danh sách theo Khoa";
            buttonDepartment.UseVisualStyleBackColor = false;
            // 
            // buttonMyStudent
            // 
            buttonMyStudent.BackColor = Color.DarkOrange;
            buttonMyStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMyStudent.ForeColor = SystemColors.ButtonFace;
            buttonMyStudent.Location = new Point(383, 416);
            buttonMyStudent.Name = "buttonMyStudent";
            buttonMyStudent.Size = new Size(234, 55);
            buttonMyStudent.TabIndex = 2;
            buttonMyStudent.Text = "Danh sách theo lớp ";
            buttonMyStudent.UseVisualStyleBackColor = false;
            buttonMyStudent.Click += buttonMyStudent_Click;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel10.Controls.Add(label11);
            panel10.Controls.Add(dateTimePicker1);
            panel10.Location = new Point(863, 262);
            panel10.Name = "panel10";
            panel10.Size = new Size(390, 50);
            panel10.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(10, 16);
            label11.Name = "label11";
            label11.Size = new Size(119, 20);
            label11.TabIndex = 2;
            label11.Text = "EnrollmentDate";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(133, 11);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(243, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel9.Controls.Add(label10);
            panel9.Controls.Add(textBox6);
            panel9.Location = new Point(863, 194);
            panel9.Name = "panel9";
            panel9.Size = new Size(390, 50);
            panel9.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(10, 16);
            label10.Name = "label10";
            label10.Size = new Size(89, 20);
            label10.TabIndex = 2;
            label10.Text = "HomeTown";
            label10.Click += label10_Click;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(133, 9);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(243, 34);
            textBox6.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.Controls.Add(comboBox2);
            panel8.Controls.Add(label9);
            panel8.Location = new Point(863, 130);
            panel8.Name = "panel8";
            panel8.Size = new Size(390, 50);
            panel8.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(133, 6);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(243, 36);
            comboBox2.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(10, 15);
            label9.Name = "label9";
            label9.Size = new Size(127, 20);
            label9.TabIndex = 2;
            label9.Text = "TrainingProgram";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(196, 77);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(701, 38);
            textBoxSearch.TabIndex = 4;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = SystemColors.AppWorkspace;
            button_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = SystemColors.ButtonFace;
            button_search.Location = new Point(915, 75);
            button_search.Name = "button_search";
            button_search.Size = new Size(150, 40);
            button_search.TabIndex = 7;
            button_search.Text = "Tìm kiếm";
            button_search.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 192);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(874, 344);
            button3.Name = "button3";
            button3.Size = new Size(189, 40);
            button3.TabIndex = 17;
            button3.Text = "Xuất Excel";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 192);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(400, 344);
            button2.Name = "button2";
            button2.Size = new Size(189, 40);
            button2.TabIndex = 16;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(637, 344);
            button1.Name = "button1";
            button1.Size = new Size(189, 40);
            button1.TabIndex = 15;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = false;
            // 
            // button_add
            // 
            button_add.BackColor = Color.Lime;
            button_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = SystemColors.ButtonHighlight;
            button_add.Location = new Point(163, 344);
            button_add.Name = "button_add";
            button_add.Size = new Size(189, 40);
            button_add.TabIndex = 14;
            button_add.Text = "Thêm";
            button_add.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.Controls.Add(comboBox1);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(436, 262);
            panel6.Name = "panel6";
            panel6.Size = new Size(390, 50);
            panel6.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(133, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 36);
            comboBox1.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 15);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 2;
            label7.Text = "Gender";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(textBox4);
            panel5.Location = new Point(436, 194);
            panel5.Name = "panel5";
            panel5.Size = new Size(390, 50);
            panel5.TabIndex = 13;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.Controls.Add(label8);
            panel7.Controls.Add(textBox5);
            panel7.Location = new Point(8, 8);
            panel7.Name = "panel7";
            panel7.Size = new Size(0, 50);
            panel7.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 15);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 2;
            label8.Text = "Address";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(133, 8);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(433, 34);
            textBox5.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 15);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 2;
            label6.Text = "Address";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(133, 8);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(240, 34);
            textBox4.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(textBox3);
            panel4.Location = new Point(12, 194);
            panel4.Name = "panel4";
            panel4.Size = new Size(390, 50);
            panel4.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 16);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 2;
            label5.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(133, 9);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(240, 34);
            textBox3.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox2);
            panel3.Location = new Point(436, 130);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 50);
            panel3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 16);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 2;
            label4.Text = "Phone Number";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(133, 9);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 34);
            textBox2.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(12, 262);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 50);
            panel2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 20);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(133, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 34);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxDepartmentName);
            panel1.Location = new Point(12, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 50);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 16);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "Full Name";
            // 
            // textBoxDepartmentName
            // 
            textBoxDepartmentName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDepartmentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDepartmentName.Location = new Point(133, 9);
            textBoxDepartmentName.Name = "textBoxDepartmentName";
            textBoxDepartmentName.Size = new Size(240, 34);
            textBoxDepartmentName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(524, 17);
            label1.Name = "label1";
            label1.Size = new Size(186, 44);
            label1.TabIndex = 8;
            label1.Text = "STUDENT";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 800);
            Controls.Add(panelTop);
            Controls.Add(panelBottom);
            Name = "Student";
            Text = "Student";
            panelBottom.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBottom;
        private Panel panelTop;
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
        private PictureBox pictureBox1;
        private Label label1;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Button buttonDepartment;
        private Button buttonMyStudent;
        private Panel panel10;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private Panel panel9;
        private Label label10;
        private TextBox textBox6;
        private Panel panel8;
        private ComboBox comboBox2;
        private Label label9;
        private TextBox textBoxSearch;
        private Button button_search;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button_add;
        private Panel panel6;
        private ComboBox comboBox1;
        private Label label7;
        private Panel panel5;
        private Panel panel7;
        private Label label8;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Panel panel4;
        private Label label5;
        private TextBox textBox3;
        private Panel panel3;
        private Label label4;
        private TextBox textBox2;
        private Panel panel2;
        private Label label3;
        private TextBox textBox1;
        private Panel panel1;
        private Label label2;
        private TextBox textBoxDepartmentName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}