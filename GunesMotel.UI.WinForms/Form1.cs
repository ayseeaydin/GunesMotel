using System;
using System.Windows.Forms;
using GunesMotel.DataAccess.Contexts;
using GunesMotel.DataAccess.Repositories;
using GunesMotel.Entities;

namespace GunesMotel.UI.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnGetPositions_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new GunesMotelContext())
                {
                    var repo = new GenericRepository<Positions>(context);
                    var positions = repo.GetAll();
                    dgvPositions.DataSource = positions;
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
