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
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.AutoScroll = true;
            panelContent.BackColor = SystemColors.ControlLightLight;
            panelContent.Controls.Add(tableLayoutPanelTranscript);
            panelContent.Dock = DockStyle.Bottom;
            panelContent.Location = new Point(0, 99);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1280, 701);
            panelContent.TabIndex = 4;
            // 
            // tableLayoutPanelTranscript
            // 
            tableLayoutPanelTranscript.ColumnCount = 1;
            tableLayoutPanelTranscript.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelTranscript.Dock = DockStyle.Fill;
            tableLayoutPanelTranscript.Location = new Point(0, 0);
            tableLayoutPanelTranscript.Name = "tableLayoutPanelTranscript";
            tableLayoutPanelTranscript.Size = new Size(1280, 701);
            tableLayoutPanelTranscript.TabIndex = 0;
            tableLayoutPanelTranscript.AutoScroll = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 8);
            label1.Name = "label1";
            label1.Size = new Size(151, 38);
            label1.TabIndex = 1;
            label1.Text = "Xem điểm";
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(label1);
            panelHeader.Location = new Point(2, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(400, 59);
            panelHeader.TabIndex = 3;
            // 
            // Transcript
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 800);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Name = "Transcript";
            Text = "Transcript";
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panelHeader;
        private TableLayoutPanel tableLayoutPanelTranscript;
    }
}