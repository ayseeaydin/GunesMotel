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
    public partial class FrmGuestListDetail : Form
    {
        private int reservationId;

        public FrmGuestListDetail() 
        {
            InitializeComponent();
        }

        public FrmGuestListDetail(int reservationId)
        {
            InitializeComponent();
            this.reservationId = reservationId;
            LoadGuestDetails();
        }

        private void LoadGuestDetails()
        {
            var reservationRepo = new ReservationRepository();
            var customerRepo = new CustomerRepository();
            var reservationGuestsRepo = new ReservationGuestsRepository();

            var reservation = reservationRepo.GetById(reservationId);
            if (reservation == null)
            {
                MessageBox.Show("Rezervasyon bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ana müşteri
            var guestRows = new List<object>();
            guestRows.Add(new
            {
                AdSoyad = reservation.Customer.FullName,
                Kimlik = string.IsNullOrEmpty(reservation.Customer.NationalID) ? reservation.Customer.PassportNo : reservation.Customer.NationalID,
                Telefon = reservation.Customer.Phone,
                Tip = "Ana Misafir"
            });

            // Ek misafirler
            var extraGuests = reservationGuestsRepo.GetByReservationId(reservationId)
                .Where(g => g.CustomerID != reservation.CustomerID)
                .ToList();

            foreach (var g in extraGuests)
            {
                var c = customerRepo.GetAll().FirstOrDefault(x => x.CustomerID == g.CustomerID);
                if (c != null)
                {
                    guestRows.Add(new
                    {
                        AdSoyad = c.FullName,
                        Kimlik = string.IsNullOrEmpty(c.NationalID) ? c.PassportNo : c.NationalID,
                        Telefon = c.Phone,
                        Tip = "Ek Misafir"
                    });
                }
            }

            dgvGuests.DataSource = guestRows;
            dgvGuests.Columns["AdSoyad"].HeaderText = "Ad Soyad";
            dgvGuests.Columns["Kimlik"].HeaderText = "Kimlik/Pasaport";
            dgvGuests.Columns["Telefon"].HeaderText = "Telefon";
            dgvGuests.Columns["Tip"].HeaderText = "Tip";
            dgvGuests.ClearSelection();
        }

        public void SetGuestList(object guestList)
        {
            dgvGuests.DataSource = guestList;
            // Kolon başlıkları burada düzenlenebilir
            dgvGuests.ClearSelection();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
