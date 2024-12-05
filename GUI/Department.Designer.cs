namespace GUI
{
    partial class Department
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
            panelLeft = new Panel();
            panel_form = new Panel();
            label_panelTitle = new Label();
            button_add = new Button();
            panel4 = new Panel();
            comboBox1 = new ComboBox();
            label5 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            textBoxEmail = new TextBox();
            panel2 = new Panel();
            comboBoxChooseHeadofDepartment = new ComboBox();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            textBoxDepartmentName = new TextBox();
            panelRight = new Panel();
            panel_table = new Panel();
            listViewDepartment = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            panel_task = new Panel();
            panel_controlBtn = new Panel();
            button_clear = new Button();
            button_delete = new Button();
            button_update = new Button();
            panel_search = new Panel();
            panel_searchBar = new Panel();
            textBoxSearch = new TextBox();
            panel_searchBtn = new Panel();
            button_search = new Button();
            panelLeft.SuspendLayout();
            panel_form.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panelRight.SuspendLayout();
            panel_table.SuspendLayout();
            panel_task.SuspendLayout();
            panel_controlBtn.SuspendLayout();
            panel_search.SuspendLayout();
            panel_searchBar.SuspendLayout();
            panel_searchBtn.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(35, 48, 103);
            panelLeft.Controls.Add(panel_form);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(3, 3, 10, 3);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(359, 789);
            panelLeft.TabIndex = 0;
            // 
            // panel_form
            // 
            panel_form.BackColor = Color.Transparent;
            panel_form.Controls.Add(label_panelTitle);
            panel_form.Controls.Add(button_add);
            panel_form.Controls.Add(panel4);
            panel_form.Controls.Add(panel1);
            panel_form.Controls.Add(panel2);
            panel_form.Controls.Add(panel3);
            panel_form.Dock = DockStyle.Fill;
            panel_form.Location = new Point(0, 0);
            panel_form.Name = "panel_form";
            panel_form.Padding = new Padding(0, 149, 0, 0);
            panel_form.Size = new Size(359, 789);
            panel_form.TabIndex = 6;
            // 
            // label_panelTitle
            // 
            label_panelTitle.Anchor = AnchorStyles.Top;
            label_panelTitle.AutoSize = true;
            label_panelTitle.BackColor = Color.Transparent;
            label_panelTitle.Font = new Font("Cambria", 20F, FontStyle.Bold);
            label_panelTitle.ForeColor = Color.Azure;
            label_panelTitle.Location = new Point(27, 65);
            label_panelTitle.Name = "label_panelTitle";
            label_panelTitle.Size = new Size(297, 40);
            label_panelTitle.TabIndex = 0;
            label_panelTitle.Text = "THÔNG TIN KHOA";
            label_panelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_add
            // 
            button_add.BackColor = Color.LightSeaGreen;
            button_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = SystemColors.ButtonHighlight;
            button_add.Location = new Point(12, 406);
            button_add.Name = "button_add";
            button_add.Size = new Size(336, 40);
            button_add.TabIndex = 5;
            button_add.Text = "Thêm";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 329);
            panel4.Name = "panel4";
            panel4.Size = new Size(359, 60);
            panel4.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(161, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 36);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11F);
            label5.ForeColor = Color.Azure;
            label5.Location = new Point(3, 21);
            label5.Name = "label5";
            label5.Size = new Size(152, 22);
            label5.TabIndex = 2;
            label5.Text = "EstablishedYear";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxEmail);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 269);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 60);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F);
            label2.ForeColor = Color.Azure;
            label2.Location = new Point(3, 23);
            label2.Name = "label2";
            label2.Size = new Size(56, 22);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(75, 13);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(273, 34);
            textBoxEmail.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBoxChooseHeadofDepartment);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 209);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 60);
            panel2.TabIndex = 3;
            // 
            // comboBoxChooseHeadofDepartment
            // 
            comboBoxChooseHeadofDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxChooseHeadofDepartment.FormattingEnabled = true;
            comboBoxChooseHeadofDepartment.Location = new Point(130, 13);
            comboBoxChooseHeadofDepartment.Name = "comboBoxChooseHeadofDepartment";
            comboBoxChooseHeadofDepartment.Size = new Size(218, 36);
            comboBoxChooseHeadofDepartment.TabIndex = 4;
            comboBoxChooseHeadofDepartment.SelectedIndexChanged += comboBoxChooseHeadofDepartment_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11F);
            label3.ForeColor = Color.Azure;
            label3.Location = new Point(3, 23);
            label3.Name = "label3";
            label3.Size = new Size(130, 22);
            label3.TabIndex = 3;
            label3.Text = "Head of De...";
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBoxDepartmentName);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 149);
            panel3.Name = "panel3";
            panel3.Size = new Size(359, 60);
            panel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11F);
            label4.ForeColor = Color.Azure;
            label4.Location = new Point(3, 25);
            label4.Name = "label4";
            label4.Size = new Size(66, 22);
            label4.TabIndex = 2;
            label4.Text = "Name";
            // 
            // textBoxDepartmentName
            // 
            textBoxDepartmentName.BorderStyle = BorderStyle.FixedSingle;
            textBoxDepartmentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDepartmentName.Location = new Point(75, 15);
            textBoxDepartmentName.Name = "textBoxDepartmentName";
            textBoxDepartmentName.Size = new Size(273, 34);
            textBoxDepartmentName.TabIndex = 2;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(panel_table);
            panelRight.Controls.Add(panel_task);
            panelRight.Controls.Add(panel_search);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(359, 0);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(10, 0, 0, 0);
            panelRight.Size = new Size(740, 789);
            panelRight.TabIndex = 1;
            // 
            // panel_table
            // 
            panel_table.Controls.Add(listViewDepartment);
            panel_table.Dock = DockStyle.Fill;
            panel_table.Location = new Point(10, 80);
            panel_table.Name = "panel_table";
            panel_table.Size = new Size(730, 592);
            panel_table.TabIndex = 11;
            // 
            // listViewDepartment
            // 
            listViewDepartment.BackColor = Color.WhiteSmoke;
            listViewDepartment.BorderStyle = BorderStyle.FixedSingle;
            listViewDepartment.CheckBoxes = true;
            listViewDepartment.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewDepartment.Dock = DockStyle.Fill;
            listViewDepartment.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewDepartment.GridLines = true;
            listViewDepartment.Location = new Point(0, 0);
            listViewDepartment.Name = "listViewDepartment";
            listViewDepartment.Size = new Size(730, 592);
            listViewDepartment.TabIndex = 7;
            listViewDepartment.UseCompatibleStateImageBehavior = false;
            listViewDepartment.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên Khoa";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Trưởng Khoa";
            columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email";
            columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Năm Thành Lập";
            columnHeader5.Width = 120;
            // 
            // panel_task
            // 
            panel_task.BackColor = Color.Transparent;
            panel_task.Controls.Add(panel_controlBtn);
            panel_task.Dock = DockStyle.Bottom;
            panel_task.Location = new Point(10, 672);
            panel_task.Name = "panel_task";
            panel_task.Size = new Size(730, 117);
            panel_task.TabIndex = 10;
            // 
            // panel_controlBtn
            // 
            panel_controlBtn.Controls.Add(button_clear);
            panel_controlBtn.Controls.Add(button_delete);
            panel_controlBtn.Controls.Add(button_update);
            panel_controlBtn.Dock = DockStyle.Right;
            panel_controlBtn.Location = new Point(153, 0);
            panel_controlBtn.Name = "panel_controlBtn";
            panel_controlBtn.Size = new Size(577, 117);
            panel_controlBtn.TabIndex = 9;
            // 
            // button_clear
            // 
            button_clear.BackColor = Color.CadetBlue;
            button_clear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clear.ForeColor = SystemColors.ButtonHighlight;
            button_clear.Location = new Point(52, 33);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(167, 40);
            button_clear.TabIndex = 9;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.FromArgb(255, 128, 128);
            button_delete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = SystemColors.ButtonHighlight;
            button_delete.Location = new Point(398, 33);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(167, 40);
            button_delete.TabIndex = 8;
            button_delete.Text = "Xóa";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.BackColor = Color.FromArgb(35, 48, 103);
            button_update.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_update.ForeColor = SystemColors.ButtonHighlight;
            button_update.Location = new Point(225, 33);
            button_update.Name = "button_update";
            button_update.Size = new Size(167, 40);
            button_update.TabIndex = 6;
            button_update.Text = "Sửa";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // panel_search
            // 
            panel_search.BackColor = Color.Transparent;
            panel_search.Controls.Add(panel_searchBar);
            panel_search.Controls.Add(panel_searchBtn);
            panel_search.Dock = DockStyle.Top;
            panel_search.Location = new Point(10, 0);
            panel_search.Name = "panel_search";
            panel_search.Padding = new Padding(10, 20, 10, 0);
            panel_search.Size = new Size(730, 80);
            panel_search.TabIndex = 9;
            // 
            // panel_searchBar
            // 
            panel_searchBar.Controls.Add(textBoxSearch);
            panel_searchBar.Dock = DockStyle.Fill;
            panel_searchBar.Location = new Point(10, 20);
            panel_searchBar.Name = "panel_searchBar";
            panel_searchBar.Size = new Size(555, 60);
            panel_searchBar.TabIndex = 5;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Dock = DockStyle.Fill;
            textBoxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(0, 0);
            textBoxSearch.MaximumSize = new Size(1200, 38);
            textBoxSearch.MinimumSize = new Size(535, 38);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.ShortcutsEnabled = false;
            textBoxSearch.Size = new Size(555, 38);
            textBoxSearch.TabIndex = 3;
            // 
            // panel_searchBtn
            // 
            panel_searchBtn.Controls.Add(button_search);
            panel_searchBtn.Dock = DockStyle.Right;
            panel_searchBtn.Location = new Point(565, 20);
            panel_searchBtn.Margin = new Padding(3, 5, 3, 3);
            panel_searchBtn.Name = "panel_searchBtn";
            panel_searchBtn.Size = new Size(155, 60);
            panel_searchBtn.TabIndex = 7;
            // 
            // button_search
            // 
            button_search.BackColor = Color.FromArgb(101, 116, 137);
            button_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = SystemColors.ButtonFace;
            button_search.Location = new Point(16, 0);
            button_search.Name = "button_search";
            button_search.Size = new Size(120, 37);
            button_search.TabIndex = 6;
            button_search.Text = "Tìm kiếm";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // Department
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 789);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Department";
            Text = "Department";
            panelLeft.ResumeLayout(false);
            panel_form.ResumeLayout(false);
            panel_form.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelRight.ResumeLayout(false);
            panel_table.ResumeLayout(false);
            panel_task.ResumeLayout(false);
            panel_controlBtn.ResumeLayout(false);
            panel_search.ResumeLayout(false);
            panel_searchBar.ResumeLayout(false);
            panel_searchBar.PerformLayout();
            panel_searchBtn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelRight;
        private Panel panel1;
        private Panel panel2;
        private ComboBox comboBoxChooseHeadofDepartment;
        private Label label3;
        private Label label2;
        private TextBox textBoxEmail;
        private Panel panel3;
        private Label label4;
        private TextBox textBoxDepartmentName;
        private Button button_add;
        private Panel panel4;
        private ComboBox comboBox1;
        private Label label5;
        private ListView listViewDepartment;
        private Button button_search;
        private TextBox textBoxSearch;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button_update;
        private Button button_delete;
        private Label label_panelTitle;
        private Panel panel_form;
        private Panel panel_search;
        private Panel panel_task;
        private Panel panel_table;
        private Panel panel_controlBtn;
        private Panel panel_searchBtn;
        private Panel panel_searchBar;
        private Button button_clear;
    }
}