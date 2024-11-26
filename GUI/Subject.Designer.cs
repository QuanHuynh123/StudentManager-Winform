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
            button_delete = new Button();
            label3 = new Label();
            button_add = new Button();
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
            panel_control = new Panel();
            button_update = new Button();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            comboBox_department = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label_programName = new Label();
            textBox_programName = new TextBox();
            panel4 = new Panel();
            comboBox2 = new ComboBox();
            tabPage2 = new TabPage();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel3.SuspendLayout();
            panel_search.SuspendLayout();
            panel_control.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
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
            button_add.BackColor = Color.FromArgb(0, 192, 0);
            button_add.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = SystemColors.ControlLightLight;
            button_add.Location = new Point(3, 410);
            button_add.Margin = new Padding(3, 20, 3, 3);
            button_add.Name = "button_add";
            button_add.Size = new Size(348, 37);
            button_add.TabIndex = 6;
            button_add.Text = "Thêm";
            button_add.UseVisualStyleBackColor = false;
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
            tableLayoutPanel3.Size = new Size(700, 695);
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
            button_search.Location = new Point(568, 18);
            button_search.MaximumSize = new Size(120, 38);
            button_search.MinimumSize = new Size(120, 38);
            button_search.Name = "button_search";
            button_search.Size = new Size(120, 38);
            button_search.TabIndex = 7;
            button_search.Text = "Tìm kiếm";
            button_search.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(19, 18);
            textBoxSearch.MaximumSize = new Size(1200, 38);
            textBoxSearch.MinimumSize = new Size(400, 38);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.ShortcutsEnabled = false;
            textBoxSearch.Size = new Size(526, 38);
            textBoxSearch.TabIndex = 4;
            // 
            // listViewTrainingProgram
            // 
            listViewTrainingProgram.BackColor = Color.WhiteSmoke;
            listViewTrainingProgram.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewTrainingProgram.Dock = DockStyle.Fill;
            listViewTrainingProgram.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewTrainingProgram.GridLines = true;
            listViewTrainingProgram.Location = new Point(3, 83);
            listViewTrainingProgram.Name = "listViewTrainingProgram";
            listViewTrainingProgram.Size = new Size(694, 519);
            listViewTrainingProgram.TabIndex = 1;
            listViewTrainingProgram.UseCompatibleStateImageBehavior = false;
            listViewTrainingProgram.View = View.Details;
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
            panel_control.Location = new Point(274, 608);
            panel_control.Name = "panel_control";
            panel_control.Size = new Size(423, 84);
            panel_control.TabIndex = 2;
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
            // 
            // panel3
            // 
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 273);
            panel3.Margin = new Padding(3, 3, 3, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(348, 57);
            panel3.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(98, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 28);
            comboBox1.TabIndex = 2;
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
            tableLayoutPanel1.Size = new Size(1066, 701);
            tableLayoutPanel1.TabIndex = 1;
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
            tableLayoutPanel2.Controls.Add(tabControl1, 0, 6);
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
            tableLayoutPanel2.Size = new Size(354, 695);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox_department);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 213);
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
            comboBox_department.Size = new Size(247, 28);
            comboBox_department.TabIndex = 2;
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
            label1.Size = new Size(348, 150);
            label1.TabIndex = 1;
            label1.Text = "THÔNG TIN MÔN HỌC";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label_programName);
            panel1.Controls.Add(textBox_programName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 153);
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
            label_programName.Location = new Point(3, 22);
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
            textBox_programName.Size = new Size(247, 27);
            textBox_programName.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 333);
            panel4.Margin = new Padding(3, 3, 3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(348, 57);
            panel4.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(132, 16);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(213, 28);
            comboBox2.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(340, 114);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 453);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(348, 147);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(340, 114);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Subject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 701);
            Controls.Add(tableLayoutPanel1);
            Name = "Subject";
            Text = "Subject";
            tableLayoutPanel3.ResumeLayout(false);
            panel_search.ResumeLayout(false);
            panel_search.PerformLayout();
            panel_control.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button_delete;
        private Label label3;
        private Button button_add;
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
        private Panel panel_control;
        private Button button_update;
        private Panel panel3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private ComboBox comboBox_department;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label_programName;
        private TextBox textBox_programName;
        private Panel panel4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}