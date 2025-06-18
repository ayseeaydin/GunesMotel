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
            try
            {
                if (dgvTodayCheckIns.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen check-in yapılacak rezervasyonu seçin.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvTodayCheckIns.SelectedRows[0];
                int reservationId = Convert.ToInt32(selectedRow.Cells["ReservationID"].Value);

                var reservationRepo = new ReservationRepository();
                var selectedReservation = reservationRepo.GetById(reservationId);

                if (selectedReservation == null)
                {
                    MessageBox.Show("Rezervasyon bulunamadı.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Test formunu aç
                var checkInForm = new FrmCheckInGuestManagement(selectedReservation);
                checkInForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
