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

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin đã chỉnh sửa từ các textbox
                string updatedEmail = textBox_email.Text.Trim();
                string updatedPhone = textBox_phone.Text.Trim();
                bool updatedGender = comboBox_gender.SelectedIndex == 0;
                string updatedFullName = textBox_profileName.Text.Trim();

                // Tạo DTO chứa thông tin cập nhật
                TeacherDTO updatedTeacher = new TeacherDTO
                {
                    TeacherID = SessionLogin.LoggedInTeacher.TeacherID, // ID của giảng viên hiện tại
                    Email = updatedEmail,
                    PhoneNumber = updatedPhone,
                    Gender = updatedGender ? false : true,
                    FullName = updatedFullName,
                    DepartmentID = SessionLogin.LoggedInTeacher.DepartmentID, // Giữ nguyên DepartmentID
                    RoleID = SessionLogin.LoggedInTeacher.RoleID              // Giữ nguyên RoleID
                };

                // Gọi phương thức cập nhật thông tin giáo viên
                if (teacherBLL.UpdateTeacher(updatedTeacher)) // Giả sử bạn có `teacherBLL.UpdateTeacher` đã được định nghĩa
                {
                    MessageBox.Show("Thông tin đã được cập nhật thành công!");
                    SessionLogin.LoggedInTeacher = updatedTeacher; // Cập nhật thông tin vào session
                    loadProfile(); // Load lại thông tin
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


    }
}
