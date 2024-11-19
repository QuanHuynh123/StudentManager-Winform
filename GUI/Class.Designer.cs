namespace GUI
{
    partial class Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            pictureBox1 = new PictureBox();
            panelTop = new Panel();
            panel10 = new Panel();
            textBox2 = new TextBox();
            label11 = new Label();
            textBoxSearch = new TextBox();
            button_search = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button_add = new Button();
            panel6 = new Panel();
            label7 = new Label();
            textBox4 = new TextBox();
            panel5 = new Panel();
            comboBox2 = new ComboBox();
            label6 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            textBox3 = new TextBox();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            label4 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            textBoxDepartmentName = new TextBox();
            label1 = new Label();
            panelBottom = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTop.SuspendLayout();
            panel10.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(1280, 393);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Class Name";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Room";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Subject";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Teacher";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "StartPeriod";
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "EndPeriod";
            columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Day";
            columnHeader8.Width = 200;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.ScrollBar;
            panelTop.Controls.Add(panel10);
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
            panelTop.Size = new Size(1280, 407);
            panelTop.TabIndex = 9;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel10.Controls.Add(textBox2);
            panel10.Controls.Add(label11);
            panel10.Location = new Point(878, 129);
            panel10.Name = "panel10";
            panel10.Size = new Size(390, 50);
            panel10.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(133, 9);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 34);
            textBox2.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(10, 16);
            label11.Name = "label11";
            label11.Size = new Size(88, 20);
            label11.TabIndex = 2;
            label11.Text = "StartPeriod";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(208, 76);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(701, 38);
            textBoxSearch.TabIndex = 20;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = SystemColors.AppWorkspace;
            button_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = SystemColors.ButtonFace;
            button_search.Location = new Point(927, 74);
            button_search.Name = "button_search";
            button_search.Size = new Size(150, 40);
            button_search.TabIndex = 23;
            button_search.Text = "Tìm kiếm";
            button_search.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 192);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(886, 343);
            button3.Name = "button3";
            button3.Size = new Size(189, 40);
            button3.TabIndex = 34;
            button3.Text = "Xuất Excel";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 192);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(412, 343);
            button2.Name = "button2";
            button2.Size = new Size(189, 40);
            button2.TabIndex = 33;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(649, 343);
            button1.Name = "button1";
            button1.Size = new Size(189, 40);
            button1.TabIndex = 32;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = false;
            // 
            // button_add
            // 
            button_add.BackColor = Color.Lime;
            button_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = SystemColors.ButtonHighlight;
            button_add.Location = new Point(175, 343);
            button_add.Name = "button_add";
            button_add.Size = new Size(189, 40);
            button_add.TabIndex = 31;
            button_add.Text = "Thêm";
            button_add.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.Controls.Add(label7);
            panel6.Controls.Add(textBox4);
            panel6.Location = new Point(878, 193);
            panel6.Name = "panel6";
            panel6.Size = new Size(390, 50);
            panel6.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 15);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 2;
            label7.Text = "End Period";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(133, 6);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(243, 34);
            textBox4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(comboBox2);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(448, 193);
            panel5.Name = "panel5";
            panel5.Size = new Size(390, 50);
            panel5.TabIndex = 30;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(133, 7);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(240, 36);
            comboBox2.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 15);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 2;
            label6.Text = "Teacher";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(textBox3);
            panel4.Location = new Point(24, 193);
            panel4.Name = "panel4";
            panel4.Size = new Size(390, 50);
            panel4.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 16);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 2;
            label5.Text = "Room";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(133, 9);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 34);
            textBox3.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(448, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 50);
            panel3.TabIndex = 26;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(133, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 36);
            comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 16);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 2;
            label4.Text = "Subject";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(24, 261);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 50);
            panel2.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 16);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "Day";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(133, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 34);
            textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxDepartmentName);
            panel1.Location = new Point(24, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 50);
            panel1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 16);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 2;
            label2.Text = "Class Name";
            // 
            // textBoxDepartmentName
            // 
            textBoxDepartmentName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDepartmentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDepartmentName.Location = new Point(133, 9);
            textBoxDepartmentName.Name = "textBoxDepartmentName";
            textBoxDepartmentName.Size = new Size(242, 34);
            textBoxDepartmentName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(540, 17);
            label1.Name = "label1";
            label1.Size = new Size(131, 44);
            label1.TabIndex = 9;
            label1.Text = "CLASS";
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(listView1);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 407);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1280, 393);
            panelBottom.TabIndex = 10;
            // 
            // Class
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 800);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Name = "Class";
            Text = "Class";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Panel panelTop;
        private Panel panelBottom;
        private Label label1;
        private Panel panel10;
        private Label label11;
        private TextBox textBoxSearch;
        private Button button_search;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button_add;
        private Panel panel6;
        private Label label7;
        private TextBox textBox4;
        private Panel panel5;
        private Label label6;
        private Panel panel4;
        private Label label5;
        private TextBox textBox3;
        private Panel panel3;
        private Label label4;
        private Panel panel2;
        private Label label3;
        private TextBox textBox1;
        private Panel panel1;
        private Label label2;
        private TextBox textBoxDepartmentName;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private ComboBox comboBox2;
    }
}