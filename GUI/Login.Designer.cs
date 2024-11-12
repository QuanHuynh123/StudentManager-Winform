
using System.Windows.Forms;

namespace GUI
{
    partial class Login
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
            overlay = new Panel();
            customPanel = new CustomPanel();
            tableLayoutPanel = new TableLayoutPanel();
            titleLogin = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            forgotPasswordLabel = new Label();
            loginButton = new Button();
            registerLabel = new Label();
            overlay.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            customPanel.SuspendLayout();
            SuspendLayout();
            SetBackgroundImage(this);

            // overlay
            overlay.BackColor = Color.FromArgb(100, 0, 0, 0);
            overlay.Controls.Add(customPanel);
            overlay.Dock = DockStyle.Fill;
            overlay.Location = new Point(0, 0);
            overlay.Name = "overlay";
            overlay.Size = new Size(1280, 800);
            overlay.TabIndex = 0;

            // customPanel
            customPanel.BackColor = Color.FromArgb(150, 135, 206, 235);
            customPanel.CornerRadius = 30;
            customPanel.Location = new Point(0, 0);
            customPanel.Name = "customPanel";
            customPanel.Size = new Size(550, 550);
            customPanel.TabIndex = 0;
            customPanel.Left = (overlay.Width - customPanel.Width) / 2;
            customPanel.Top = (overlay.Height - customPanel.Height) / 2;
            customPanel.Controls.Add(tableLayoutPanel);
            customPanel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            customPanel.Paint += CustomPanel_Paint;

            //tableLayoutPanel
            tableLayoutPanel.BackColor = Color.Transparent;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.Controls.Add(titleLogin, 0, 0);
            tableLayoutPanel.Controls.Add(usernameTextBox, 0, 1);
            tableLayoutPanel.Controls.Add(passwordTextBox, 0, 2);
            tableLayoutPanel.Controls.Add(forgotPasswordLabel, 0, 3);
            tableLayoutPanel.Controls.Add(loginButton, 0, 4);
            tableLayoutPanel.Controls.Add(registerLabel, 0, 5);
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.TabIndex = 0;

            //// titleLogin
            titleLogin.AutoSize = true;
            titleLogin.Font = new Font("Arial", 18F, FontStyle.Bold);
            titleLogin.ForeColor = Color.Black;
            titleLogin.Name = "titleLogin";
            titleLogin.TabIndex = 0;
            titleLogin.Text = "ĐĂNG NHẬP HỆ THỐNG";
            titleLogin.Anchor = AnchorStyles.None;
            titleLogin.Dock = DockStyle.Fill;
            titleLogin.TextAlign = ContentAlignment.MiddleCenter;

            //// usernameTextBox
            usernameTextBox.Anchor = AnchorStyles.None;
            usernameTextBox.Font = new Font("Arial", 10F);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(300, 27);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.Text = "Username";
            usernameTextBox.Enter += usernameTextBox_Enter;
            usernameTextBox.Leave += usernameTextBox_Leave;

            //// passwordTextBox
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.Font = new Font("Arial", 10F);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(300, 27);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.Text = "Password";
            passwordTextBox.Enter += passwordTextBox_Enter;
            passwordTextBox.Leave += passwordTextBox_Leave;

            //// forgotPasswordLabel
            forgotPasswordLabel.AutoSize = true;
            forgotPasswordLabel.Dock = DockStyle.Fill;
            forgotPasswordLabel.ForeColor = Color.White;
            forgotPasswordLabel.Location = new Point(3, 320);
            forgotPasswordLabel.Name = "forgotPasswordLabel";
            forgotPasswordLabel.Size = new Size(564, 64);
            forgotPasswordLabel.TabIndex = 3;
            forgotPasswordLabel.Text = "Quên mật khẩu";
            forgotPasswordLabel.TextAlign = ContentAlignment.MiddleCenter;

            //// loginButton
            loginButton.Anchor = AnchorStyles.None;
            loginButton.BackColor = Color.FromArgb(130, 0, 0, 255);
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            loginButton.ForeColor = Color.White;
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(250, 40);
            loginButton.TabIndex = 4;
            loginButton.Text = "ĐĂNG NHẬP";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;

            //// registerLabel
            registerLabel.AutoSize = true;
            registerLabel.Dock = DockStyle.Fill;
            registerLabel.Font = new Font("Arial", 10F, FontStyle.Bold);
            registerLabel.ForeColor = Color.Black;
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(564, 79);
            registerLabel.TabIndex = 5;
            registerLabel.Text = "Chưa có tài khoản? ĐĂNG KÝ";
            registerLabel.TextAlign = ContentAlignment.MiddleCenter;

            ClientSize = new Size(1280, 800);
            Controls.Add(overlay);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            overlay.ResumeLayout(false);
            overlay.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            customPanel.ResumeLayout(false);
            customPanel.PerformLayout();
            ResumeLayout(false);
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void SetBackgroundImage(Control control)
        {
            await Task.Run(() =>
            {
                string imagePath = System.IO.Path.Combine(Application.StartupPath, "Resources", "sgu.jpg");

                if (System.IO.File.Exists(imagePath))
                {
                    Image img = Image.FromFile(imagePath);
                    control.Invoke(new Action(() =>
                    {
                        control.BackgroundImage = img;
                        control.BackgroundImageLayout = ImageLayout.Stretch;
                    }));
                }
                else
                {
                    MessageBox.Show("Image not found! " + imagePath);
                }
            });
        }
        private void SetPlaceholder(TextBox usernameTextBox, string v)
        {
            throw new NotImplementedException();
        }

        #endregion
        private CustomPanel customPanel;
        private TableLayoutPanel tableLayoutPanel;
        private Panel overlay;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label titleLogin;
        private Label forgotPasswordLabel;
        private Label registerLabel;
    }
}