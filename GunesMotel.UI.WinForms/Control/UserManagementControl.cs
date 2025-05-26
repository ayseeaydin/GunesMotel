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
        private readonly RoleRepository _roleRepo = new RoleRepository(new GunesMotelContext());
        private readonly EmployeeRepository _employeeRepo=new EmployeeRepository(new GunesMotelContext());
        
        public UserManagementControl()
        {
            InitializeComponent();
        }

        private void ShowError(string title, Exception ex)
        {
            string msg = ex.Message;
            if (ex.InnerException != null) msg += "\n" + ex.InnerException.Message;
            if (ex.InnerException?.InnerException != null) msg += "\n" + ex.InnerException.InnerException.Message;

            LogHelper.AddLog(CurrentUser.UserID, "HATA", "Exception", msg);
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoadRoles()
        {
            try
            {
                var roles = _roleRepo.GetAllOrdered();

                if (roles == null || !roles.Any())
                {
                    MessageBox.Show("Rol listesi boş!","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                cmbRole.DisplayMember = "RoleName"; // Görüntülenecek alan
                cmbRole.ValueMember = "RoleID"; // Değer olarak kullanılacak alan
                cmbRole.DataSource = roles;
                cmbRole.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Roller yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void UserManagementControl_Load(object sender, EventArgs e)
        {
            LoadRoles();
            dgvUsers.ClearSelection();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Geçersiz seçim varsa çık
                if (cmbRole.SelectedIndex == -1 || cmbRole.SelectedValue == null)
                    return;

                // RoleID'yi al ve doğrula
                if (!int.TryParse(cmbRole.SelectedValue.ToString(), out int selectedRoleId))
                    return;

                // Role nesnesini al
                var role = _roleRepo.GetById(selectedRoleId);
                if (role == null)
                {
                    MessageBox.Show("Seçilen rol bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string roleName = role.RoleName;

                // Rol adına göre kullanıcı atanmamış çalışanları getir
                var employees = _employeeRepo.GetUnassignedEmployeesByRoleName(roleName);

                // Eğer uygun çalışan yoksa kullanıcıyı bilgilendir ve temizle
                if (employees == null || !employees.Any())
                {
                    MessageBox.Show("Bu role uygun çalışan bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbEmployee.DataSource = null;
                    return;
                }

                // Çalışanları ComboBox'a yükle
                cmbEmployee.DisplayMember = "FullName";
                cmbEmployee.ValueMember = "EmployeeID";
                cmbEmployee.DataSource = employees;
                cmbEmployee.SelectedIndex = -1;

                // Önceki bilgileri temizle
                txtFullName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
            }
            catch (Exception ex)
            {
                // Log kaydı al ve kullanıcıya bilgi ver
                LogHelper.AddLog(CurrentUser.UserID, "User Management", "Rol seçimi", ex.Message);
                MessageBox.Show("Çalışanlar yüklenirken bir hata oluştu.\n\n" + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployee.SelectedIndex == -1 || cmbEmployee.SelectedItem == null) return;

            var selectedEmployee = cmbEmployee.SelectedItem as Employees;

            if(selectedEmployee != null)
            {
                txtFullName.Text=selectedEmployee.FullName;
                txtEmail.Text=selectedEmployee.Email;
                txtPhone.Text=selectedEmployee.Phone;
            }
        }
    }
}
