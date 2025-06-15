using GunesMotel.DataAccess.Repositories;
using GunesMotel.UI.WinForms.Forms;
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
    public partial class CheckInOutControl : UserControl
    {
        public CheckInOutControl()
        {
            InitializeComponent();
        }

        private void LoadTodayCheckIns()
        {
            try
            {
                var repo = new ReservationRepository();
                var today = DateTime.Today;

                var checkInList = repo.GetAll()
                    .Where(r => r.CheckInDate.Date == today && r.Status != "Check-in")
                    .Select(r => new
                    {
                        r.ReservationID,
                        Customer = r.Customer.FullName,
                        Room = r.Room.RoomNumber,
                        r.CheckInDate,
                        r.CheckOutDate,
                        r.Status,
                        r.Source
                    })
                    .ToList();

                dgvTodayCheckIns.DataSource = checkInList;
                lblCheckInCount.Text = $"✅ Bugün giriş yapacak: {checkInList.Count} misafir";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check-in listesi yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckInOutControl_Load(object sender, EventArgs e)
        {
            LoadTodayCheckIns();
        }

        private void btnPerformCheckIn_Click(object sender, EventArgs e)
        {
            FrmGuestEntry guestForm = new FrmGuestEntry();
            guestForm.ShowDialog();
        }
    }
}
