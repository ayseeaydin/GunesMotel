using GunesMotel.DataAccess.Repositories;
using GunesMotel.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GunesMotel.Entities;
using GunesMotel.Common;
using GunesMotel.DataAccess.Helpers;

namespace GunesMotel.UI.WinForms.Control
{
    public partial class UserManagementControl : UserControl
    {
        public event EventHandler OnRolYonet;

        public UserManagementControl()
        {
            InitializeComponent();
        }


        private void UserManagementControl_Load(object sender, EventArgs e)
        {
            try
            {
                var roleRepo = new RoleRepository(new GunesMotelContext());
                var roles = roleRepo.GetAllOrdered();

                cmbRole.DataSource = roles;
                cmbRole.DisplayMember = "RoleName";
                cmbRole.ValueMember = "RoleID";
                cmbRole.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Roller yüklenirken hata oluştu.\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadUsers();
        }

        private void btnRoleManagement_Click(object sender, EventArgs e)
        {
            OnRolYonet?.Invoke(this, EventArgs.Empty);
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbRole.SelectedItem is Roles selectedRole)
                {
                    var roleMapRepo = new RolePositionMapRepository();
                    var employeeRepo = new EmployeeRepository(new GunesMotelContext());

                    // 1. Role bağlı pozisyon ID'leri
                    var positionIds = roleMapRepo.GetPositionIdsByRoleId(selectedRole.RoleID);

                    if (positionIds.Count == 0)
                    {
                        cmbEmployee.DataSource = null;
                        txtFullName.Clear();
                        txtEmail.Clear();
                        txtPhone.Clear();
                        return;
                    }

                    // 2. Pozisyona uygun ve kullanıcı atanmamış çalışanlar
                    var employees = employeeRepo.GetAvailableEmployeesByPositionIDs(positionIds);

                    cmbEmployee.DataSource = employees;
                    cmbEmployee.DisplayMember = "FullName";
                    cmbEmployee.ValueMember = "EmployeeID";
                    cmbEmployee.SelectedIndex = -1;

                    // 3. Diğer alanlar temizlensin
                    txtFullName.Clear();
                    txtEmail.Clear();
                    txtPhone.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                        $"Çalışanlar yüklenirken hata oluştu:\n\n{ex.Message}\n\n{ex.InnerException?.Message}",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployee.SelectedItem is Employees selectedEmployee)
            {
                txtFullName.Text = selectedEmployee.FullName;
                txtEmail.Text = selectedEmployee.Email;
                txtPhone.Text = selectedEmployee.Phone;
            }
            else
            {
                txtFullName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
            }
        }

        private void LoadUsers()
        {
            try
            {
                var userRepo = new UserRepository(new GunesMotelContext());
                var users = userRepo.GetUsersWithIncludes();

                dgvUsers.DataSource = users.Select(u => new
                {
                    u.UserID,
                    u.Username,
                    u.Password,
                    FullName = u.Employee.FullName,
                    Role = u.Role.RoleName,
                    u.Email,
                    u.Phone,
                    Durum = u.IsActive ? "Aktif" : "Pasif"
                }).ToList();

                dgvUsers.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcılar yüklenirken hata oluştu:\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtFullName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            cmbRole.SelectedIndex = -1;
            cmbEmployee.DataSource = null;
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var selectedRow = dgvUsers.SelectedRows[0];

                txtUsername.Text = selectedRow.Cells["Username"].Value?.ToString();
                txtPassword.Text = selectedRow.Cells["Password"].Value?.ToString();
                txtFullName.Text = selectedRow.Cells["FullName"].Value?.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
                txtPhone.Text = selectedRow.Cells["Phone"].Value?.ToString();

                string roleName = selectedRow.Cells["Role"].Value?.ToString();

                // Rol ve çalışan eşleşmesi için:
                var roleRepo = new RoleRepository(new GunesMotelContext());
                var selectedRole = roleRepo.GetAll().FirstOrDefault(r => r.RoleName == roleName);
                if (selectedRole != null)
                {
                    cmbRole.SelectedValue = selectedRole.RoleID;
                }

                // cmbEmployee otomatik dolduğunda selection yapılmalı
                string fullName = selectedRow.Cells["FullName"].Value?.ToString();
                cmbEmployee.SelectedIndex = cmbEmployee.FindStringExact(fullName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // 🧪 1. Zorunlu alanlar kontrol edilsin
                if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    cmbRole.SelectedItem == null ||
                    cmbEmployee.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen tüm zorunlu alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🎯 2. Girişler alınır
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string email = txtEmail.Text.Trim();
                string phone = txtPhone.Text.Trim();

                var selectedRole = (Roles)cmbRole.SelectedItem;
                var selectedEmployee = (Employees)cmbEmployee.SelectedItem;

                // 🔍 3. Kullanıcı adı daha önce kullanılmış mı?
                var userRepo = new UserRepository(new GunesMotelContext());
                if (userRepo.UsernameExists(username))
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kullanımda!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 🛠 4. Yeni kullanıcı nesnesi oluşturuluyor
                var newUser = new Users
                {
                    Username = username,
                    Password = password,
                    RoleID = selectedRole.RoleID,
                    EmployeeID = selectedEmployee.EmployeeID,
                    Email = email,
                    Phone = phone,
                    IsActive = true
                };

                // 💾 5. Kaydediliyor
                userRepo.Add(newUser);

                // 📋 6. Log kaydı (isteğe bağlı)
                LogHelper.AddLog(CurrentUser.UserID, "Kullanıcı Yönetimi", "Ekleme", $"{username} adlı kullanıcı eklendi.");

                // 🔄 7. Liste güncelle ve formu temizle
                LoadUsers();
                ClearForm();

                MessageBox.Show("Kullanıcı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
        "Kullanıcı eklenirken hata oluştu:\n\n" +
        ex.Message + "\n\n" +
        ex.InnerException?.Message,
        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error
    );

                LogHelper.AddLog(0, "Kullanıcı Yönetimi", "Hata", $"Kullanıcı eklenirken hata: {ex.Message} - {ex.InnerException?.Message}");
            }
        }
    }
}
