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

namespace GunesMotel.UI.WinForms.Control
{
    public partial class AddCustomerControl : UserControl
    {
        public AddCustomerControl()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            var repo = new CustomerRepository();
            var customerList = repo.GetAll();

            dgvCustomers.DataSource = customerList;

            if (dgvCustomers.Columns["CustomerID"] != null)
                dgvCustomers.Columns["CustomerID"].Visible = false;

            if (dgvCustomers.Columns["Notes"] != null)
                dgvCustomers.Columns["Notes"].Visible = false;

            if (dgvCustomers.Columns["Reservations"] != null)
                dgvCustomers.Columns["Reservations"].Visible = false;
        }
    }
}
