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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            panelTop = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button_add = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            tablePanel_form = new TableLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            textBoxDepartmentName = new TextBox();
            panel4 = new Panel();
            label5 = new Label();
            textBox3 = new TextBox();
            panel10 = new Panel();
            textBox2 = new TextBox();
            label11 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            textBox1 = new TextBox();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            label4 = new Label();
            panel5 = new Panel();
            comboBox2 = new ComboBox();
            label6 = new Label();
            panel6 = new Panel();
            label7 = new Label();
            textBox4 = new TextBox();
            panel_search = new Panel();
            panel_searchBar = new Panel();
            textBoxSearch = new TextBox();
            panel_searchBtn = new Panel();
            button_search = new Button();
            label1 = new Label();
            panelBottom = new Panel();
            panelTop.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tablePanel_form.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel_search.SuspendLayout();
            panel_searchBar.SuspendLayout();
            panel_searchBtn.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = Color.WhiteSmoke;
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView1.Dock = DockStyle.Fill;
            listView1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.GridLines = true;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(1066, 354);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(tableLayoutPanel1);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1066, 701);
            panelTop.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(35, 48, 103);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(tablePanel_form, 0, 2);
            tableLayoutPanel1.Controls.Add(panel_search, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 0, 3, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.043478F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.608696F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.8507462F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.3283587F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 354F));
            tableLayoutPanel1.Size = new Size(1066, 701);
            tableLayoutPanel1.TabIndex = 39;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.9433975F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.8679247F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.1509438F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.037735F));
            tableLayoutPanel2.Controls.Add(button_add, 2, 0);
            tableLayoutPanel2.Controls.Add(button3, 3, 0);
            tableLayoutPanel2.Controls.Add(button1, 1, 0);
            tableLayoutPanel2.Controls.Add(button2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 296);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1066, 49);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // button_add
            // 
            button_add.BackColor = Color.FromArgb(83, 185, 174);
            button_add.Dock = DockStyle.Fill;
            button_add.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button_add.ForeColor = SystemColors.ButtonHighlight;
            button_add.Location = new Point(533, 3);
            button_add.Name = "button_add";
            button_add.Size = new Size(144, 43);
            button_add.TabIndex = 31;
            button_add.Text = "Thêm";
            button_add.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(73, 69, 104);
            button3.Dock = DockStyle.Left;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(683, 3);
            button3.Name = "button3";
            button3.Size = new Size(179, 43);
            button3.TabIndex = 34;
            button3.Text = "Xuất Excel";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(386, 3);
            button1.Name = "button1";
            button1.Size = new Size(141, 43);
            button1.TabIndex = 32;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(53, 97, 158);
            button2.Dock = DockStyle.Right;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(204, 3);
            button2.Name = "button2";
            button2.Size = new Size(176, 43);
            button2.TabIndex = 33;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            // 
            // tablePanel_form
            // 
            tablePanel_form.BackColor = Color.Transparent;
            tablePanel_form.ColumnCount = 3;
            tablePanel_form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.1407242F));
            tablePanel_form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.3837948F));
            tablePanel_form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tablePanel_form.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tablePanel_form.Controls.Add(panel1, 0, 0);
            tablePanel_form.Controls.Add(panel4, 0, 1);
            tablePanel_form.Controls.Add(panel10, 2, 0);
            tablePanel_form.Controls.Add(panel2, 0, 2);
            tablePanel_form.Controls.Add(panel3, 1, 0);
            tablePanel_form.Controls.Add(panel5, 1, 1);
            tablePanel_form.Controls.Add(panel6, 2, 1);
            tablePanel_form.Dock = DockStyle.Fill;
            tablePanel_form.Location = new Point(3, 126);
            tablePanel_form.Margin = new Padding(3, 3, 3, 0);
            tablePanel_form.Name = "tablePanel_form";
            tablePanel_form.RowCount = 3;
            tablePanel_form.RowStyles.Add(new RowStyle(SizeType.Percent, 33.1288338F));
            tablePanel_form.RowStyles.Add(new RowStyle(SizeType.Percent, 33.1288338F));
            tablePanel_form.RowStyles.Add(new RowStyle(SizeType.Percent, 33.1288338F));
            tablePanel_form.Size = new Size(1060, 170);
            tablePanel_form.TabIndex = 37;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxDepartmentName);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 43);
            panel1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.5F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(10, 16);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 2;
            label2.Text = "Class Name";
            // 
            // textBoxDepartmentName
            // 
            textBoxDepartmentName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDepartmentName.BorderStyle = BorderStyle.FixedSingle;
            textBoxDepartmentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDepartmentName.Location = new Point(133, 9);
            textBoxDepartmentName.Name = "textBoxDepartmentName";
            textBoxDepartmentName.Size = new Size(241, 34);
            textBoxDepartmentName.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(textBox3);
            panel4.Location = new Point(3, 59);
            panel4.Name = "panel4";
            panel4.Size = new Size(377, 43);
            panel4.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.5F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(10, 16);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 2;
            label5.Text = "Room";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(133, 9);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(241, 34);
            textBox3.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel10.Controls.Add(textBox2);
            panel10.Controls.Add(label11);
            panel10.Location = new Point(708, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(349, 43);
            panel10.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(121, 9);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 34);
            textBox2.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 10.5F);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(10, 16);
            label11.Name = "label11";
            label11.Size = new Size(105, 21);
            label11.TabIndex = 2;
            label11.Text = "StartPeriod";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(3, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 44);
            panel2.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.5F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(10, 16);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 2;
            label3.Text = "Day";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(133, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 34);
            textBox1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(386, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 43);
            panel3.TabIndex = 26;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(98, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 36);
            comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.5F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(16, 16);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 2;
            label4.Text = "Subject";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(comboBox2);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(386, 59);
            panel5.Name = "panel5";
            panel5.Size = new Size(316, 43);
            panel5.TabIndex = 30;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(98, 7);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(218, 36);
            comboBox2.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.5F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(10, 15);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 2;
            label6.Text = "Teacher";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.Controls.Add(label7);
            panel6.Controls.Add(textBox4);
            panel6.Location = new Point(708, 59);
            panel6.Name = "panel6";
            panel6.Size = new Size(349, 43);
            panel6.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.5F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(10, 15);
            label7.Name = "label7";
            label7.Size = new Size(98, 21);
            label7.TabIndex = 2;
            label7.Text = "EndPeriod";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(121, 6);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(225, 34);
            textBox4.TabIndex = 2;
            // 
            // panel_search
            // 
            panel_search.Controls.Add(panel_searchBar);
            panel_search.Controls.Add(panel_searchBtn);
            panel_search.Dock = DockStyle.Fill;
            panel_search.Location = new Point(3, 48);
            panel_search.Margin = new Padding(3, 3, 3, 0);
            panel_search.Name = "panel_search";
            panel_search.Padding = new Padding(200, 0, 0, 0);
            panel_search.Size = new Size(1060, 75);
            panel_search.TabIndex = 35;
            // 
            // panel_searchBar
            // 
            panel_searchBar.Controls.Add(textBoxSearch);
            panel_searchBar.Dock = DockStyle.Fill;
            panel_searchBar.Location = new Point(200, 0);
            panel_searchBar.MaximumSize = new Size(1200, 58);
            panel_searchBar.Name = "panel_searchBar";
            panel_searchBar.Padding = new Padding(0, 10, 0, 0);
            panel_searchBar.Size = new Size(509, 58);
            panel_searchBar.TabIndex = 25;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Dock = DockStyle.Fill;
            textBoxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(0, 10);
            textBoxSearch.MaximumSize = new Size(1200, 38);
            textBoxSearch.MinimumSize = new Size(487, 38);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(509, 38);
            textBoxSearch.TabIndex = 20;
            textBoxSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // panel_searchBtn
            // 
            panel_searchBtn.Controls.Add(button_search);
            panel_searchBtn.Dock = DockStyle.Right;
            panel_searchBtn.Location = new Point(709, 0);
            panel_searchBtn.Name = "panel_searchBtn";
            panel_searchBtn.Size = new Size(351, 75);
            panel_searchBtn.TabIndex = 24;
            // 
            // button_search
            // 
            button_search.BackColor = Color.FromArgb(101, 116, 137);
            button_search.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button_search.ForeColor = SystemColors.ButtonFace;
            button_search.Location = new Point(13, 8);
            button_search.Name = "button_search";
            button_search.Size = new Size(150, 41);
            button_search.TabIndex = 23;
            button_search.Text = "Tìm kiếm";
            button_search.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 22F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(385, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 8, 0, 0);
            label1.Size = new Size(295, 45);
            label1.TabIndex = 9;
            label1.Text = "THÔNG TIN LỚP";
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(listView1);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 347);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1066, 354);
            panelBottom.TabIndex = 10;
            // 
            // Class
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1066, 701);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Class";
            Text = "Class";
            panelTop.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tablePanel_form.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel_search.ResumeLayout(false);
            panel_searchBar.ResumeLayout(false);
            panel_searchBar.PerformLayout();
            panel_searchBtn.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
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
        private Panel panel_search;
        private Panel panel_searchBtn;
        private TableLayoutPanel tablePanel_form;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel_searchBar;
    }
}