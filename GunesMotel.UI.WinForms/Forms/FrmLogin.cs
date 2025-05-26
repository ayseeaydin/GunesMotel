using GunesMotel.Common;
using GunesMotel.DataAccess.Contexts;
using GunesMotel.DataAccess.Helpers;
using GunesMotel.DataAccess.Repositories;
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
    public partial class FrmLogin : Form
    {
        private readonly GunesMotelContext _context;
        public FrmLogin()
        {
            InitializeComponent();
            _context = new GunesMotelContext();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Kullanıcı adı ve şifre boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var authRepo = new AuthRepository();
                var user = authRepo.ValidateUser(username, password);

                if (user != null)
                {
                    CurrentUser.UserID = user.UserID;
                    CurrentUser.Username = user.Username;
                    CurrentUser.FullName = user.FullName;
                    CurrentUser.RoleName = user.Role.RoleName;

                    LogHelper.AddLog(user.UserID, "FrmLogin", "Giriş", $"{user.Username} adlı kullanıcı giriş yaptı.");

                    FrmMain frm = new FrmMain(); // Giriş sonrası ana panel
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Geçersiz kullanıcı adı veya şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LogHelper.AddLog(0, "FrmLogin", "Hatalı Giriş", $"'{username}' ile giriş denemesi başarısız.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
