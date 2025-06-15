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

namespace GunesMotel.UI.WinForms.Forms
{
    public partial class FrmGuestEntry : Form
    {
        public FrmGuestEntry()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = txtSearchGuest.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Lütfen arama için TC Kimlik No veya Pasaport No giriniz.");
                return;
            }

            using (var db = new GunesMotelContext())
            {
                var guest = db.Customers
                    .FirstOrDefault(c => c.NationalID == input || c.PassportNo == input);

                if (guest != null)
                {
                    txtFirstName.Text = guest.FullName.Split(' ')[0];
                    txtLastName.Text = guest.FullName.Contains(" ") ? guest.FullName.Substring(guest.FullName.IndexOf(' ') + 1) : "";
                    txtIDNumber.Text = guest.NationalID;
                    txtPassportNumber.Text = guest.PassportNo;
                    txtEmail.Text = guest.Email;
                    txtPhone.Text = guest.Phone;
                    txtAddress.Text = guest.Address;
                    // txtCountry, txtCity alanları yoksa ayrı olarak veritabanında ayrıştırılamaz
                }
                else
                {
                    MessageBox.Show("Kayıtlı misafir bulunamadı. Yeni giriş yapabilirsiniz.");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new GunesMotelContext())
            {
                string idNo = txtIDNumber.Text.Trim();
                string passport = txtPassportNumber.Text.Trim();

                var existing = db.Customers.FirstOrDefault(c =>
                    (!string.IsNullOrEmpty(idNo) && c.NationalID == idNo) ||
                    (!string.IsNullOrEmpty(passport) && c.PassportNo == passport));

                if (existing != null)
                {
                    MessageBox.Show("Bu misafir zaten sistemde kayıtlı.");
                    return;
                }

                Customers newGuest = new Customers
                {
                    FullName = $"{txtFirstName.Text.Trim()} {txtLastName.Text.Trim()}",
                    NationalID = idNo,
                    PassportNo = passport,
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Gender = "", // isteğe göre eklenecekse combobox
                    RegisterDate = DateTime.Now,
                    Notes = ""
                };

                db.Customers.Add(newGuest);
                db.SaveChanges();

                MessageBox.Show("Misafir başarıyla kaydedildi.");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
