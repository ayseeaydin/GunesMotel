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
using System.Data.Entity;

namespace GunesMotel.UI.WinForms.Control
{
    public partial class UserManagementControl : UserControl
    {
        public event EventHandler OnRolYonet;
        private int? _selectedUserID = null; // Seçili kullanıcının ID'si

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
                ShowError("Roller yüklenirken hata oluştu", ex);
            }

            LoadUsers();
            ClearForm();

            ClearDataGridSelection();
        }

        private void ClearDataGridSelection()
        {
            // Birden fazla yöntem kullanarak kesin çözüm
            try
            {
                // Yöntem 1: Doğrudan temizle
                dgvUsers.ClearSelection();

                // Yöntem 2: CurrentCell'i null yap
                dgvUsers.CurrentCell = null;

                // Yöntem 3: Timer ile geciktirilmiş temizleme
                var timer = new Timer();
                timer.Interval = 100;
                timer.Tick += (s, e) =>
                {
                    timer.Stop();
                    timer.Dispose();

                    if (dgvUsers.Rows.Count > 0)
                    {
                        dgvUsers.ClearSelection();
                        dgvUsers.CurrentCell = null;

                        // Yöntem 4: İlk satırı seç sonra temizle (bazen daha etkili)
                        if (dgvUsers.Rows.Count > 0)
                        {
                            dgvUsers.Rows[0].Selected = false;
                        }
                    }

                    // Form alanlarını da temizle
                    _selectedUserID = null;
                };
                timer.Start();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Selection temizlenirken hata: " + ex.Message);
            }
        }

        private void ShowError(string title, Exception ex)
        {
            string message = ex.Message;

            if (ex.InnerException != null)
                message += "\n" + ex.InnerException.Message;

            if (ex.InnerException?.InnerException != null)
                message += "\n" + ex.InnerException.InnerException.Message;

            // Hata log kaydı
            LogHelper.AddLog(CurrentUser.UserID, "HATA", "Exception", message);

            // Hata kullanıcıya göster
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (_selectedUserID == null) // Sadece yeni kayıt modunda temizle
                        {
                            txtFullName.Clear();
                            txtEmail.Clear();
                            txtPhone.Clear();
                        }
                        return;
                    }

                    // 2. Pozisyona uygun ve kullanıcı atanmamış çalışanlar
                    var employees = employeeRepo.GetAvailableEmployeesByPositionIDs(positionIds);

                    // Eğer güncelleme modundaysak, mevcut çalışanı da listeye ekle
                    if (_selectedUserID.HasValue)
                    {
                        var userRepo = new UserRepository(new GunesMotelContext());
                        var currentUser = userRepo.GetById(_selectedUserID.Value);
                        if (currentUser != null)
                        {
                            var currentEmployee = employeeRepo.GetById(currentUser.EmployeeID);
                            if (currentEmployee != null && !employees.Any(emp => emp.EmployeeID == currentEmployee.EmployeeID))
                            {
                                employees.Add(currentEmployee);
                            }
                        }
                    }

                    cmbEmployee.DataSource = employees.OrderBy(emp => emp.FullName).ToList();
                    cmbEmployee.DisplayMember = "FullName";
                    cmbEmployee.ValueMember = "EmployeeID";
                    cmbEmployee.SelectedIndex = -1;

                    // 3. Sadece yeni kayıt modunda diğer alanları temizle
                    if (_selectedUserID == null)
                    {
                        txtFullName.Clear();
                        txtEmail.Clear();
                        txtPhone.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("Çalışanlar yüklenirken hata oluştu", ex);
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
            else if (_selectedUserID == null) // Sadece yeni kayıt modunda temizle
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
                // Her seferinde yeni context kullan
                using (var context = new GunesMotelContext())
                {
                    var userRepo = new UserRepository(context);
                    var users = userRepo.GetUsersWithIncludes();

                    var userList = users.Select(u => new
                    {
                        UserID = u.UserID,
                        Username = u.Username,
                        Password = u.Password,
                        FullName = u.Employee?.FullName ?? "Çalışan Bulunamadı",
                        Role = u.Role?.RoleName ?? "Rol Bulunamadı",
                        Email = u.Email,
                        Phone = u.Phone,
                        Durum = u.IsActive ? "Aktif" : "Pasif"
                    }).ToList();

                    dgvUsers.DataSource = userList;

                    // Sütun başlıklarını güzelleştir
                    if (dgvUsers.Columns["UserID"] != null)
                        dgvUsers.Columns["UserID"].HeaderText = "ID";

                    if (dgvUsers.Columns["Username"] != null)
                        dgvUsers.Columns["Username"].HeaderText = "Kullanıcı Adı";

                    if (dgvUsers.Columns["Password"] != null)
                    {
                        dgvUsers.Columns["Password"].HeaderText = "Şifre";
                        dgvUsers.Columns["Password"].Visible = false; // Şifreyi gizle
                    }

                    if (dgvUsers.Columns["FullName"] != null)
                        dgvUsers.Columns["FullName"].HeaderText = "Ad Soyad";

                    if (dgvUsers.Columns["Role"] != null)
                        dgvUsers.Columns["Role"].HeaderText = "Rol";

                    if (dgvUsers.Columns["Email"] != null)
                        dgvUsers.Columns["Email"].HeaderText = "E-posta";

                    if (dgvUsers.Columns["Phone"] != null)
                        dgvUsers.Columns["Phone"].HeaderText = "Telefon";

                    if (dgvUsers.Columns["Durum"] != null)
                        dgvUsers.Columns["Durum"].HeaderText = "Durum";

                    dgvUsers.ClearSelection();
                    _selectedUserID = null;
                    ClearDataGridSelection();

                }
            }
            catch (Exception ex)
            {
                ShowError("Kullanıcılar yüklenirken hata oluştu", ex);
            }
        }

        private void ClearForm()
        {
            _selectedUserID = null;
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
            if (dgvUsers.SelectedRows.Count == 0 || dgvUsers.CurrentRow == null || dgvUsers.CurrentRow.Index == -1)
            {
                ClearForm();
                return;
            }

            try
            {
                var selectedRow = dgvUsers.SelectedRows[0];

                // Sütun varlığını ve değeri kontrol et
                if (!ContainsColumn("UserID") || selectedRow.Cells["UserID"].Value == null)
                {
                    ClearForm();
                    return;
                }

                _selectedUserID = Convert.ToInt32(selectedRow.Cells["UserID"].Value);

                // Her sütun için güvenli erişim
                txtUsername.Text = GetCellValue("Username");
                txtPassword.Text = GetCellValue("Password");
                txtFullName.Text = GetCellValue("FullName");
                txtEmail.Text = GetCellValue("Email");
                txtPhone.Text = GetCellValue("Phone");

                string roleName = GetCellValue("Role");
                string fullName = GetCellValue("FullName");

                // Rol seçimini ayarla
                if (!string.IsNullOrEmpty(roleName))
                {
                    var roleRepo = new RoleRepository(new GunesMotelContext());
                    var selectedRole = roleRepo.GetAll().FirstOrDefault(r => r.RoleName == roleName);
                    if (selectedRole != null)
                    {
                        cmbRole.SelectedValue = selectedRole.RoleID;

                        // Timer kullanarak çalışan seçimini geciktir
                        var timer = new Timer();
                        timer.Interval = 200; // 200ms bekle
                        timer.Tick += (s, ev) =>
                        {
                            timer.Stop();
                            timer.Dispose();

                            if (!string.IsNullOrEmpty(fullName) && cmbEmployee.Items.Count > 0)
                            {
                                for (int i = 0; i < cmbEmployee.Items.Count; i++)
                                {
                                    if (cmbEmployee.GetItemText(cmbEmployee.Items[i]) == fullName)
                                    {
                                        cmbEmployee.SelectedIndex = i;
                                        break;
                                    }
                                }
                            }
                        };
                        timer.Start();
                    }
                }

                // Yardımcı metotlar (local functions)
                string GetCellValue(string columnName)
                {
                    if (ContainsColumn(columnName) && selectedRow.Cells[columnName].Value != null)
                        return selectedRow.Cells[columnName].Value.ToString();
                    return string.Empty;
                }

                bool ContainsColumn(string columnName)
                {
                    return dgvUsers.Columns.Contains(columnName);
                }
            }
            catch (Exception ex)
            {
                ShowError("Kullanıcı bilgileri yüklenirken hata oluştu", ex);
                ClearForm();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Zorunlu alan kontrolü
                if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    cmbRole.SelectedItem == null ||
                    cmbEmployee.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string email = txtEmail.Text.Trim();
                string phone = txtPhone.Text.Trim();

                var selectedRole = (Roles)cmbRole.SelectedItem;
                var selectedEmployee = (Employees)cmbEmployee.SelectedItem;

                // Validasyonlar için ayrı context
                using (var validationContext = new GunesMotelContext())
                {
                    // 2. Kullanıcı adı kontrolü
                    bool usernameExists = validationContext.Database.SqlQuery<int>(
                        "SELECT COUNT(*) FROM Users WHERE Username = @p0", username).First() > 0;

                    if (usernameExists)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten kullanımda!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 3. Çalışan ataması kontrolü
                    bool employeeAssigned = validationContext.Database.SqlQuery<int>(
                        "SELECT COUNT(*) FROM Users WHERE EmployeeID = @p0 AND IsActive = 1", selectedEmployee.EmployeeID).First() > 0;

                    if (employeeAssigned)
                    {
                        MessageBox.Show("Bu çalışana zaten aktif bir kullanıcı atanmış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Insert için tamamen ayrı context
                using (var insertContext = new GunesMotelContext())
                {
                    // Raw SQL ile insert - Entity Framework tracking bypass
                    string insertSql = @"
                        INSERT INTO Users (Username, Password, FullName, Email, Phone, RoleID, EmployeeID, IsActive, CreatedAt)
                        VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)";

                    int result = insertContext.Database.ExecuteSqlCommand(insertSql,
                        username,                    // @p0
                        password,                    // @p1
                        selectedEmployee.FullName,  // @p2
                        email,                       // @p3
                        phone,                       // @p4
                        selectedRole.RoleID,         // @p5
                        selectedEmployee.EmployeeID, // @p6
                        true,                        // @p7 (IsActive)
                        DateTime.Now                 // @p8
                    );

                    if (result > 0)
                    {
                        MessageBox.Show("Kullanıcı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Log kaydı
                        try
                        {
                            LogHelper.AddLog(CurrentUser.UserID, "Kullanıcı Yönetimi", "Ekleme", $"{username} adlı kullanıcı oluşturuldu.");
                        }
                        catch (Exception logEx)
                        {
                            System.Diagnostics.Debug.WriteLine("Log yazılamadı: " + logEx.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı eklenemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Yenile ve temizle
                LoadUsers();
                ClearForm();
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                string message = "Veritabanı hatası oluştu.";

                switch (sqlEx.Number)
                {
                    case 2627: // Primary key violation
                    case 2601: // Unique constraint violation
                        if (sqlEx.Message.ToLower().Contains("username"))
                            message = "Bu kullanıcı adı zaten kullanımda!";
                        else if (sqlEx.Message.ToLower().Contains("email"))
                            message = "Bu e-posta adresi zaten kullanımda!";
                        else if (sqlEx.Message.ToLower().Contains("phone"))
                            message = "Bu telefon numarası zaten kullanımda!";
                        else
                            message = "Bu bilgiler zaten kullanımda!";
                        break;
                    case 547: // Foreign key constraint
                        message = "Seçilen rol veya çalışan bilgisi geçersiz!";
                        break;
                    case 2: // Timeout
                        message = "Veritabanı bağlantı zaman aşımı. Lütfen tekrar deneyin.";
                        break;
                    default:
                        message = $"Veritabanı hatası (Kod: {sqlEx.Number}): {sqlEx.Message}";
                        break;
                }

                MessageBox.Show(message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmeyen hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine($"Full Error: {ex}");
                LoadUsers();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_selectedUserID.HasValue)
                {
                    MessageBox.Show("Lütfen güncellenecek bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 1. Zorunlu alan kontrolü
                if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    cmbRole.SelectedItem == null ||
                    cmbEmployee.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string email = txtEmail.Text.Trim();
                string phone = txtPhone.Text.Trim();

                var selectedRole = (Roles)cmbRole.SelectedItem;
                var selectedEmployee = (Employees)cmbEmployee.SelectedItem;

                // Her işlem için yeni context kullan
                using (var context = new GunesMotelContext())
                {
                    var userRepo = new UserRepository(context);
                    var user = userRepo.GetById(_selectedUserID.Value);

                    if (user == null)
                    {
                        MessageBox.Show("Seçilen kullanıcı bulunamadı veya başka bir kullanıcı tarafından silindi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadUsers(); // Listeyi yenile
                        ClearForm();
                        return;
                    }

                    // 2. Kullanıcı adı değişmişse, başka birinde var mı kontrol et
                    if (user.Username != username)
                    {
                        var existingUser = context.Users.FirstOrDefault(u => u.Username == username && u.UserID != _selectedUserID.Value);
                        if (existingUser != null)
                        {
                            MessageBox.Show("Bu kullanıcı adı zaten kullanımda!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 3. Çalışan değişmişse, o çalışana başka aktif kullanıcı atanmış mı?
                    if (user.EmployeeID != selectedEmployee.EmployeeID)
                    {
                        var employeeUser = context.Users.FirstOrDefault(u => u.EmployeeID == selectedEmployee.EmployeeID && u.UserID != _selectedUserID.Value && u.IsActive);
                        if (employeeUser != null)
                        {
                            MessageBox.Show("Bu çalışana zaten başka bir aktif kullanıcı atanmış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 4. Güncelleme
                    string oldUsername = user.Username;
                    user.Username = username;
                    user.Password = password;
                    user.Email = email;
                    user.Phone = phone;
                    user.RoleID = selectedRole.RoleID;
                    user.EmployeeID = selectedEmployee.EmployeeID;
                    user.FullName = selectedEmployee.FullName;

                    userRepo.Update(user);

                    // 5. Log kaydı
                    LogHelper.AddLog(CurrentUser.UserID, "Kullanıcı Yönetimi", "Güncelleme", $"{oldUsername} → {username} kullanıcı güncellendi.");

                    MessageBox.Show("Kullanıcı başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // 6. Yenile
                LoadUsers();
                ClearForm();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadUsers(); // Listeyi yenile
                ClearForm();
            }
            catch (Exception ex)
            {
                ShowError("Kullanıcı güncellenirken hata oluştu", ex);
                LoadUsers(); // Hata durumunda listeyi yenile
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_selectedUserID.HasValue)
                {
                    MessageBox.Show("Lütfen silinecek bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Her işlem için yeni context kullan
                using (var context = new GunesMotelContext())
                {
                    var userRepo = new UserRepository(context);
                    var user = userRepo.GetById(_selectedUserID.Value);

                    if (user == null)
                    {
                        MessageBox.Show("Seçilen kullanıcı bulunamadı veya başka bir kullanıcı tarafından silindi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadUsers(); // Listeyi yenile
                        ClearForm();
                        return;
                    }

                    // Onay iste
                    var result = MessageBox.Show(
                        $"'{user.Username}' kullanıcısını silmek istediğinizden emin misiniz?\n\nBu işlem geri alınamaz!",
                        "Silme Onayı",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result != DialogResult.Yes)
                        return;

                    // Soft delete - IsActive = false
                    user.IsActive = false;
                    userRepo.Update(user);

                    // Log kaydı
                    LogHelper.AddLog(CurrentUser.UserID, "Kullanıcı Yönetimi", "Silme", $"{user.Username} kullanıcısı silindi (pasif yapıldı).");

                    MessageBox.Show("Kullanıcı başarıyla silindi (pasif yapıldı).", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Yenile
                LoadUsers();
                ClearForm();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadUsers(); // Listeyi yenile
                ClearForm();
            }
            catch (Exception ex)
            {
                ShowError("Kullanıcı silinirken hata oluştu", ex);
                LoadUsers(); // Hata durumunda listeyi yenile
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadUsers();
                ClearForm();

                // Rolleri de yeniden yükle
                var roleRepo = new RoleRepository(new GunesMotelContext());
                var roles = roleRepo.GetAllOrdered();

                cmbRole.DataSource = roles;
                cmbRole.DisplayMember = "RoleName";
                cmbRole.ValueMember = "RoleID";
                cmbRole.SelectedIndex = -1;

                LogHelper.AddLog(CurrentUser.UserID, "Kullanıcı Yönetimi", "Yenileme", "Kullanıcı listesi yenilendi.");

                MessageBox.Show("Liste başarıyla yenilendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowError("Liste yenilenirken hata oluştu", ex);
            }
        }
    }
}