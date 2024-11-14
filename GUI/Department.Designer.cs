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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department));
            panelLeft = new Panel();
            pictureBox1 = new PictureBox();
            button_add = new Button();
            panel4 = new Panel();
            comboBox1 = new ComboBox();
            label5 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            textBoxEmail = new TextBox();
            panel2 = new Panel();
            comboBoxChooseHeadofDepartment = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            textBoxDepartmentName = new TextBox();
            label1 = new Label();
            panelRight = new Panel();
            button_delete = new Button();
            button_update = new Button();
            listViewDepartment = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            button_search = new Button();
            textBoxSearch = new TextBox();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelLeft.BackColor = Color.Silver;
            panelLeft.Controls.Add(pictureBox1);
            panelLeft.Controls.Add(button_add);
            panelLeft.Controls.Add(panel4);
            panelLeft.Controls.Add(panel3);
            panelLeft.Controls.Add(panel2);
            panelLeft.Controls.Add(panel1);
            panelLeft.Controls.Add(label1);
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(419, 800);
            panelLeft.TabIndex = 0;
            panelLeft.Click += pictureBox1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button_add
            // 
            button_add.BackColor = Color.Lime;
            button_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = SystemColors.ButtonHighlight;
            button_add.Location = new Point(111, 602);
            button_add.Name = "button_add";
            button_add.Size = new Size(187, 40);
            button_add.TabIndex = 5;
            button_add.Text = "Thêm";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(0, 477);
            panel4.Name = "panel4";
            panel4.Size = new Size(419, 60);
            panel4.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(153, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 36);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 19);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 2;
            label5.Text = "EstablishedYear";
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBoxEmail);
            panel3.Location = new Point(0, 379);
            panel3.Name = "panel3";
            panel3.Size = new Size(419, 60);
            panel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 22);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 2;
            label4.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(153, 15);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(246, 34);
            textBoxEmail.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(comboBoxChooseHeadofDepartment);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 286);
            panel2.Name = "panel2";
            panel2.Size = new Size(419, 60);
            panel2.TabIndex = 3;
            // 
            // comboBoxChooseHeadofDepartment
            // 
            comboBoxChooseHeadofDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxChooseHeadofDepartment.FormattingEnabled = true;
            comboBoxChooseHeadofDepartment.Location = new Point(153, 13);
            comboBoxChooseHeadofDepartment.Name = "comboBoxChooseHeadofDepartment";
            comboBoxChooseHeadofDepartment.Size = new Size(246, 36);
            comboBoxChooseHeadofDepartment.TabIndex = 4;
            comboBoxChooseHeadofDepartment.SelectedIndexChanged += comboBoxChooseHeadofDepartment_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 21);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 3;
            label3.Text = "Head of depa.....";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxDepartmentName);
            panel1.Location = new Point(0, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(419, 60);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 2;
            label2.Text = "Name department";
            // 
            // textBoxDepartmentName
            // 
            textBoxDepartmentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDepartmentName.Location = new Point(153, 13);
            textBoxDepartmentName.Name = "textBoxDepartmentName";
            textBoxDepartmentName.Size = new Size(246, 34);
            textBoxDepartmentName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(78, 103);
            label1.Name = "label1";
            label1.Size = new Size(262, 44);
            label1.TabIndex = 0;
            label1.Text = "DEPARTMENT";
            // 
            // panelRight
            // 
            panelRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRight.Controls.Add(button_delete);
            panelRight.Controls.Add(button_update);
            panelRight.Controls.Add(listViewDepartment);
            panelRight.Controls.Add(button_search);
            panelRight.Controls.Add(textBoxSearch);
            panelRight.Location = new Point(422, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(856, 800);
            panelRight.TabIndex = 1;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.Red;
            button_delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = SystemColors.ButtonHighlight;
            button_delete.Location = new Point(662, 722);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(167, 40);
            button_delete.TabIndex = 8;
            button_delete.Text = "Xóa";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.BackColor = Color.DarkTurquoise;
            button_update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_update.ForeColor = SystemColors.ButtonFace;
            button_update.Location = new Point(474, 722);
            button_update.Name = "button_update";
            button_update.Size = new Size(167, 40);
            button_update.TabIndex = 6;
            button_update.Text = "Sửa";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // listViewDepartment
            // 
            listViewDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewDepartment.CheckBoxes = true;
            listViewDepartment.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewDepartment.GridLines = true;
            listViewDepartment.Location = new Point(0, 130);
            listViewDepartment.Name = "listViewDepartment";
            listViewDepartment.Size = new Size(856, 545);
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
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = SystemColors.AppWorkspace;
            button_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = SystemColors.ButtonFace;
            button_search.Location = new Point(719, 34);
            button_search.Name = "button_search";
            button_search.Size = new Size(124, 40);
            button_search.TabIndex = 6;
            button_search.Text = "Tìm kiếm";
            button_search.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(50, 36);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(656, 38);
            textBoxSearch.TabIndex = 3;
            // 
            // Department
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 800);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Name = "Department";
            Text = "Department";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelRight;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private ComboBox comboBoxChooseHeadofDepartment;
        private Label label3;
        private Label label2;
        private TextBox textBoxDepartmentName;
        private Panel panel3;
        private Label label4;
        private TextBox textBoxEmail;
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
        private PictureBox pictureBox1;
    }
}