namespace GUI
{
    partial class TrainingProgram
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
            tableLayoutPanel3 = new TableLayoutPanel();
            panel_search = new Panel();
            button_search = new Button();
            textBoxSearch = new TextBox();
            listViewTrainingProgram = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            panel_control = new Panel();
            button_delete = new Button();
            button_update = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel7 = new Panel();
            label7 = new Label();
            textBox_credit = new TextBox();
            panel2 = new Panel();
            comboBox_department = new ComboBox();
            label2 = new Label();
            panel6 = new Panel();
            comboBox_degree = new ComboBox();
            label6 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            textBox_endYear = new TextBox();
            panel1 = new Panel();
            label_programName = new Label();
            textBox_programName = new TextBox();
            panel4 = new Panel();
            label4 = new Label();
            textBox_startYear = new TextBox();
            panel3 = new Panel();
            label3 = new Label();
            textBox_duration = new TextBox();
            button_add = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3.SuspendLayout();
            panel_search.SuspendLayout();
            panel_control.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel_search, 0, 0);
            tableLayoutPanel3.Controls.Add(listViewTrainingProgram, 0, 1);
            tableLayoutPanel3.Controls.Add(panel_control, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(363, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 85.471405F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5285931F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(700, 735);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel_search
            // 
            panel_search.Controls.Add(button_search);
            panel_search.Controls.Add(textBoxSearch);
            panel_search.Dock = DockStyle.Fill;
            panel_search.Location = new Point(3, 3);
            panel_search.Name = "panel_search";
            panel_search.Size = new Size(694, 74);
            panel_search.TabIndex = 0;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.FromArgb(101, 116, 137);
            button_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = SystemColors.ButtonFace;
            button_search.Location = new Point(568, 19);
            button_search.MaximumSize = new Size(120, 37);
            button_search.MinimumSize = new Size(120, 37);
            button_search.Name = "button_search";
            button_search.Size = new Size(120, 37);
            button_search.TabIndex = 7;
            button_search.Text = "Tìm kiếm";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(19, 19);
            textBoxSearch.MaximumSize = new Size(1200, 38);
            textBoxSearch.MinimumSize = new Size(400, 38);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.ShortcutsEnabled = false;
            textBoxSearch.Size = new Size(534, 38);
            textBoxSearch.TabIndex = 4;
            // 
            // listViewTrainingProgram
            // 
            listViewTrainingProgram.BackColor = Color.WhiteSmoke;
            listViewTrainingProgram.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listViewTrainingProgram.Dock = DockStyle.Fill;
            listViewTrainingProgram.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewTrainingProgram.GridLines = true;
            listViewTrainingProgram.Location = new Point(3, 83);
            listViewTrainingProgram.Name = "listViewTrainingProgram";
            listViewTrainingProgram.Size = new Size(694, 553);
            listViewTrainingProgram.TabIndex = 1;
            listViewTrainingProgram.UseCompatibleStateImageBehavior = false;
            listViewTrainingProgram.View = View.Details;
            listViewTrainingProgram.SelectedIndexChanged += listViewTrainingProgram_SelectedIndexChanged;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "ID";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên chương trình đào tạo";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Khoa";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số năm";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Năm bắt đầu";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Năm kết thúc";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Bằng";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Số tín chỉ";
            columnHeader7.Width = 100;
            // 
            // panel_control
            // 
            panel_control.Controls.Add(button_delete);
            panel_control.Controls.Add(button_update);
            panel_control.Dock = DockStyle.Right;
            panel_control.Location = new Point(98, 642);
            panel_control.Name = "panel_control";
            panel_control.Size = new Size(599, 90);
            panel_control.TabIndex = 2;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_delete.BackColor = Color.FromArgb(255, 128, 128);
            button_delete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = SystemColors.ButtonHighlight;
            button_delete.Location = new Point(426, 27);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(167, 40);
            button_delete.TabIndex = 9;
            button_delete.Text = "Xóa";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Top;
            button_update.BackColor = Color.FromArgb(35, 48, 103);
            button_update.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_update.ForeColor = SystemColors.ButtonHighlight;
            button_update.Location = new Point(253, 27);
            button_update.Name = "button_update";
            button_update.Size = new Size(167, 40);
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
            tableLayoutPanel2.Controls.Add(panel7, 0, 7);
            tableLayoutPanel2.Controls.Add(panel2, 0, 2);
            tableLayoutPanel2.Controls.Add(panel6, 0, 6);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel5, 0, 5);
            tableLayoutPanel2.Controls.Add(panel1, 0, 1);
            tableLayoutPanel2.Controls.Add(panel4, 0, 4);
            tableLayoutPanel2.Controls.Add(panel3, 0, 3);
            tableLayoutPanel2.Controls.Add(button_add, 0, 8);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 149F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(354, 735);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(label7);
            panel7.Controls.Add(textBox_credit);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 512);
            panel7.Margin = new Padding(3, 3, 3, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(348, 57);
            panel7.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(3, 21);
            label7.Name = "label7";
            label7.Size = new Size(126, 22);
            label7.TabIndex = 1;
            label7.Text = "Credits Num.";
            // 
            // textBox_credit
            // 
            textBox_credit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_credit.BorderStyle = BorderStyle.FixedSingle;
            textBox_credit.Location = new Point(135, 17);
            textBox_credit.Name = "textBox_credit";
            textBox_credit.Size = new Size(205, 27);
            textBox_credit.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox_department);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 212);
            panel2.Margin = new Padding(3, 3, 3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 57);
            panel2.TabIndex = 2;
            // 
            // comboBox_department
            // 
            comboBox_department.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_department.FormattingEnabled = true;
            comboBox_department.Location = new Point(98, 17);
            comboBox_department.Name = "comboBox_department";
            comboBox_department.Size = new Size(241, 28);
            comboBox_department.TabIndex = 2;
            comboBox_department.SelectedIndexChanged += comboBox_department_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 23);
            label2.Name = "label2";
            label2.Size = new Size(80, 22);
            label2.TabIndex = 1;
            label2.Text = "Depart.";
            // 
            // panel6
            // 
            panel6.Controls.Add(comboBox_degree);
            panel6.Controls.Add(label6);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 452);
            panel6.Margin = new Padding(3, 3, 3, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(348, 57);
            panel6.TabIndex = 4;
            // 
            // comboBox_degree
            // 
            comboBox_degree.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_degree.FormattingEnabled = true;
            comboBox_degree.Location = new Point(98, 16);
            comboBox_degree.Name = "comboBox_degree";
            comboBox_degree.Size = new Size(241, 28);
            comboBox_degree.TabIndex = 2;
            comboBox_degree.SelectedIndexChanged += comboBox_degree_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(3, 21);
            label6.Name = "label6";
            label6.Size = new Size(79, 22);
            label6.TabIndex = 1;
            label6.Text = "Degree";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Cambria", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(348, 149);
            label1.TabIndex = 1;
            label1.Text = "THÔNG TIN KHOÁ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(textBox_endYear);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 392);
            panel5.Margin = new Padding(3, 3, 3, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(348, 57);
            panel5.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(3, 21);
            label5.Name = "label5";
            label5.Size = new Size(87, 22);
            label5.TabIndex = 1;
            label5.Text = "EndYear";
            // 
            // textBox_endYear
            // 
            textBox_endYear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_endYear.BorderStyle = BorderStyle.FixedSingle;
            textBox_endYear.Location = new Point(98, 17);
            textBox_endYear.Name = "textBox_endYear";
            textBox_endYear.Size = new Size(242, 27);
            textBox_endYear.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label_programName);
            panel1.Controls.Add(textBox_programName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 152);
            panel1.Margin = new Padding(3, 3, 3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 57);
            panel1.TabIndex = 0;
            // 
            // label_programName
            // 
            label_programName.AutoSize = true;
            label_programName.Font = new Font("Century Gothic", 11F);
            label_programName.ForeColor = SystemColors.ButtonHighlight;
            label_programName.Location = new Point(3, 21);
            label_programName.Name = "label_programName";
            label_programName.Size = new Size(66, 22);
            label_programName.TabIndex = 1;
            label_programName.Text = "Name";
            label_programName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_programName
            // 
            textBox_programName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_programName.BorderStyle = BorderStyle.FixedSingle;
            textBox_programName.Location = new Point(98, 17);
            textBox_programName.Name = "textBox_programName";
            textBox_programName.Size = new Size(242, 27);
            textBox_programName.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textBox_startYear);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 332);
            panel4.Margin = new Padding(3, 3, 3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(348, 57);
            panel4.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(3, 21);
            label4.Name = "label4";
            label4.Size = new Size(94, 22);
            label4.TabIndex = 1;
            label4.Text = "StartYear";
            // 
            // textBox_startYear
            // 
            textBox_startYear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_startYear.BorderStyle = BorderStyle.FixedSingle;
            textBox_startYear.Location = new Point(98, 17);
            textBox_startYear.Name = "textBox_startYear";
            textBox_startYear.Size = new Size(242, 27);
            textBox_startYear.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox_duration);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 272);
            panel3.Margin = new Padding(3, 3, 3, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(348, 57);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 23);
            label3.Name = "label3";
            label3.Size = new Size(89, 22);
            label3.TabIndex = 1;
            label3.Text = "Duration";
            // 
            // textBox_duration
            // 
            textBox_duration.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_duration.BorderStyle = BorderStyle.FixedSingle;
            textBox_duration.Location = new Point(98, 19);
            textBox_duration.Name = "textBox_duration";
            textBox_duration.Size = new Size(242, 27);
            textBox_duration.TabIndex = 0;
            // 
            // button_add
            // 
            button_add.BackColor = Color.FromArgb(0, 192, 0);
            button_add.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = SystemColors.ControlLightLight;
            button_add.Location = new Point(3, 589);
            button_add.Margin = new Padding(3, 20, 3, 3);
            button_add.Name = "button_add";
            button_add.Size = new Size(346, 40);
            button_add.TabIndex = 6;
            button_add.Text = "Thêm";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.7711067F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.22889F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1066, 741);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // TrainingProgram
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1066, 741);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TrainingProgram";
            Text = "TrainingProgram";
            tableLayoutPanel3.ResumeLayout(false);
            panel_search.ResumeLayout(false);
            panel_search.PerformLayout();
            panel_control.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox4;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel_search;
        private Button button_search;
        private TextBox textBoxSearch;
        private ListView listViewTrainingProgram;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Panel panel_control;
        private Button button_delete;
        private Button button_update;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel7;
        private Label label7;
        private TextBox textBox_credit;
        private Panel panel2;
        private ComboBox comboBox_department;
        private Label label2;
        private Panel panel6;
        private ComboBox comboBox_degree;
        private Label label6;
        private Label label1;
        private Panel panel5;
        private Label label5;
        private TextBox textBox_endYear;
        private Panel panel1;
        private Label label_programName;
        private TextBox textBox_programName;
        private Panel panel4;
        private Label label4;
        private TextBox textBox_startYear;
        private Panel panel3;
        private Label label3;
        private TextBox textBox_duration;
        private Button button_add;
        private TableLayoutPanel tableLayoutPanel1;
    }
}