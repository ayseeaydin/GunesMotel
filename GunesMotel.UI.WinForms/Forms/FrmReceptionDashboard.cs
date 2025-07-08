using GunesMotel.Common;
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
using System.Data.Entity;
using GunesMotel.UI.WinForms.Control;
using GunesMotel.DataAccess.Repositories;
using GunesMotel.Entities.DTOs;

namespace GunesMotel.UI.WinForms.Forms
{
    public partial class FrmReceptionDashboard : Form
    {
        public FrmReceptionDashboard()
        {
            InitializeComponent();
        }

        private void FrmReceptionDashboard_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
            LoadUserControl(new ReceptionDashboardContentControl());
            UpdateFooter();
        }

        private void LoadUserControl(UserControl control)
        {
            pnlContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(control);
        }

        private void LoadUserInfo()
        {
            lblUserName.Text = CurrentUser.Username;
        }

        private void UpdateFooter()
        {
            using (var context = new GunesMotelContext())
            {
                int aktifRezervasyon = context.Reservations.Count(r => r.Status == "Check-in");
                int bekleyenIslem = context.Reservations.Count(r => r.Status == "Beklemede");
                lblStatus.Text = $"Durum: {aktifRezervasyon} aktif rezervasyon, {bekleyenIslem} bekleyen işlem";
                lblLastUpdate.Text = "Son Güncelleme: " + DateTime.Now.ToString("dd MMMM yyyy, HH:mm");
            }
        }

        private void btnOdaDurumu_Click(object sender, EventArgs e)
        {
            LoadUserControl(new RoomStatusControl());
        }
        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AddCustomerControl());
        }      

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRezervasyonlar_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ReservationManagementControl());
        }

        private void btnCheckinOut_Click(object sender, EventArgs e)
        {
            LoadUserControl(new CheckInOutControl());
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ReceptionDashboardContentControl());
        }

        private void btnFaturaYonetimi_Click(object sender, EventArgs e)
        {
            try
            {
                pnlContent.Controls.Clear();

                var invoiceControl = new Control.InvoiceManagementControl();
                invoiceControl.Dock = DockStyle.Fill;

                pnlContent.Controls.Add(invoiceControl);

                // Form başlığını güncelle
                lblFormTitle.Text = "Fatura Yönetimi";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fatura yönetimi açılırken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
