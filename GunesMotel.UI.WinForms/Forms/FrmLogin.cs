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
using System.Configuration;
using Configuration = System.Configuration.Configuration;

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
                string password = txtPassword.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Kullanıcı adı ve şifre boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var authRepo = new AuthRepository();
                var user = authRepo.ValidateUser(username, password);

                if (user == null)
                {
                    MessageBox.Show("Geçersiz kullanıcı adı veya şifre.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LogHelper.AddLog(0, "FrmLogin", "Geçersiz Giriş", $"Hatalı giriş denemesi: {username}");
                    return;
                }

                CurrentUser.UserID = user.UserID;
                CurrentUser.Username = user.Username;
                CurrentUser.RoleName = user.Role.RoleName;
                CurrentUser.FullName = user.FullName;

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.AppSettings.Settings["RememberMe"].Value = chkRememberMe.Checked ? "true" : "false";
                config.AppSettings.Settings["SavedUsername"].Value = chkRememberMe.Checked ? txtUsername.Text.Trim() : "";
                config.AppSettings.Settings["SavedPassword"].Value = chkRememberMe.Checked ? txtPassword.Text.Trim() : "";

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                LogHelper.AddLog(user.UserID, "FrmLogin", "Giriş", $"{user.Username} adlı kullanıcı giriş yaptı.");

                this.Hide();

                if (CurrentUser.RoleName == "Yönetici")
                {
                    FrmAdminDashboard adminForm = new FrmAdminDashboard();
                    adminForm.Show();
                }
                else if (CurrentUser.RoleName == "Resepsiyon")
                {
                    FrmReceptionDashboard receptionForm = new FrmReceptionDashboard();
                    receptionForm.Show();
                }
                else
                {
                    MessageBox.Show("Yetkiniz dahilinde bir panel tanımlı değil.", "Yetkisiz Erişim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Bir hata oluştu. Lütfen sistem yöneticinize başvurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //LogHelper.AddLog(0, "FrmLogin", "Hata", $"Giriş sırasında hata oluştu: {ex.Message}");
                //System.Diagnostics.Debug.WriteLine(ex);


                MessageBox.Show("Bir hata oluştu:\n\n" + ex.ToString(), "Hata Detayı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.AddLog(0, "FrmLogin", "Hata", $"Giriş sırasında hata oluştu: {ex.Message}");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                string remember = ConfigurationManager.AppSettings["RememberMe"];
                if (remember == "true")
                {
                    txtUsername.Text = ConfigurationManager.AppSettings["SavedUsername"];
                    txtPassword.Text = ConfigurationManager.AppSettings["SavedPassword"];
                    chkRememberMe.Checked = true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("RememberMe yüklenemedi: " + ex.Message);
            }
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Şifre sıfırlama işlemi yalnızca sistem yöneticileri tarafından yapılabilir.\nLütfen resepsiyona veya yöneticinize başvurun.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
