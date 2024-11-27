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
            listView_class = new ListView();
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
            end_page = new Label();
            label9 = new Label();
            button_add = new Button();
            button_export = new Button();
            button_delete = new Button();
            button_edit = new Button();
            back_button = new Button();
            page_number = new TextBox();
            next_button = new Button();
            tablePanel_form = new TableLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            textBox_class_name = new TextBox();
            panel4 = new Panel();
            label5 = new Label();
            textBox_room = new TextBox();
            panel10 = new Panel();
            textBox_start_period = new TextBox();
            label11 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            textBox_day = new TextBox();
            panel3 = new Panel();
            comboBox_subject = new ComboBox();
            label4 = new Label();
            panel5 = new Panel();
            comboBox_teacher = new ComboBox();
            label6 = new Label();
            panel6 = new Panel();
            label7 = new Label();
            textBox_end_period = new TextBox();
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
            // listView_class
            // 
            listView_class.BackColor = Color.WhiteSmoke;
            listView_class.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView_class.Dock = DockStyle.Fill;
            listView_class.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView_class.GridLines = true;
            listView_class.Location = new Point(0, 0);
            listView_class.Name = "listView_class";
            listView_class.Size = new Size(1066, 355);
            listView_class.TabIndex = 0;
            listView_class.UseCompatibleStateImageBehavior = false;
            listView_class.View = View.Details;
            listView_class.SelectedIndexChanged += listView_class_SelectedIndexChanged;
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 355F));
            tableLayoutPanel1.Size = new Size(1066, 701);
            tableLayoutPanel1.TabIndex = 39;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 10;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.47412F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0735683F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.4822865F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4530163F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.50631142F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 49F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 78F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.Controls.Add(end_page, 8, 0);
            tableLayoutPanel2.Controls.Add(label9, 4, 0);
            tableLayoutPanel2.Controls.Add(button_add, 2, 0);
            tableLayoutPanel2.Controls.Add(button_export, 3, 0);
            tableLayoutPanel2.Controls.Add(button_delete, 1, 0);
            tableLayoutPanel2.Controls.Add(button_edit, 0, 0);
            tableLayoutPanel2.Controls.Add(back_button, 5, 0);
            tableLayoutPanel2.Controls.Add(page_number, 6, 0);
            tableLayoutPanel2.Controls.Add(next_button, 7, 0);
            tableLayoutPanel2.Location = new Point(0, 295);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1066, 49);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // end_page
            // 
            end_page.AutoSize = true;
            end_page.BackColor = Color.Gainsboro;
            end_page.Dock = DockStyle.Fill;
            end_page.Location = new Point(990, 0);
            end_page.Name = "end_page";
            end_page.Size = new Size(21, 49);
            end_page.TabIndex = 38;
            end_page.Text = "1";
            end_page.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gainsboro;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(788, 0);
            label9.Name = "label9";
            label9.Size = new Size(22, 49);
            label9.TabIndex = 39;
            label9.Text = "1";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_add
            // 
            button_add.BackColor = Color.FromArgb(83, 185, 174);
            button_add.Dock = DockStyle.Fill;
            button_add.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button_add.ForeColor = SystemColors.ButtonHighlight;
            button_add.Location = new Point(390, 3);
            button_add.Name = "button_add";
            button_add.Size = new Size(152, 43);
            button_add.TabIndex = 31;
            button_add.Text = "Thêm";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // button_export
            // 
            button_export.BackColor = Color.FromArgb(73, 69, 104);
            button_export.Dock = DockStyle.Left;
            button_export.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button_export.ForeColor = SystemColors.ButtonHighlight;
            button_export.Location = new Point(548, 3);
            button_export.Name = "button_export";
            button_export.Size = new Size(179, 43);
            button_export.TabIndex = 34;
            button_export.Text = "Xuất Excel";
            button_export.UseVisualStyleBackColor = false;
            button_export.Click += button_export_Click;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.FromArgb(255, 128, 128);
            button_delete.Dock = DockStyle.Fill;
            button_delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button_delete.ForeColor = SystemColors.ButtonHighlight;
            button_delete.Location = new Point(235, 3);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(149, 43);
            button_delete.TabIndex = 32;
            button_delete.Text = "Xóa";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_edit
            // 
            button_edit.BackColor = Color.FromArgb(53, 97, 158);
            button_edit.Dock = DockStyle.Right;
            button_edit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button_edit.ForeColor = SystemColors.ButtonHighlight;
            button_edit.Location = new Point(53, 3);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(176, 43);
            button_edit.TabIndex = 33;
            button_edit.Text = "Sửa";
            button_edit.UseVisualStyleBackColor = false;
            button_edit.Click += button_edit_Click;
            // 
            // back_button
            // 
            back_button.BackColor = Color.DarkGray;
            back_button.Dock = DockStyle.Fill;
            back_button.Location = new Point(816, 4);
            back_button.Margin = new Padding(3, 4, 3, 4);
            back_button.Name = "back_button";
            back_button.Size = new Size(43, 41);
            back_button.TabIndex = 35;
            back_button.Text = "<";
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // page_number
            // 
            page_number.BackColor = SystemColors.Info;
            page_number.Dock = DockStyle.Fill;
            page_number.Location = new Point(865, 4);
            page_number.Margin = new Padding(3, 4, 3, 4);
            page_number.Name = "page_number";
            page_number.Size = new Size(72, 27);
            page_number.TabIndex = 36;
            page_number.TabStop = false;
            page_number.TextAlign = HorizontalAlignment.Center;
            page_number.TextChanged += page_number_TextChanged;
            // 
            // next_button
            // 
            next_button.BackColor = Color.DarkGray;
            next_button.Dock = DockStyle.Fill;
            next_button.Location = new Point(943, 4);
            next_button.Margin = new Padding(3, 4, 3, 4);
            next_button.Name = "next_button";
            next_button.Size = new Size(41, 41);
            next_button.TabIndex = 37;
            next_button.Text = ">";
            next_button.UseVisualStyleBackColor = false;
            next_button.Click += next_button_Click;
            // 
            // tablePanel_form
            // 
            tablePanel_form.BackColor = Color.Transparent;
            tablePanel_form.ColumnCount = 3;
            tablePanel_form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.1407242F));
            tablePanel_form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.3837948F));
            tablePanel_form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tablePanel_form.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
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
            tablePanel_form.Size = new Size(1060, 169);
            tablePanel_form.TabIndex = 37;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_class_name);
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
            // textBox_class_name
            // 
            textBox_class_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_class_name.BorderStyle = BorderStyle.FixedSingle;
            textBox_class_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_class_name.Location = new Point(133, 9);
            textBox_class_name.Name = "textBox_class_name";
            textBox_class_name.Size = new Size(241, 34);
            textBox_class_name.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(textBox_room);
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
            // textBox_room
            // 
            textBox_room.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_room.BorderStyle = BorderStyle.FixedSingle;
            textBox_room.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_room.Location = new Point(133, 9);
            textBox_room.Name = "textBox_room";
            textBox_room.Size = new Size(241, 34);
            textBox_room.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel10.Controls.Add(textBox_start_period);
            panel10.Controls.Add(label11);
            panel10.Location = new Point(708, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(349, 43);
            panel10.TabIndex = 29;
            // 
            // textBox_start_period
            // 
            textBox_start_period.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_start_period.BorderStyle = BorderStyle.FixedSingle;
            textBox_start_period.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_start_period.Location = new Point(121, 9);
            textBox_start_period.Name = "textBox_start_period";
            textBox_start_period.Size = new Size(226, 34);
            textBox_start_period.TabIndex = 3;
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
            panel2.Controls.Add(textBox_day);
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
            // 
            // textBox_day
            // 
            textBox_day.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_day.BorderStyle = BorderStyle.FixedSingle;
            textBox_day.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_day.Location = new Point(133, 9);
            textBox_day.Name = "textBox_day";
            textBox_day.Size = new Size(241, 34);
            textBox_day.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(comboBox_subject);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(386, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 43);
            panel3.TabIndex = 26;
            // 
            // comboBox_subject
            // 
            comboBox_subject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_subject.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_subject.FormattingEnabled = true;
            comboBox_subject.Location = new Point(97, 9);
            comboBox_subject.Name = "comboBox_subject";
            comboBox_subject.Size = new Size(219, 28);
            comboBox_subject.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.5F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(10, 16);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 2;
            label4.Text = "Subject";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(comboBox_teacher);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(386, 59);
            panel5.Name = "panel5";
            panel5.Size = new Size(316, 43);
            panel5.TabIndex = 30;
            // 
            // comboBox_teacher
            // 
            comboBox_teacher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_teacher.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_teacher.FormattingEnabled = true;
            comboBox_teacher.Location = new Point(97, 9);
            comboBox_teacher.Name = "comboBox_teacher";
            comboBox_teacher.Size = new Size(219, 28);
            comboBox_teacher.TabIndex = 7;
            comboBox_teacher.SelectedIndexChanged += comboBox_teacher_SelectedIndexChanged;
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
            panel6.Controls.Add(textBox_end_period);
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
            // textBox_end_period
            // 
            textBox_end_period.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_end_period.BorderStyle = BorderStyle.FixedSingle;
            textBox_end_period.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_end_period.Location = new Point(121, 5);
            textBox_end_period.Name = "textBox_end_period";
            textBox_end_period.Size = new Size(226, 34);
            textBox_end_period.TabIndex = 2;
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
            panel_searchBar.MaximumSize = new Size(1200, 59);
            panel_searchBar.Name = "panel_searchBar";
            panel_searchBar.Padding = new Padding(0, 11, 0, 0);
            panel_searchBar.Size = new Size(509, 59);
            panel_searchBar.TabIndex = 25;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Dock = DockStyle.Fill;
            textBoxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(0, 11);
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
            panelBottom.Controls.Add(listView_class);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 346);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1066, 355);
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
            tableLayoutPanel2.PerformLayout();
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
        private ListView listView_class;
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
        private Button button_export;
        private Button button_edit;
        private Button button_delete;
        private Button button_add;
        private Panel panel6;
        private Label label7;
        private TextBox textBox_end_period;
        private Panel panel5;
        private Label label6;
        private Panel panel4;
        private Label label5;
        private TextBox textBox_room;
        private Panel panel3;
        private Label label4;
        private Panel panel2;
        private Label label3;
        private TextBox textBox_day;
        private Panel panel1;
        private Label label2;
        private TextBox textBox_class_name;
        private ComboBox comboBox_subject;
        private TextBox textBox_start_period;
        private ComboBox comboBox_teacher;
        private Panel panel_search;
        private Panel panel_searchBtn;
        private TableLayoutPanel tablePanel_form;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel_searchBar;
        private Button back_button;
        private TextBox page_number;
        private Button button1;
        private Label end_page;
        private Label label9;
        private Button next_button;
    }
}