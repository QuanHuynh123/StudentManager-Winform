using BLL;
using DAL;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
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
            addDataDefault();
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

        void addDataDefault()
        {
            List<DepartmentDTO> departments = departmentBLL.GetAllDepartments();
            LoadListDepartment(departments);
        }


        // clear listview, fullrowselect
        // get department list, with each item in list create listviewitem with corresponding subitems
        // check null head teacher, populate listview

        void LoadListDepartment(List<DepartmentDTO> departments)
        {
            listViewDepartment.Items.Clear();
            listViewDepartment.FullRowSelect = true;
            listViewDepartment.CheckBoxes = true;
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

        // get check null and valid form
        // populate new depa, check if success
        // change teacher role ChangeTeacherRoleToHeadOfDepartment, reload LoadListDepartment

        private void button_add_Click(object sender, EventArgs e)
        {
            string departmentName = textBoxDepartmentName.Text;
            string headOfDepartment = comboBoxChooseHeadofDepartment.SelectedItem?.ToString();
            string email = textBoxEmail.Text;
            int establishedYear = Int32.Parse(comboBox1.SelectedItem.ToString());

            if (string.IsNullOrEmpty(departmentName) || string.IsNullOrEmpty(headOfDepartment) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DepartmentDTO department = new DepartmentDTO
            {
                DepartmentName = departmentName,
                //HeadOfDepartment = headOfDepartment,
                Email = email,
                EstablishedYear = establishedYear
            };

            bool isAdded = departmentBLL.AddDepartment(department);
            if (isAdded)
            {
                teacherBLL.ChangeTeacherRoleToHeadOfDepartment(selectedTeacherID);
                MessageBox.Show("Department added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addDataDefault(); // Reload the list of departments
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

        // get selected combobox choice
        // check equals teacherDTO FullName to save ID
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
                textBoxEmail.Text = selectedItem.SubItems[1].Text;    // Tên khoa
                comboBoxChooseHeadofDepartment.Text = selectedItem.SubItems[2].Text; // Trưởng khoa
                textBoxDepartmentName.Text = selectedItem.SubItems[3].Text;             // Email
                comboBox1.Text = selectedItem.SubItems[4].Text;
            }
        }

        // check count if list selected, get listviewitem, check null
        // populate new dto, check update success

        private void button_update_Click(object sender, EventArgs e)
        {
            if (listViewDepartment.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 khoa bất kỳ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem selectedItem = listViewDepartment.SelectedItems[0];
            int departmentID = int.Parse(selectedItem.Text);
            string departmentName = textBoxEmail.Text;
            string headOfDepartment = comboBoxChooseHeadofDepartment.Text;
            string email = textBoxDepartmentName.Text;
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
                //HeadOfDepartment = headOfDepartment,
                Email = email,
                EstablishedYear = establishedYear
            };

            bool isUpdated = departmentBLL.UpdateDepartment(department);
            if (isUpdated)
            {
                MessageBox.Show("Cập nhật khoa thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addDataDefault(); // Reload the list of departments
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
                addDataDefault(); // Reload the list of departments
            }
        }

        private void panel_searchBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addDataDefault();
                return;
            }
            listViewDepartment.Items.Clear();
            List<DepartmentDTO> searchResults = departmentBLL.SearchDepartments(searchQuery);
            LoadListDepartment(searchResults);
        }

        private void label_panelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}