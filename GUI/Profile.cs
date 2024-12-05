using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Profile : Form
    {
        DepartmentBLL departmentBLL;
        TeacherBLL teacherBLL;
        public Profile()
        {
            InitializeComponent();
            departmentBLL = new DepartmentBLL();
            teacherBLL = new TeacherBLL();
            loadProfile();
        }

        public void loadProfile()
        {
            DepartmentDTO departmentDTO = departmentBLL.findByIdDepartment(SessionLogin.LoggedInTeacher.DepartmentID);
            textBox_department.Text = departmentDTO.DepartmentName;
            textBox_email.Text = SessionLogin.LoggedInTeacher.Email.ToString();
            comboBox_gender.Items.Clear();
            comboBox_gender.Items.Add("Nam");
            comboBox_gender.Items.Add("Nữ");
            comboBox_gender.SelectedIndex = SessionLogin.LoggedInTeacher.Gender == true ? 0 : 1;
            textBox_phone.Text = SessionLogin.LoggedInTeacher.PhoneNumber.ToString();
            textBox_profileName.Text = SessionLogin.LoggedInTeacher.FullName.ToString();

            int roleId = SessionLogin.LoggedInTeacher.RoleID; // Lấy RoleID từ thông tin đăng nhập
            switch (roleId)
            {
                case 1:
                    textBox_role.Text = "TEACHER";
                    break;
                case 2:
                    textBox_role.Text = "INTERN TEACHER";
                    break;
                case 3:
                    textBox_role.Text = "HEAD OF DEPARTMENT";
                    break;
                case 4:
                    textBox_role.Text = "PRINCIPAL";
                    break;
                default:
                    textBox_role.Text = "UNKNOWN";
                    break;
            }
            textBox_role.ReadOnly = true;
            textBox_department.ReadOnly = true;
        }


        private void button_update_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin đã chỉnh sửa từ các textbox
                string updatedEmail = textBox_email.Text.Trim();
                string updatedPhone = textBox_phone.Text.Trim();
                int selectedGenderIndex = comboBox_gender.SelectedIndex;
                string updatedFullName = textBox_profileName.Text.Trim();

                if (string.IsNullOrWhiteSpace(updatedFullName))
                {
                    MessageBox.Show("Tên không được để trống.");
                    return; 
                }

                if (string.IsNullOrWhiteSpace(updatedEmail) || !RegexData.IsValidEmail(updatedEmail))
                {
                    MessageBox.Show("Email không hợp lệ.");
                    return; 
                }

                if (string.IsNullOrWhiteSpace(updatedPhone) || !RegexData.IsValidPhoneNumber(updatedPhone))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ.");
                    return;  
                }

                // Tạo DTO chứa thông tin cập nhật
                TeacherDTO updatedTeacher = new TeacherDTO
                {
                    TeacherID = SessionLogin.LoggedInTeacher.TeacherID, // ID của giảng viên hiện tại
                    Email = updatedEmail,
                    PhoneNumber = updatedPhone,
                    Gender = selectedGenderIndex == 0 ? true : false,
                    FullName = updatedFullName,
                    DepartmentID = SessionLogin.LoggedInTeacher.DepartmentID,
                    RoleID = SessionLogin.LoggedInTeacher.RoleID
                };

                // Gọi phương thức cập nhật thông tin giáo viên
                if (teacherBLL.UpdateTeacher(updatedTeacher))
                {
                    MessageBox.Show("Thông tin đã được cập nhật thành công!");
                    SessionLogin.LoggedInTeacher = updatedTeacher;
                    loadProfile();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            new ChangePasswordDialog(SessionLogin.LoggedInTeacher.TeacherID).Show();
        }

        private bool IsValidEmail(string email)
        {
            var emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}
