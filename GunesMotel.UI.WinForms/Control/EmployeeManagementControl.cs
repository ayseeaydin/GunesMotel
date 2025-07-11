﻿using GunesMotel.Common;
using GunesMotel.DataAccess.Contexts;
using GunesMotel.DataAccess.Helpers;
using GunesMotel.DataAccess.Repositories;
using GunesMotel.Entities;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GunesMotel.UI.WinForms.Control
{
    public partial class EmployeeManagementControl : UserControl
    {
        public event EventHandler OnPozisyonYonet;
        private readonly EmployeeRepository _employeeRepo;
        private readonly GunesMotelContext _context;
        public EmployeeManagementControl()
        {
            InitializeComponent();
            _context = new GunesMotelContext();
            _employeeRepo = new EmployeeRepository(_context);
            LoadPositions();
            LoadEmployees();
            ClearForm();

            this.HandleCreated += (s, e) =>
            {
                dgvEmployees.BeginInvoke(new Action(() => dgvEmployees.ClearSelection()));
            };

        }

        private void ShowError(string title, Exception ex)
        {
            string message = ex.Message;

            if (ex.InnerException != null)
                message += "\n" + ex.InnerException.Message;

            if (ex.InnerException?.InnerException != null)
                message += "\n" + ex.InnerException.InnerException.Message;

            // Hata log kaydı alınır
            LogHelper.AddLog(CurrentUser.UserID, "HATA", "Exception", message);

            // Hata kullanıcıya gösterilir
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoadPositions()
        {
            try
            {
                var positions = _context.Positions.OrderBy(p => p.PositionName).ToList();
                cmbPosition.DataSource = positions;
                cmbPosition.DisplayMember = "PositionName";
                cmbPosition.ValueMember = "PositionID";
                cmbPosition.SelectedIndex = -1; // Seçili öğeyi kaldır
            }
            catch (Exception ex)
            {
                ShowError("Pozisyonlar yüklenirken hata oluştu", ex);
            }
        }

        private void LoadEmployees()
        {
            try
            {
                var employees = _employeeRepo.GetActiveEmployeesWithPosition()
                    .Select(e => new
                    {
                        e.EmployeeID,
                        e.FullName,
                        e.NationalID,
                        e.PassportID,
                        e.BirthDate,
                        e.Gender,
                        e.Phone,
                        e.Email,
                        e.Address,
                        PositionName = e.Position?.PositionName,
                        e.IBAN,
                        e.HireDate,
                        e.LeaveDate
                    })
                    .ToList();

                dgvEmployees.DataSource = employees;
                dgvEmployees.ClearSelection();
            }
            catch (Exception ex)
            {
                ShowError("Çalışanlar yüklenirken hata oluştu", ex);
            }
        }

        private void ClearForm()
        {
            txtFullName.Text = "Ad Soyad";
            txtFullName.ForeColor = Color.Gray;

            txtNationalID.Text = "T.C. Kimlik No";
            txtNationalID.ForeColor = Color.Gray;

            txtPassportID.Text = "Pasaport No";
            txtPassportID.ForeColor = Color.Gray;

            dtpBirthDate.Value = DateTime.Now;
            cmbGender.SelectedIndex = -1;

            txtPhone.Text = "Telefon";
            txtPhone.ForeColor = Color.Gray;

            txtEmail.Text = "E-posta";
            txtEmail.ForeColor = Color.Gray;

            txtAddress.Text = "Adres";
            txtAddress.ForeColor = Color.Gray;

            cmbPosition.SelectedIndex = -1;

            txtIBAN.Text = "IBAN";
            txtIBAN.ForeColor = Color.Gray;

            dtpHireDate.Value = DateTime.Now;
            dtpLeaveDate.Value = DateTime.Now;
            dtpLeaveDate.Checked = false;
        }

        private void EmployeeManagementControl_Load(object sender, EventArgs e)
        {
            LoadPositions();
            LoadEmployees();
            ClearForm();

            this.HandleCreated += (s, a) =>
            {
                dgvEmployees.BeginInvoke(new Action(() => dgvEmployees.ClearSelection()));
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newEmp = new Employees
                {
                    FullName = txtFullName.Text.Trim(),
                    NationalID = string.IsNullOrWhiteSpace(txtNationalID.Text) ? null : txtNationalID.Text.Trim(),
                    PassportID = string.IsNullOrWhiteSpace(txtPassportID.Text) ? null : txtPassportID.Text.Trim(),
                    BirthDate = dtpBirthDate.Value,
                    Gender = cmbGender.Text,
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    PositionID = Convert.ToInt32(cmbPosition.SelectedValue),
                    IBAN = txtIBAN.Text.Trim(),
                    HireDate = dtpHireDate.Value,
                    LeaveDate = dtpLeaveDate.Checked ? (DateTime?)dtpLeaveDate.Value : null,
                    IsActive = true,
                    CreatedAt = DateTime.Now
                };

                _employeeRepo.Add(newEmp);

                // Log kaydı
                LogHelper.AddLog(CurrentUser.UserID, "Personel Yönetimi", "Ekleme", $"{newEmp.FullName} adlı çalışan eklendi.");

                MessageBox.Show("Çalışan başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees();
                ClearForm();
            }
            catch (Exception ex)
            {
                ShowError("Çalışan eklenirken hata oluştu", ex);
            }
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0 || dgvEmployees.CurrentRow == null || dgvEmployees.CurrentRow.Index == -1)
            {
                ClearForm();
                return;
            }

            int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeID"].Value);
            var employee = _employeeRepo.GetById(id);
            if (employee == null) return;

            txtFullName.Text = employee.FullName;
            txtNationalID.Text = employee.NationalID;
            txtPassportID.Text = employee.PassportID;
            dtpBirthDate.Value = employee.BirthDate;
            cmbGender.SelectedItem = employee.Gender;
            txtPhone.Text = employee.Phone;
            txtEmail.Text = employee.Email;
            txtAddress.Text = employee.Address;
            cmbPosition.SelectedValue = employee.PositionID;
            txtIBAN.Text = employee.IBAN;
            dtpHireDate.Value = employee.HireDate;

            if (employee.LeaveDate.HasValue)
            {
                dtpLeaveDate.Checked = true;
                dtpLeaveDate.Value = employee.LeaveDate.Value;
            }
            else
            {
                dtpLeaveDate.Checked = false;
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployees.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen güncellenecek bir çalışan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeID"].Value);
                var employee = _employeeRepo.GetById(id);

                if (employee == null)
                    throw new Exception("Seçilen çalışan veritabanında bulunamadı.");

                employee.FullName = txtFullName.Text.Trim();
                employee.NationalID = string.IsNullOrWhiteSpace(txtNationalID.Text) ? null : txtNationalID.Text.Trim();
                employee.PassportID = string.IsNullOrWhiteSpace(txtPassportID.Text) ? null : txtPassportID.Text.Trim();
                employee.BirthDate = dtpBirthDate.Value;
                employee.Gender = cmbGender.Text;
                employee.Phone = txtPhone.Text.Trim();
                employee.Email = txtEmail.Text.Trim();
                employee.Address = txtAddress.Text.Trim();
                employee.PositionID = Convert.ToInt32(cmbPosition.SelectedValue);
                employee.IBAN = txtIBAN.Text.Trim();
                employee.HireDate = dtpHireDate.Value;
                employee.LeaveDate = dtpLeaveDate.Checked ? (DateTime?)dtpLeaveDate.Value : null;

                _employeeRepo.Update(employee);

                LogHelper.AddLog(CurrentUser.UserID, "Personel Yönetimi", "Güncelleme", $"{employee.FullName} adlı çalışan güncellendi.");

                MessageBox.Show("Çalışan güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees();
                ClearForm();
            }
            catch (Exception ex)
            {
                ShowError("Güncelleme sırasında hata oluştu", ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployees.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen silinecek bir çalışan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeID"].Value);
                var employee = _employeeRepo.GetById(id);

                if (employee == null)
                    throw new Exception("Seçilen çalışan bulunamadı.");

                // Soft-delete işlemi
                employee.IsActive = false;
                employee.LeaveDate = DateTime.Now;

                _employeeRepo.Update(employee);

                LogHelper.AddLog(CurrentUser.UserID, "Personel Yönetimi", "Silme", $"{employee.FullName} adlı çalışan silindi (pasif yapıldı).");

                MessageBox.Show("Çalışan silindi (pasif yapıldı).", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees();
                ClearForm();
            }
            catch (Exception ex)
            {
                ShowError("Silme sırasında hata oluştu", ex);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPositions();
            LoadEmployees();
            ClearForm();
        }

        private void btnPositionManagement_Click(object sender, EventArgs e)
        {
            // Bu event dış dünyaya haber verir
            OnPozisyonYonet?.Invoke(this, EventArgs.Empty);
        }

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            if(txtFullName.Text =="Ad Soyad")
            {
                txtFullName.Text = "";
                txtFullName.ForeColor =Color.Black;
            }
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                txtFullName.Text = "Ad Soyad";
                txtFullName.ForeColor = Color.Gray;            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "E-posta")
            {
                txtEmail.Text ="";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "E-posta";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtNationalID_Enter(object sender, EventArgs e)
        {
            if(txtNationalID.Text == "T.C. Kimlik No")
            {
                txtNationalID.Text = "";
                txtNationalID.ForeColor = Color.Black;
            }
        }

        private void txtNationalID_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNationalID.Text))
            {
                txtNationalID.Text = "T.C. Kimlik No";
                txtNationalID.ForeColor = Color.Gray;
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if(txtAddress.Text == "Adres")
            {
                txtAddress.Text = "";
                txtAddress.ForeColor = Color.Black;
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                txtAddress.Text = "Adres";
                txtAddress.ForeColor = Color.Gray;
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if(txtPhone.Text == "Telefon")
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = Color.Black;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                txtPhone.Text = "Telefon";
                txtPhone.ForeColor = Color.Gray;
            }
        }

        private void txtPassportID_Enter(object sender, EventArgs e)
        {
            if(txtPassportID.Text == "Pasaport No")
            {
                txtPassportID.Text = "";
                txtPassportID.ForeColor = Color.Black;
            }
        }

        private void txtPassportID_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPassportID.Text))
            {
                txtPassportID.Text = "Pasaport No";
                txtPassportID.ForeColor = Color.Gray;
            }
        }

        private void txtIBAN_Enter(object sender, EventArgs e)
        {
            if(txtIBAN.Text == "IBAN")
            {
                txtIBAN.Text = "";
                txtIBAN.ForeColor = Color.Black;
            }
        }

        private void txtIBAN_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIBAN.Text))
            {
                txtIBAN.Text = "IBAN";
                txtIBAN.ForeColor = Color.Gray;
            }
        }
    }
}