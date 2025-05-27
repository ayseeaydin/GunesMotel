using GunesMotel.DataAccess.Repositories;
using GunesMotel.UI.WinForms.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunesMotel.UI.WinForms.Forms
{
    public partial class FrmAdminDashboard : Form
    {
        public FrmAdminDashboard()
        {
            InitializeComponent();
        }

        private void FrmAdminDashboard_Load(object sender, EventArgs e)
        {
            lblUserName.Text = GunesMotel.Common.CurrentUser.FullName;

            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=GunesMotel;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Rooms", conn);
                lblRoomsTotal.Text = cmd1.ExecuteScalar().ToString();

                SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Customers", conn);
                lblCustomersTotal.Text = cmd2.ExecuteScalar().ToString();

                SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM Reservations WHERE CheckInDate <= GETDATE() AND CheckOutDate >= GETDATE()", conn);
                lblReservationsTotal.Text = cmd3.ExecuteScalar().ToString();

                SqlCommand cmd4 = new SqlCommand(@"
            SELECT SUM(ii.UnitPrice * ii.Quantity) 
            FROM InvoiceItems ii
            JOIN Invoices i ON ii.InvoiceID = i.InvoiceID
            WHERE i.InvoiceDate = CAST(GETDATE() AS DATE)", conn);
                var income = cmd4.ExecuteScalar();
                lblRevenueAmount.Text = income != DBNull.Value ? ((decimal)income).ToString("N2") + " ₺" : "0 ₺";

                SqlCommand cmd5 = new SqlCommand("SELECT COUNT(*) FROM Reservations WHERE CheckInDate = CAST(GETDATE() AS DATE)", conn);
                int checkInCount = (int)cmd5.ExecuteScalar();

                lblStatus.Text = $"{lblReservationsTotal.Text} aktif rezervasyon, {checkInCount} bugün check-in var";
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadContent(System.Windows.Forms.Control control)
        {
            pnlContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(control);
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            var employeeControl = new EmployeeManagementControl();

            // Event yakalanıyor:
            employeeControl.OnPozisyonYonet += (s, args) =>
            {
                lblFormTitle.Text = "Pozisyon Yönetimi";
                LoadContent(new PositionManagementControl());
            };

            LoadContent(employeeControl);
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            var userControl = new UserManagementControl();
            userControl.OnRolYonet += (s, args) =>
            {
                lblFormTitle.Text = "Rol Yönetimi";
                LoadContent(new RoleManagementControl());
            };
            LoadContent(userControl);
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            var roomTypeControl = new RoomTypeManagementControl();
            LoadContent(roomTypeControl);
        }
    }
}
