namespace GUI
{
    partial class Dashboard
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
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel_chart2 = new Panel();
            cartesianChart2 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label4 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel_chart1 = new Panel();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            dashboard3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            dashboard1 = new Panel();
            lblTotalStudent = new Label();
            lblCountStudent = new Label();
            dashboard2 = new Panel();
            lblTotalSubject = new Label();
            lblCountSubject = new Label();
            lblTotalClass = new Label();
            lblCountClass = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel_chart2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel_chart1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            dashboard3.SuspendLayout();
            dashboard1.SuspendLayout();
            dashboard2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.8791218F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.12088F));
            tableLayoutPanel1.Size = new Size(814, 410);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 87);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(808, 321);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(panel_chart2, 0, 0);
            tableLayoutPanel5.Controls.Add(label4, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(407, 2);
            tableLayoutPanel5.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Size = new Size(398, 317);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // panel_chart2
            // 
            panel_chart2.Controls.Add(cartesianChart2);
            panel_chart2.Dock = DockStyle.Fill;
            panel_chart2.Location = new Point(9, 2);
            panel_chart2.Margin = new Padding(9, 2, 11, 2);
            panel_chart2.Name = "panel_chart2";
            panel_chart2.Padding = new Padding(18, 15, 18, 15);
            panel_chart2.Size = new Size(378, 249);
            panel_chart2.TabIndex = 4;
            // 
            // cartesianChart2
            // 
            cartesianChart2.Dock = DockStyle.Fill;
            cartesianChart2.Location = new Point(18, 15);
            cartesianChart2.Margin = new Padding(3, 2, 3, 2);
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(342, 219);
            cartesianChart2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(3, 255);
            label4.Margin = new Padding(3, 2, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(392, 62);
            label4.TabIndex = 1;
            label4.Text = "Thống kê thành thích học tập sv 2024";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(panel_chart1, 0, 0);
            tableLayoutPanel4.Controls.Add(label3, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 2);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(398, 317);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // panel_chart1
            // 
            panel_chart1.Controls.Add(cartesianChart1);
            panel_chart1.Dock = DockStyle.Fill;
            panel_chart1.Location = new Point(9, 2);
            panel_chart1.Margin = new Padding(9, 2, 11, 2);
            panel_chart1.Name = "panel_chart1";
            panel_chart1.Padding = new Padding(18, 15, 18, 15);
            panel_chart1.Size = new Size(378, 249);
            panel_chart1.TabIndex = 3;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Dock = DockStyle.Fill;
            cartesianChart1.Location = new Point(18, 15);
            cartesianChart1.Margin = new Padding(3, 2, 3, 2);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(342, 219);
            cartesianChart1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(3, 255);
            label3.Margin = new Padding(3, 2, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(392, 62);
            label3.TabIndex = 1;
            label3.Text = "Thống kê tỉ lệ sv nhập học các năm";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.Controls.Add(dashboard3, 2, 0);
            tableLayoutPanel3.Controls.Add(dashboard1, 0, 0);
            tableLayoutPanel3.Controls.Add(dashboard2, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 2);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(9, 8, 9, 8);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(808, 81);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // dashboard3
            // 
            dashboard3.BackColor = Color.DarkBlue;
            dashboard3.Controls.Add(label1);
            dashboard3.Controls.Add(label2);
            dashboard3.Dock = DockStyle.Fill;
            dashboard3.Location = new Point(546, 10);
            dashboard3.Margin = new Padding(11, 2, 11, 2);
            dashboard3.Name = "dashboard3";
            dashboard3.Size = new Size(242, 61);
            dashboard3.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 33);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 23;
            label1.Text = "Total class";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 2);
            label2.Name = "label2";
            label2.Size = new Size(28, 32);
            label2.TabIndex = 22;
            label2.Text = "3";
            // 
            // dashboard1
            // 
            dashboard1.BackColor = Color.Chocolate;
            dashboard1.Controls.Add(lblTotalStudent);
            dashboard1.Controls.Add(lblCountStudent);
            dashboard1.Dock = DockStyle.Fill;
            dashboard1.Location = new Point(20, 10);
            dashboard1.Margin = new Padding(11, 2, 11, 2);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(241, 61);
            dashboard1.TabIndex = 4;
            // 
            // lblTotalStudent
            // 
            lblTotalStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalStudent.AutoSize = true;
            lblTotalStudent.BackColor = Color.Transparent;
            lblTotalStudent.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStudent.ForeColor = Color.White;
            lblTotalStudent.Location = new Point(10, 31);
            lblTotalStudent.Name = "lblTotalStudent";
            lblTotalStudent.Size = new Size(101, 19);
            lblTotalStudent.TabIndex = 21;
            lblTotalStudent.Text = "Total students";
            // 
            // lblCountStudent
            // 
            lblCountStudent.AutoSize = true;
            lblCountStudent.BackColor = Color.Transparent;
            lblCountStudent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountStudent.ForeColor = Color.White;
            lblCountStudent.Location = new Point(10, 0);
            lblCountStudent.Name = "lblCountStudent";
            lblCountStudent.Size = new Size(28, 32);
            lblCountStudent.TabIndex = 20;
            lblCountStudent.Text = "3";
            // 
            // dashboard2
            // 
            dashboard2.BackColor = Color.DarkGreen;
            dashboard2.Controls.Add(lblTotalSubject);
            dashboard2.Controls.Add(lblCountSubject);
            dashboard2.Dock = DockStyle.Fill;
            dashboard2.Location = new Point(283, 10);
            dashboard2.Margin = new Padding(11, 2, 11, 2);
            dashboard2.Name = "dashboard2";
            dashboard2.Size = new Size(241, 61);
            dashboard2.TabIndex = 6;
            // 
            // lblTotalSubject
            // 
            lblTotalSubject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalSubject.AutoSize = true;
            lblTotalSubject.BackColor = Color.Transparent;
            lblTotalSubject.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSubject.ForeColor = Color.White;
            lblTotalSubject.Location = new Point(10, 31);
            lblTotalSubject.Name = "lblTotalSubject";
            lblTotalSubject.Size = new Size(99, 19);
            lblTotalSubject.TabIndex = 22;
            lblTotalSubject.Text = "Total subjects";
            // 
            // lblCountSubject
            // 
            lblCountSubject.AutoSize = true;
            lblCountSubject.BackColor = Color.Transparent;
            lblCountSubject.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountSubject.ForeColor = Color.White;
            lblCountSubject.Location = new Point(10, 0);
            lblCountSubject.Name = "lblCountSubject";
            lblCountSubject.Size = new Size(28, 32);
            lblCountSubject.TabIndex = 21;
            lblCountSubject.Text = "3";
            // 
            // lblTotalClass
            // 
            lblTotalClass.AutoSize = true;
            lblTotalClass.BackColor = Color.Transparent;
            lblTotalClass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalClass.ForeColor = Color.White;
            lblTotalClass.Location = new Point(17, 56);
            lblTotalClass.Name = "lblTotalClass";
            lblTotalClass.Size = new Size(90, 23);
            lblTotalClass.TabIndex = 23;
            lblTotalClass.Text = "Total class";
            // 
            // lblCountClass
            // 
            lblCountClass.AutoSize = true;
            lblCountClass.BackColor = Color.Transparent;
            lblCountClass.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountClass.ForeColor = Color.White;
            lblCountClass.Location = new Point(17, 13);
            lblCountClass.Name = "lblCountClass";
            lblCountClass.Size = new Size(35, 41);
            lblCountClass.TabIndex = 22;
            lblCountClass.Text = "3";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(814, 410);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dashboard";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel_chart2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel_chart1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            dashboard3.ResumeLayout(false);
            dashboard3.PerformLayout();
            dashboard1.ResumeLayout(false);
            dashboard1.PerformLayout();
            dashboard2.ResumeLayout(false);
            dashboard2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel dashboard1;
        private Label lblTotalStudent;
        private Label lblCountStudent;
        private Label lblTotalClass;
        private Label lblCountClass;
        private Panel dashboard2;
        private Label lblTotalSubject;
        private Label lblCountSubject;
        private Panel dashboard3;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private Panel panel_chart1;
        private Panel panel_chart2;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private TableLayoutPanel tableLayoutPanel5;
    }
}