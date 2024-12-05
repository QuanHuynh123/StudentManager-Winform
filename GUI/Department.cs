using BLL;
using DAL;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DTO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Department : Form
    {
        private DepartmentBLL departmentBLL;
        private TeacherBLL teacherBLL;
        private List<TeacherDTO> teachers;
        private List<TeacherDTO> teacherList;
        int selectedTeacherID;

        public Department()
        {
            InitializeComponent();
            departmentBLL = new DepartmentBLL();
            teacherBLL = new TeacherBLL();
            teacherList = teacherBLL.GetAllTeachers();
            LoadListDepartment();
            LoadTeachersForHeadOfDepartment();
            PopulateYearComboBox();
            listViewDepartment.SelectedIndexChanged += listViewDepartment_SelectedIndexChanged;
        }

        // GetTeacherForHeadOfDepartment gets teacher that isn't head (role=1)
        // check null list, populate fullname
        void LoadTeachersForHeadOfDepartment()
        {
            comboBoxChooseHeadofDepartment.Items.Clear();
            teachers = teacherBLL.GetTeacherForHeadOfDepartment();
            if (teachers != null && teachers.Count > 0)
            {
                foreach (var teacher in teachers)
                {
                    comboBoxChooseHeadofDepartment.Items.Add(teacher.FullName);
                }
            }
            else
            {
                MessageBox.Show("Không có giáo viên nào để làm trưởng khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        // clear listview, fullrowselect
        // get department list, with each item in list create listviewitem with corresponding subitems
        // check null head teacher, populate listview

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
                item.SubItems.Add(department.Teacher?.FullName ?? string.Empty);
                item.SubItems.Add(department.Email);
                item.SubItems.Add(department.EstablishedYear.ToString());
                // Thêm item vào ListView
                listViewDepartment.Items.Add(item);
            }
        }
       
        // populate up to 10 years later 
        void PopulateYearComboBox()
        {
            int currentYear = DateTime.Now.Year;
            for (int year = currentYear; year <= currentYear + 10; year++)
            {
                comboBox1.Items.Add(year);
            }
        }
        
        // Reset lại form
        void ClearForm()
        {
            button_add.Enabled = true;
            comboBoxChooseHeadofDepartment.Enabled = true;
            textBoxDepartmentName.Enabled = true;
            textBoxDepartmentName.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            LoadTeachersForHeadOfDepartment();
            PopulateYearComboBox();
            comboBoxChooseHeadofDepartment.ResetText();
            comboBox1.ResetText();
            textBoxSearch.Text = string.Empty;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                int selectedYear = (int)comboBox1.SelectedItem;
            }
        }

        // get selected combobox choice
        // check equals teacher fullname, save into selectedteacherID
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

        private bool CheckValidForm(string departmentName, string headOfDepartment, string email, int establishedYear)
        {
            if (string.IsNullOrEmpty(departmentName) || string.IsNullOrEmpty(headOfDepartment) || string.IsNullOrEmpty(email) || establishedYear == -1)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!departmentBLL.CheckValidEmail(email))
            {
                MessageBox.Show("Email phải có dạng <tên>@gmail.com (không có kí tự đặc biệt)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!departmentBLL.CheckValidName(departmentName))
            {
                MessageBox.Show("Không được trùng tên khoa cũ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        // get check valid form
        // populate new depa, check if success
        // change teacher role ChangeTeacherRoleToHeadOfDepartment, reload list clearform
        private void button_add_Click(object sender, EventArgs e)
        {
            string departmentName = textBoxDepartmentName?.Text;
            string headOfDepartment = comboBoxChooseHeadofDepartment.SelectedItem?.ToString();
            string email = textBoxEmail?.Text;
            int establishedYear = -1;
            if (comboBox1.SelectedItem != null) { establishedYear = Int32.Parse(comboBox1.SelectedItem.ToString()); }
            if (!CheckValidForm(departmentName, headOfDepartment, email, establishedYear)) return;
            int teacherID = 0;
            foreach (var teacher in teacherList)
            {
                if (string.Equals(headOfDepartment, teacher.FullName, StringComparison.OrdinalIgnoreCase))
                {
                    teacherID = teacher.TeacherID;
                    break;
                }
            }
            DepartmentDTO department = new DepartmentDTO
            {
                DepartmentName = departmentName,
                Email = email,
                EstablishedYear = establishedYear,
                TeacherID = teacherID,
                Teacher = new TeacherDTO
                {
                    TeacherID = teacherID,
                    FullName = headOfDepartment
                }
            };

            bool isAdded = departmentBLL.AddDepartment(department);
            if (isAdded)
            {
                teacherBLL.ChangeTeacherRoleToHeadOfDepartment(selectedTeacherID);
                MessageBox.Show("Department added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListDepartment(); // Reload the list of departments
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to add department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                button_add.Enabled = false;
                comboBoxChooseHeadofDepartment.Enabled = false;
                textBoxDepartmentName.Enabled = false;
            }
        }

        // check count if list selected
        // reload headlist, get listviewitem from form, check valid
        // populate new dto, check update success clear form reload list

        private void button_update_Click(object sender, EventArgs e)
        {
            if (listViewDepartment.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 khoa bất kỳ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ListViewItem selectedItem = listViewDepartment.SelectedItems[0];
            int departmentID = int.Parse(selectedItem.Text);
            string departmentName = textBoxDepartmentName.Text;
            string headOfDepartment = comboBoxChooseHeadofDepartment.Text;
            string email = textBoxEmail.Text;
            string establishedYearText = comboBox1.Text;
            int establishedYear = -1;
            if (comboBox1.SelectedItem != null) { establishedYear = Int32.Parse(comboBox1.SelectedItem.ToString()); }
            if (!departmentBLL.CheckValidEmail(email))
            {
                MessageBox.Show("Email phải có dạng <tên>@gmail.com (không có kí tự đặc biệt)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int teacherID = 0;
            foreach (var teacher in teacherList)
            {
                if (string.Equals(headOfDepartment, teacher.FullName, StringComparison.OrdinalIgnoreCase))
                {
                    teacherID = teacher.TeacherID;
                    break;
                }
            }
            DepartmentDTO department = new DepartmentDTO
            {
                DepartmentName = departmentName,
                Email = email,
                EstablishedYear = establishedYear,
                TeacherID = teacherID,
                Teacher = new TeacherDTO
                {
                    TeacherID = teacherID,
                    FullName = headOfDepartment
                },
                DepartmentID = departmentID
            };

            bool isUpdated = departmentBLL.UpdateDepartment(department);
            if (isUpdated)
            {
                MessageBox.Show("Cập nhật khoa thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListDepartment(); // Reload the list of departments
                ClearForm();
                LoadListDepartment();
            }
            else
            {
                MessageBox.Show("Cập nhật khoa thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // check count for checked rows, show confirm dialogresult as messagebox
        // if yes traverse teacherList for teacherName, listviewitem for each depaID to delete
        // update role, check success clear form reload list

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
                    int departmentID = Int32.Parse(item.Text); // Get the department ID from the selected item
                    string teacherName = item.SubItems[2].Text.ToString();
                    int teacherID;
                    foreach (var teacher in teacherList)
                    {
                        if (string.Equals(teacherName, teacher.FullName, StringComparison.OrdinalIgnoreCase))
                        {
                            teacherID = teacher.TeacherID; // Lưu ID của giáo viên đã chọn
                            teacherBLL.UpdateTeacherRole(teacherID, 1);
                            break;
                        }
                    }
                    
                    bool isDeleted = departmentBLL.DeleteDepartment(departmentID);
                    if (!isDeleted)
                    {
                        MessageBox.Show($"Xảy ra lỗi khi xóa ID: {departmentID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                MessageBox.Show("Xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                ClearForm();
                LoadListDepartment(); // Reload the list of departments
            }
        }

    
        // check null searchbar, clear listview
        // get search result list, populate listviewitem with result
        private void button_search_Click(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Vui lòng nhập từ khoá để tìm kiếm!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearForm();
                return;
            }
            
            listViewDepartment.Items.Clear();
            List<DepartmentDTO> searchResults = departmentBLL.SearchDepartments(searchQuery);
            foreach (var department in searchResults)
            {
                
                ListViewItem item = new ListViewItem(department.DepartmentID.ToString());
                item.SubItems.Add(department.DepartmentName);
                item.SubItems.Add(department.Teacher?.FullName ?? string.Empty);
                item.SubItems.Add(department.Email);
                item.SubItems.Add(department.EstablishedYear.ToString());
                listViewDepartment.Items.Add(item);
            }
        }
     
        private void button_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadListDepartment();
        }
     
    }
    
}
