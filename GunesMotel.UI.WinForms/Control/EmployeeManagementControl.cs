using GunesMotel.DataAccess.Contexts;
using GunesMotel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunesMotel.UI.WinForms.Control
{
    public partial class EmployeeManagementControl : UserControl
    {
        public EmployeeManagementControl()
        {
            InitializeComponent();
        }

        private void LoadPositions()
        {
            using (var db = new GunesMotelContext())
            {
                var positions = db.Positions
                    .OrderBy(p => p.PositionName)
                    .ToList();

                cmbPosition.DataSource = positions;
                cmbPosition.DisplayMember = "PositionName";
                cmbPosition.ValueMember = "PositionID";
                cmbPosition.SelectedIndex = -1;
            }
        }

        private void LoadEmployees()
        {
            using (var db = new GunesMotelContext())
            {
                var list = db.Employees
                    .Include("Position") // Ensure Position is a navigation property in Employees
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
                        PositionName = e.Position.PositionName, // Access PositionName from the Position navigation property
                        e.IBAN,
                        e.HireDate,
                        e.LeaveDate
                    })
                    .ToList();

                dgvEmployees.DataSource = list;
            }
        }

        private void ClearForm()
        {
            txtFullName.Clear();
            txtNationalID.Clear();
            txtPassportID.Clear();
            dtpBirthDate.Value = DateTime.Now;
            cmbGender.SelectedIndex = -1;
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            cmbPosition.SelectedIndex = -1;
            txtIBAN.Clear();
            dtpHireDate.Value = DateTime.Now;
            dtpLeaveDate.Value = DateTime.Now;
            dtpLeaveDate.Checked = false;
        }

        private void EmployeeManagementControl_Load(object sender, EventArgs e)
        {
            LoadPositions();
            LoadEmployees();
            ClearForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var employee = new Employees
                {
                    FullName = txtFullName.Text.Trim(),
                    NationalID = txtNationalID.Text.Trim(),
                    PassportID = txtPassportID.Text.Trim(),
                    BirthDate = dtpBirthDate.Value,
                    Gender = cmbGender.SelectedItem?.ToString(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    PositionID = (int)cmbPosition.SelectedValue,
                    IBAN = txtIBAN.Text.Trim(),
                    HireDate = dtpHireDate.Value
                    // LeaveDate şimdilik eklenmedi!
                };

                // Yalnızca kullanıcı işaretlediyse LeaveDate atanır
                if (dtpLeaveDate.Checked)
                {
                    employee.LeaveDate = dtpLeaveDate.Value;
                }

                using (var db = new GunesMotelContext())
                {
                    db.Employees.Add(employee);
                    db.SaveChanges();
                }

                MessageBox.Show("Çalışan başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees();
                ClearForm();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                if (ex.InnerException != null)
                    hata += "\n\nInner Exception:\n" + ex.InnerException.Message;
                if (ex.InnerException?.InnerException != null)
                    hata += "\n\nSQL Hatası:\n" + ex.InnerException.InnerException.Message;

                MessageBox.Show("Çalışan eklenirken hata oluştu:\n\n" + hata, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
