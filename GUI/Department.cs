using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;

namespace GUI
{
    public partial class Department : Form
    {
        private DepartmentBLL departmentBLL;
        private TeacherBLL teacherBLL;
        private List<TeacherDTO> teachers;
        int selectedTeacherID;
        public Department()
        {
            InitializeComponent();
            departmentBLL = new DepartmentBLL();
            teacherBLL = new TeacherBLL();
            LoadListDepartment();
            LoadTeachersForHeadOfDepartment();
            PopulateYearComboBox();
            listViewDepartment.SelectedIndexChanged += listViewDepartment_SelectedIndexChanged;
        }

        void LoadTeachersForHeadOfDepartment()
        {
            teachers = teacherBLL.GetTeacherForHeadOfDepartment();
            comboBoxChooseHeadofDepartment.Items.Clear(); // Xóa các mục cũ trước khi thêm mới
            foreach (var teacher in teachers)
            {
                comboBoxChooseHeadofDepartment.Items.Add(teacher.FullName);
            }
        }

        void LoadListDepartment()
        {
            listViewDepartment.Items.Clear();
            listViewDepartment.FullRowSelect = true;
            listViewDepartment.CheckBoxes = true;
            List<DepartmentDTO> departments = departmentBLL.GetAllDepartments();
            foreach (var department in departments)
            {
                // Tạo một item mới cho mỗi phòng ban
                ListViewItem item = new ListViewItem(department.DepartmentID.ToString());
                item.SubItems.Add(department.DepartmentName);
                item.SubItems.Add(department.HeadOfDepartment);
                item.SubItems.Add(department.Email);
                item.SubItems.Add(department.EstablishedYear.ToString());
                // Thêm item vào ListView
                listViewDepartment.Items.Add(item);
            }
        }

        void PopulateYearComboBox()
        {
            int currentYear = DateTime.Now.Year;
            for (int year = currentYear; year <= currentYear + 10; year++)
            {
                comboBox1.Items.Add(year);
            }
        }



        private void button_add_Click(object sender, EventArgs e)
        {
            string departmentName = textBoxDepartmentName.Text; // Assuming you have a TextBox for department name
            string headOfDepartment = comboBoxChooseHeadofDepartment.SelectedItem?.ToString(); // Get the selected teacher
            string email = textBoxEmail.Text; // Assuming you have a TextBox for email
            int establishedYear = (int)comboBox1.SelectedItem; // Get the selected year from the ComboBox

            if (string.IsNullOrEmpty(departmentName) || string.IsNullOrEmpty(headOfDepartment) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DepartmentDTO department = new DepartmentDTO
            {
                DepartmentName = departmentName,
                HeadOfDepartment = headOfDepartment,
                Email = email,
                EstablishedYear = establishedYear
            };

            bool isAdded = departmentBLL.AddDepartment(department);
            if (isAdded)
            {
                teacherBLL.ChangeTeacherRoleToHeadOfDepartment(selectedTeacherID);
                MessageBox.Show("Department added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListDepartment(); // Reload the list of departments
            }
            else
            {
                MessageBox.Show("Failed to add department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                int selectedYear = (int)comboBox1.SelectedItem;
            }
        }

        private void comboBoxChooseHeadofDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTeacherName = comboBoxChooseHeadofDepartment.SelectedItem.ToString();
            foreach (var teacher in teachers)
            {
                if (teacher.FullName == selectedTeacherName)
                {
                    selectedTeacherID = teacher.TeacherID; // Lưu ID của giáo viên đã chọn
                    break;
                }
            }
        }

        private void listViewDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn hay không
            if (listViewDepartment.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewDepartment.SelectedItems[0];

                // Gán dữ liệu từ các SubItems vào các trường input
                textBoxDepartmentName.Text = selectedItem.SubItems[1].Text;    // Tên khoa
                comboBoxChooseHeadofDepartment.Text = selectedItem.SubItems[2].Text; // Trưởng khoa
                textBoxEmail.Text = selectedItem.SubItems[3].Text;             // Email
                comboBox1.Text = selectedItem.SubItems[4].Text;
            }
        }


        private void button_update_Click(object sender, EventArgs e)
        {
            if (listViewDepartment.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 khoa bất kỳ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem selectedItem = listViewDepartment.SelectedItems[0];
            int departmentID = int.Parse(selectedItem.Text); // Get the selected department ID
            string departmentName = textBoxDepartmentName.Text; // Assuming you have a TextBox for department name
            string headOfDepartment = comboBoxChooseHeadofDepartment.Text; // Get the selected teacher
            string email = textBoxEmail.Text; // Assuming you have a TextBox for email
            string establishedYearText = comboBox1.Text;
            int establishedYear;
            int.TryParse(establishedYearText, out establishedYear);

            if (string.IsNullOrEmpty(departmentName) || string.IsNullOrEmpty(headOfDepartment) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DepartmentDTO department = new DepartmentDTO
            {
                DepartmentID = departmentID,
                DepartmentName = departmentName,
                HeadOfDepartment = headOfDepartment,
                Email = email,
                EstablishedYear = establishedYear
            };

            bool isUpdated = departmentBLL.UpdateDepartment(department);
            if (isUpdated)
            {
                MessageBox.Show("Cập nhật khoa thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListDepartment(); // Reload the list of departments
            }
            else
            {
                MessageBox.Show("Cập nhật khoa thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listViewDepartment.CheckedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn record bất kì trước khi xóa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không ?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem item in listViewDepartment.CheckedItems)
                {
                    int departmentID = int.Parse(item.Text); // Get the department ID from the selected item

                    bool isDeleted = departmentBLL.DeleteDepartment(departmentID);
                    if (!isDeleted)
                    {
                        MessageBox.Show($"Xảy ra lỗi khi xóa ID :  {departmentID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                MessageBox.Show("Xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListDepartment(); // Reload the list of departments
            }
        }

        private void panel_searchBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {

        }

        private void label_panelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
