using GUI.Properties;

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
            dashboard3 = new Panel();
            lblTotalClass = new Label();
            lblCountClass = new Label();
            dashboard2 = new Panel();
            lblTotalSubject = new Label();
            lblCountSubject = new Label();
            dashboard1 = new Panel();
            lblTotalStudent = new Label();
            lblCountStudent = new Label();
            panel1 = new Panel();
            panel_chart1 = new Panel();
            label1 = new Label();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            panel_chart2 = new Panel();
            label2 = new Label();
            cartesianChart2 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            panel2 = new Panel();
            dashboard3.SuspendLayout();
            dashboard2.SuspendLayout();
            dashboard1.SuspendLayout();
            panel1.SuspendLayout();
            panel_chart1.SuspendLayout();
            panel_chart2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dashboard3
            // 
            dashboard3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dashboard3.BackColor = Color.DarkBlue;
            dashboard3.Controls.Add(lblTotalClass);
            dashboard3.Controls.Add(lblCountClass);
            dashboard3.Location = new Point(698, 12);
            dashboard3.Name = "dashboard3";
            dashboard3.Size = new Size(250, 93);
            dashboard3.TabIndex = 5;
            // 
            // lblTotalClass
            // 
            lblTotalClass.AutoSize = true;
            lblTotalClass.BackColor = Color.Transparent;
            lblTotalClass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalClass.ForeColor = Color.White;
            lblTotalClass.Location = new Point(17, 56);
            lblTotalClass.Name = "lblTotalClass";
            lblTotalClass.Size = new Size(77, 19);
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
            lblCountClass.Size = new Size(28, 32);
            lblCountClass.TabIndex = 22;
            lblCountClass.Text = "3";
            // 
            // dashboard2
            // 
            dashboard2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dashboard2.BackColor = Color.DarkGreen;
            dashboard2.Controls.Add(lblTotalSubject);
            dashboard2.Controls.Add(lblCountSubject);
            dashboard2.Location = new Point(298, 12);
            dashboard2.Name = "dashboard2";
            dashboard2.Size = new Size(337, 93);
            dashboard2.TabIndex = 6;
            // 
            // lblTotalSubject
            // 
            lblTotalSubject.AutoSize = true;
            lblTotalSubject.BackColor = Color.Transparent;
            lblTotalSubject.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSubject.ForeColor = Color.White;
            lblTotalSubject.Location = new Point(12, 56);
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
            lblCountSubject.Location = new Point(12, 13);
            lblCountSubject.Name = "lblCountSubject";
            lblCountSubject.Size = new Size(28, 32);
            lblCountSubject.TabIndex = 21;
            lblCountSubject.Text = "3";
            // 
            // dashboard1
            // 
            dashboard1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dashboard1.BackColor = Color.Chocolate;
            dashboard1.Controls.Add(lblTotalStudent);
            dashboard1.Controls.Add(lblCountStudent);
            dashboard1.Location = new Point(0, 12);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(250, 93);
            dashboard1.TabIndex = 4;
            // 
            // lblTotalStudent
            // 
            lblTotalStudent.AutoSize = true;
            lblTotalStudent.BackColor = Color.Transparent;
            lblTotalStudent.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStudent.ForeColor = Color.White;
            lblTotalStudent.Location = new Point(11, 56);
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
            lblCountStudent.Location = new Point(11, 13);
            lblCountStudent.Name = "lblCountStudent";
            lblCountStudent.Size = new Size(28, 32);
            lblCountStudent.TabIndex = 20;
            lblCountStudent.Text = "3";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(panel_chart1);
            panel1.Controls.Add(panel_chart2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 457);
            panel1.TabIndex = 7;
            // 
            // panel_chart1
            // 
            panel_chart1.Controls.Add(label1);
            panel_chart1.Controls.Add(cartesianChart1);
            panel_chart1.Dock = DockStyle.Left;
            panel_chart1.Location = new Point(0, 0);
            panel_chart1.Name = "panel_chart1";
            panel_chart1.Size = new Size(466, 457);
            panel_chart1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(106, 358);
            label1.Name = "label1";
            label1.Size = new Size(276, 21);
            label1.TabIndex = 1;
            label1.Text = "Thống kê tỉ lệ sv nhập học các năm";
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(50, 21);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(372, 303);
            cartesianChart1.TabIndex = 0;
            // 
            // panel_chart2
            // 
            panel_chart2.Controls.Add(label2);
            panel_chart2.Controls.Add(cartesianChart2);
            panel_chart2.Dock = DockStyle.Right;
            panel_chart2.Location = new Point(472, 0);
            panel_chart2.Name = "panel_chart2";
            panel_chart2.Size = new Size(476, 457);
            panel_chart2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 358);
            label2.Name = "label2";
            label2.Size = new Size(294, 21);
            label2.TabIndex = 1;
            label2.Text = "Thống kê thành thích học tập sv 2024";
            // 
            // cartesianChart2
            // 
            cartesianChart2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cartesianChart2.Location = new Point(60, 21);
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(372, 303);
            cartesianChart2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dashboard1);
            panel2.Controls.Add(dashboard3);
            panel2.Controls.Add(dashboard2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(948, 130);
            panel2.TabIndex = 8;
            // 
            // Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(948, 593);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            dashboard3.ResumeLayout(false);
            dashboard3.PerformLayout();
            dashboard2.ResumeLayout(false);
            dashboard2.PerformLayout();
            dashboard1.ResumeLayout(false);
            dashboard1.PerformLayout();
            panel1.ResumeLayout(false);
            panel_chart1.ResumeLayout(false);
            panel_chart1.PerformLayout();
            panel_chart2.ResumeLayout(false);
            panel_chart2.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel dashboard3;
        private Label lblTotalClass;
        private Label lblCountClass;
        private Panel dashboard2;
        private Label lblTotalSubject;
        private Label lblCountSubject;
        private Panel dashboard1;
        private Label lblTotalStudent;
        private Label lblCountStudent;
        private Panel panel1;
        private Panel panel_chart2;
        private Panel panel_chart1;
        private Panel panel2;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart2;
        private Label label1;
        private Label label2;
    }
}