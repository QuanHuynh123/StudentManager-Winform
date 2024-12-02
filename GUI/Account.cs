using BLL;
using DAL.Models;
using DTO;
using DTO.Models;

namespace GUI
{
    public partial class Account : Form
    {
        private readonly TeacherBLL teacherBLL;
        private readonly DepartmentBLL departmentBLL;
        private readonly RoleBLL roleBLL;

        private Dictionary<string, Button> controls = [];

        public Account()
        {
            InitializeComponent();
            teacherBLL = new TeacherBLL();
            departmentBLL = new DepartmentBLL();
            roleBLL = new RoleBLL();
            InitPage();
        }

        private void InitPage()
        {
            listView_account.FullRowSelect = true;
            listView_account.CheckBoxes = true;

            button_search.Click += (sender, e) => search_action(sender, e);

            controls.Add(Constants.Add, button_add);
            controls.Add(Constants.Update, button_edit);
            controls.Add(Constants.Delete, button_delete);

            search_action(null, null);
            BindDataToComboBox();

            // Decentralize
            Common.LoadFeatureForUser(controls, Constants.Account);
        }

        private void BindDataToComboBox()
        {
            List<DepartmentDTO> departmentResponse = departmentBLL.GetDepartmentsOfTeacher();
            SearchResponse<RoleDTO> roleSearchResponse = roleBLL.Search(new SearchRequest { PageSize = 9999 });

            comboBox_gender.DataSource = new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(0, "Nữ"),
                new KeyValuePair<int, string>(1, "Nam")
            };
            comboBox_gender.DisplayMember = "Value";
            comboBox_gender.ValueMember = "Key";

            comboBox_department.DataSource = departmentResponse?.Select(t => new KeyValuePair<int, string>(t.DepartmentID, t.DepartmentName)).ToList();
            comboBox_department.DisplayMember = "Value";
            comboBox_department.ValueMember = "Key";

            comboBox_role.DataSource = roleSearchResponse.Data.Select(s => new KeyValuePair<int, string>(s.RoleID, s.NameRole)).ToList();
            comboBox_role.DisplayMember = "Value";
            comboBox_role.ValueMember = "Key";
        }

        private void search_action(object sender, EventArgs e, int pageIndex = 0, int pageSize = 10)
        {
            var keyword = textBox_search.Text;
            SearchRequest searchRequest = new SearchRequest
            {
                KeyWord = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };

            int departmentID = SessionLogin.LoggedInTeacher.DepartmentID;
            bool check = true;
            if (SessionLogin.LoggedInTeacher.RoleID == 3)  check = false;
            SearchResponse<TeacherDTO> result = teacherBLL.SearchTeacherInDepartment(searchRequest, departmentID, check);

            ResetPage();

            result.Data.ForEach(x =>
            {
                ListViewItem item = new(x.TeacherID.ToString());
                item.SubItems.Add(x.Email);
                item.SubItems.Add(x.PhoneNumber);
                item.SubItems.Add(x.FullName);
                item.SubItems.Add(x.Gender ? "Nam" : "Nữ");
                item.SubItems.Add(x.Username);
                item.SubItems.Add($"{x.DepartmentID} - {x.Department.DepartmentName}");
                item.SubItems.Add($"{x.RoleID} - {x.Role.NameRole}");

                listView_account.Items.Add(item);
            });
        }

        private void ResetPage()
        {
            listView_account.Items.Clear();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            // Get data
            string email = textBox_email.Text;
            string phoneNumber = textBox_phone_number.Text;
            string fullName = textBox_full_name.Text;
            bool gender = comboBox_gender.SelectedIndex != 0;
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            int departmentID = int.Parse(comboBox_department.SelectedValue.ToString());
            int roleID = int.Parse(comboBox_role.SelectedValue.ToString());

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TeacherDTO teacherDTO = new TeacherDTO
            {
                Email = email,
                PhoneNumber = phoneNumber,
                FullName = fullName,
                Gender = gender,
                Username = username,
                Password = password,
                DepartmentID = departmentID,
                RoleID = roleID
            };

            bool isAdded = teacherBLL.Create(teacherDTO);
            if (isAdded)
            {
                MessageBox.Show("Tạo thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                search_action(null, null);
                clearData();
                return;
            }
            else
            {
                MessageBox.Show("Tạo thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (listView_account.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 record bất kỳ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem selectedItem = listView_account.SelectedItems[0];

            // Get data
            int accountID = int.Parse(selectedItem.Text);
            string email = textBox_email.Text;
            string phoneNumber = textBox_phone_number.Text;
            string fullName = textBox_full_name.Text;
            bool gender = comboBox_gender.SelectedIndex != 0;
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            int departmentID = int.Parse(comboBox_department.SelectedValue.ToString());
            int roleID = int.Parse(comboBox_role.SelectedValue.ToString());

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TeacherDTO teacherDTO = new TeacherDTO
            {
                TeacherID = accountID,
                Email = email,
                PhoneNumber = phoneNumber,
                FullName = fullName,
                Gender = gender,
                Username = username,
                Password = password,
                DepartmentID = departmentID,
                RoleID = roleID
            };

            bool isAdded = teacherBLL.Update(teacherDTO);
            if (isAdded)
            {
                MessageBox.Show("Tạo thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                search_action(null, null);
                clearData();
                return;
            }
            else
            {
                MessageBox.Show("Tạo thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listView_account.CheckedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn record bất kì trước khi xóa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không ?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem item in listView_account.CheckedItems)
                {
                    int teacherID = int.Parse(item.Text);

                    bool isDeleted = teacherBLL.Delete(teacherID);
                    if (!isDeleted)
                    {
                        MessageBox.Show($"Xảy ra lỗi khi xóa ID : {teacherID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                MessageBox.Show("Xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                search_action(null, null);
            }
        }

        private void clearData()
        {
            textBox_email.Text = string.Empty;
            textBox_phone_number.Text = string.Empty;
            textBox_full_name.Text = string.Empty;
            comboBox_gender.Text = string.Empty;
            textBox_username.Text = string.Empty;
            textBox_password.Text = string.Empty;
            comboBox_department.Text = string.Empty;
            comboBox_role.Text = string.Empty;
        }

        private void listView_account_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_account.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_account.SelectedItems[0];

                // Show data
                textBox_email.Text = selectedItem.SubItems[1].Text;
                textBox_phone_number.Text = selectedItem.SubItems[2].Text;
                textBox_full_name.Text = selectedItem.SubItems[3].Text;
                comboBox_gender.SelectedIndex = selectedItem.SubItems[4].Text == "Nam" ? 1 : 0;
                textBox_username.Text = selectedItem.SubItems[5].Text;
                comboBox_department.SelectedValue = int.Parse(selectedItem.SubItems[6].Text.Split(" - ")[0]);
                comboBox_role.SelectedValue = int.Parse(selectedItem.SubItems[7].Text.Split(" - ")[0]);
            }
        }
    }
}
