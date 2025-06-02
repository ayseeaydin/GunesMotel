using GunesMotel.DataAccess.Contexts;
using GunesMotel.DataAccess.Repositories;
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

namespace GunesMotel.UI.WinForms.Control
{
    public partial class RoomManagementControl : UserControl
    {
        private readonly RoomTypeRepository _roomTypeRepo = new RoomTypeRepository();
        private readonly RoomRepository _roomRepo = new RoomRepository();

        public RoomManagementControl()
        {
            InitializeComponent();
            LoadRoonTypes();
            LoadRooms();
        }

        private void LoadRoonTypes()
        {
            try
            {
                var types = _roomTypeRepo.GetAll();
                cmbRoomType.DataSource = types;
                cmbRoomType.DisplayMember = "TypeName";
                cmbRoomType.ValueMember = "RoomTypeID";
                cmbRoomType.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda türleri yüklenirken hata oluştu:\n" + ex.Message);
            }
        }

        private void LoadRooms()
        {
            try
            {
                using (var context = new GunesMotelContext())
                {
                    var roomList = (from r in context.Rooms
                                    join rt in context.RoomTypes on r.RoomTypeID equals rt.RoomTypeID
                                    select new
                                    {
                                        r.RoomID,
                                        r.RoomNumber,
                                        rt.TypeName,
                                        rt.Feature,
                                        r.Floor,
                                        r.Status,
                                        r.Description
                                    }).OrderByDescending(x => x.RoomID).ToList();

                    dgvRooms.DataSource = null;
                    dgvRooms.DataSource = roomList;
                    dgvRooms.ClearSelection();
                    if (dgvRooms.Columns.Contains("RoomID") && dgvRooms.Columns["RoomID"] != null)
                        dgvRooms.Columns["RoomID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Odalar yüklenirken hata oluştu:\n" + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var room = new Rooms
                {
                    RoomNumber = txtRoomNumber.Text.Trim(),
                    RoomTypeID = Convert.ToInt32(cmbRoomType.SelectedValue),
                    Floor = Convert.ToInt32(txtFloor.Text),
                    Status = cmbStatus.SelectedItem?.ToString(),
                    Description = txtDescription.Text.Trim()
                };

                _roomRepo.Add(room);
                LoadRooms();
                MessageBox.Show("Oda başarıyla eklendi.");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda eklenirken hata oluştu:\n" + ex.Message);
            }
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRooms.SelectedRows.Count == 0)
                return;
            var selectedRow = dgvRooms.SelectedRows[0];

            txtRoomNumber.Text = selectedRow.Cells["colRoomNumber"].Value?.ToString();
            txtFloor.Text = selectedRow.Cells["colFloor"].Value?.ToString();
            cmbRoomType.Text = selectedRow.Cells["colRoomTypeName"].Value?.ToString();
            cmbStatus.Text = selectedRow.Cells["colStatus"].Value?.ToString();
            txtDescription.Text = selectedRow.Cells["colDescription"].Value?.ToString();
        }
    }
}
