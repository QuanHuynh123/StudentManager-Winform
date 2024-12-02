using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ChangePasswordDialog : Form
    {
        int teacherId;
        TeacherBLL teacherBLL;
        public ChangePasswordDialog( int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            teacherBLL = new TeacherBLL();
        }

        private void oldPassword_Enter(object sender, EventArgs e)
        {
                textBox_oldPassword.Text = "";
                textBox_oldPassword.PasswordChar = '*'; 
        }
        private void newPassword_Enter(object sender, EventArgs e)
        {
                textBox_newPassword.Text = "";
                textBox_newPassword.PasswordChar = '*'; 
        }

        private void confirmPassword_Enter(object sender, EventArgs e)
        {
                textBox_confirmPassword.Text = "";
                textBox_confirmPassword.PasswordChar = '*'; 
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            string oldPassword = textBox_oldPassword.Text;
            string newPassword = textBox_newPassword.Text;
            string confirmPassword = textBox_confirmPassword.Text;

            if (!teacherBLL.ValidateOldPassword(teacherId,oldPassword))
            {
                MessageBox.Show("Mật khẩu cũ không đúng. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không khớp. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isPasswordChanged = teacherBLL.ChangePassword(newPassword,teacherId);

            if (isPasswordChanged)
            {
                MessageBox.Show("Mật khẩu đã được thay đổi thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng Dialog khi đổi mật khẩu thành công
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi thay đổi mật khẩu. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
