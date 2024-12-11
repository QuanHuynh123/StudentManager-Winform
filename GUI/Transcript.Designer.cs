namespace GUI
{
    partial class Transcript
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transcript));
            panelContent = new Panel();
            tableLayoutPanelTranscript = new TableLayoutPanel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelHeader = new Panel();
            pictureBox2 = new PictureBox();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.AutoScroll = true;
            panelContent.BackColor = SystemColors.ControlLightLight;
            panelContent.Controls.Add(tableLayoutPanelTranscript);
            panelContent.Dock = DockStyle.Bottom;
            panelContent.Location = new Point(0, 74);
            panelContent.Margin = new Padding(3, 2, 3, 2);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1120, 526);
            panelContent.TabIndex = 4;
            // 
            // tableLayoutPanelTranscript
            // 
            tableLayoutPanelTranscript.AutoScroll = true;
            tableLayoutPanelTranscript.ColumnCount = 1;
            tableLayoutPanelTranscript.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1120F));
            tableLayoutPanelTranscript.Dock = DockStyle.Fill;
            tableLayoutPanelTranscript.Location = new Point(0, 0);
            tableLayoutPanelTranscript.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelTranscript.Name = "tableLayoutPanelTranscript";
            tableLayoutPanelTranscript.Size = new Size(1120, 526);
            tableLayoutPanelTranscript.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 7);
            label1.Name = "label1";
            label1.Size = new Size(117, 30);
            label1.TabIndex = 1;
            label1.Text = "Xem điểm";
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(pictureBox2);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(label1);
            panelHeader.Location = new Point(0, 1);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(340, 44);
            panelHeader.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, -2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Transcript
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 600);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Transcript";
            Text = "Transcript";
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panelHeader;
        private TableLayoutPanel tableLayoutPanelTranscript;
        private PictureBox pictureBox2;
    }
}