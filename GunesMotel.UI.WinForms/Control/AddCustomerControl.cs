using GunesMotel.DataAccess.Repositories;
using GunesMotel.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GunesMotel.UI.WinForms.Control
{
    public partial class AddCustomerControl : UserControl
    {
        public AddCustomerControl()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            var repo = new CustomerRepository();
            var customerList = repo.GetAll();

            dgvCustomers.DataSource = customerList;

            if (dgvCustomers.Columns["CustomerID"] != null)
                dgvCustomers.Columns["CustomerID"].Visible = false;

            if (dgvCustomers.Columns["Notes"] != null)
                dgvCustomers.Columns["Notes"].Visible = false;

            if (dgvCustomers.Columns["Reservations"] != null)
                dgvCustomers.Columns["Reservations"].Visible = false;
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0) return;

            var row = dgvCustomers.SelectedRows[0];

            txtFullName.Text = row.Cells["FullName"].Value?.ToString();
            txtNationalID.Text = row.Cells["NationalID"].Value?.ToString();
            txtPassportNo.Text = row.Cells["PassportNo"].Value?.ToString();

            var birthDateValue = row.Cells["BirthDate"].Value;
            if (birthDateValue != null && birthDateValue != DBNull.Value)
                dtpBirthDate.Value = Convert.ToDateTime(birthDateValue);
            else
                dtpBirthDate.Value = DateTime.Today;

            cmbGender.SelectedItem = row.Cells["Gender"].Value?.ToString();
            txtPhone.Text = row.Cells["Phone"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtAddress.Text = row.Cells["Address"].Value?.ToString();
            txtNotes.Text = row.Cells["Notes"].Value?.ToString();
        }

        private void ClearForm()
        {
            txtFullName.Clear();
            txtNationalID.Clear();
            txtPassportNo.Clear();
            dtpBirthDate.Value = DateTime.Today;
            cmbGender.SelectedIndex = -1;
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtNotes.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("Ad Soyad alanı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Telefon alanı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("E-posta alanı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("Adres alanı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newCustomer = new Customers
                {
                    FullName = txtFullName.Text.Trim(),
                    NationalID = string.IsNullOrWhiteSpace(txtNationalID.Text) ? null : txtNationalID.Text.Trim(),
                    PassportNo = string.IsNullOrWhiteSpace(txtPassportNo.Text) ? null : txtPassportNo.Text.Trim(),
                    BirthDate = dtpBirthDate.Value,
                    Gender = cmbGender.SelectedItem?.ToString(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Notes = txtNotes.Text.Trim(),
                    RegisterDate = DateTime.Now
                };

                var repo = new CustomerRepository();
                repo.Add(newCustomer);

                MessageBox.Show("Yeni müşteri başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCustomers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri ekleme hatası: " + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Güncellenecek müşteri seçilmedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("Ad Soyad alanı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Telefon alanı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvCustomers.SelectedRows[0];
                int customerId = Convert.ToInt32(selectedRow.Cells["CustomerID"].Value);

                var repo = new CustomerRepository();

                // NationalID çakışma kontrolü
                string nationalId = txtNationalID.Text.Trim();
                if (!string.IsNullOrEmpty(nationalId) && repo.IsNationalIDExists(nationalId, customerId))
                {
                    MessageBox.Show("Bu TC Kimlik Numarası başka bir müşteriye ait.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var updatedCustomer = new Customers
                {
                    CustomerID = customerId,
                    FullName = txtFullName.Text.Trim(),
                    NationalID = string.IsNullOrWhiteSpace(txtNationalID.Text) ? null : txtNationalID.Text.Trim(),
                    PassportNo = string.IsNullOrWhiteSpace(txtPassportNo.Text) ? null : txtPassportNo.Text.Trim(),
                    BirthDate = dtpBirthDate.Value,
                    Gender = cmbGender.SelectedItem?.ToString(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Notes = txtNotes.Text.Trim()
                };

                repo.Update(updatedCustomer);

                MessageBox.Show("Müşteri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomers();
                ClearForm();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Müşteri güncelleme hatası: " + inner, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
            dgvCustomers.ClearSelection();
            txtFullName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Silinecek müşteri seçilmedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var dialogResult = MessageBox.Show("Seçili müşteriyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult != DialogResult.Yes)
                    return;

                var selectedRow = dgvCustomers.SelectedRows[0];
                int customerId = Convert.ToInt32(selectedRow.Cells["CustomerID"].Value);

                var repo = new CustomerRepository();
                repo.Delete(customerId);

                MessageBox.Show("Müşteri başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCustomers();
                ClearForm();
            }
            catch (Exception ex)
            {
                var innerMessage = ex.InnerException?.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Silme hatası: " + innerMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            var repo = new CustomerRepository();
            var allCustomers = repo.GetAll();

            var filtered = allCustomers.Where(c =>
                (c.FullName != null && c.FullName.ToLower().Contains(keyword)) ||
                (c.Phone != null && c.Phone.ToLower().Contains(keyword)) ||
                (c.Email != null && c.Email.ToLower().Contains(keyword)) ||
                (c.NationalID != null && c.NationalID.ToLower().Contains(keyword)) ||
                (c.PassportNo != null && c.PassportNo.ToLower().Contains(keyword)) ||
                (c.Gender != null && c.Gender.ToLower().Contains(keyword)) ||
                (c.Address != null && c.Address.ToLower().Contains(keyword))
            ).ToList();

            dgvCustomers.DataSource = filtered;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Aranacak değeri giriniz...")
            {
                txtSearch.Text = string.Empty;
                txtSearch.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Aranacak değeri giriniz...";
                txtSearch.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
