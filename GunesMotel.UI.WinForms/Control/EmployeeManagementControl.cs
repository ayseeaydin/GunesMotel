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
                dgvEmployees.ClearSelection();
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

            // Seçimi form yüklendikten sonra temizle
            this.BeginInvoke(new Action(()=>dgvEmployees.ClearSelection()));
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
                    HireDate = dtpHireDate.Value,
                    LeaveDate = (dtpLeaveDate.ShowCheckBox && dtpLeaveDate.Checked)
                                ? (DateTime?)dtpLeaveDate.Value
                                : null,
                    IsActive = true,
                    CreatedAt = DateTime.Now
                };

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
                string msg = ex.Message;
                if (ex.InnerException != null)
                    msg += "\n" + ex.InnerException.Message;
                if (ex.InnerException?.InnerException != null)
                    msg += "\n" + ex.InnerException.InnerException.Message;

                MessageBox.Show("HATA:\n" + msg, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0 || dgvEmployees.CurrentRow==null || dgvEmployees.CurrentRow.Index==-1)
            {
                ClearForm();
                return;
            }

            int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeID"].Value);

            using(var db= new GunesMotelContext())
            {
                var emp=db.Employees.FirstOrDefault(empRow=>empRow.EmployeeID==id);
                if (emp == null) return;

                txtFullName.Text = emp.FullName;
                txtNationalID.Text = emp.NationalID;
                txtPassportID.Text = emp.PassportID;
                dtpBirthDate.Value = emp.BirthDate;
                cmbGender.SelectedItem = emp.Gender;
                txtPhone.Text = emp.Phone;
                txtEmail.Text = emp.Email;
                txtAddress.Text = emp.Address;
                cmbPosition.SelectedValue = emp.PositionID;
                txtIBAN.Text = emp.IBAN;
                dtpHireDate.Value = emp.HireDate;

                if (emp.LeaveDate.HasValue)
                {
                    dtpLeaveDate.Value = emp.LeaveDate.Value;
                    dtpLeaveDate.Checked = true;
                }
                else
                {
                    dtpLeaveDate.Checked = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployees.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen güncellenecek bir personel seçin.","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeID"].Value);

                using(var db=new GunesMotelContext())
                {
                    var employee = db.Employees.FirstOrDefault(emp => emp.EmployeeID == id);
                    if (employee == null)
                    {
                        MessageBox.Show("Seçilen personel bulunamadı.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }

                    // Güncelleme alanları
                    employee.FullName = txtFullName.Text.Trim();
                    employee.NationalID = txtNationalID.Text.Trim();
                    employee.PassportID = txtPassportID.Text.Trim();
                    employee.BirthDate = dtpBirthDate.Value;
                    employee.Gender = cmbGender.SelectedItem?.ToString();
                    employee.Phone = txtPhone.Text.Trim();
                    employee.Email = txtEmail.Text.Trim();
                    employee.Address = txtAddress.Text.Trim();
                    employee.PositionID = (int)cmbPosition.SelectedValue;
                    employee.IBAN = txtIBAN.Text.Trim();
                    employee.HireDate = dtpHireDate.Value;
                    employee.LeaveDate = (dtpLeaveDate.Checked && dtpLeaveDate.ShowCheckBox)
                                         ? (DateTime?)dtpLeaveDate.Value
                                         : null;
                    db.SaveChanges();
                }
                MessageBox.Show("Personel bilgileri başarıyla güncellendi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees();
                ClearForm();
            }
            catch(Exception ex)
            {
                string hata = ex.Message;
                if(ex.InnerException != null)
                {
                    hata += "\n" + ex.InnerException.Message;
                }
                if(ex.InnerException?.InnerException != null)
                {
                    hata += "\n" + ex.InnerException.InnerException.Message;
                }
                MessageBox.Show("Güncelleme sırasında hata oluştu:\n"+hata, "HATA",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
