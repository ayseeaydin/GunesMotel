using GunesMotel.DataAccess.Helpers;
using GunesMotel.DataAccess.Repositories;
using GunesMotel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace GunesMotel.UI.WinForms.Control
{
    public partial class SeasonManagementControl : UserControl
    {
        private readonly SeasonRepository _seasonRepo;
        private List<Seasons> _seasonList;
        public SeasonManagementControl()
        {
            InitializeComponent();
            _seasonRepo = new SeasonRepository();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            dgvSeasons.AutoGenerateColumns = false;
            LoadSeasons();
        }

        private void LoadSeasons()
        {
            try
            {
                using (var context = new GunesMotel.DataAccess.Contexts.GunesMotelContext())
                {
                    _seasonList = context.Seasons.OrderByDescending(s => s.StartDate).ToList();
                }

                BindToGrid(_seasonList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sezonlar yüklenirken bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindToGrid(List<Seasons> list)
        {
            dgvSeasons.Rows.Clear();
            foreach (var s in list)
            {
                dgvSeasons.Rows.Add(s.SeasonID, s.SeasonName, s.StartDate.ToShortDateString(), s.EndDate.ToShortDateString(), s.Description);
            }
            dgvSeasons.ClearSelection();
        }


        private void ClearForm()
        {
            txtSeasonName.Text = "Sezon Adı";
            txtSeasonName.ForeColor = Color.Gray;

            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now.AddDays(1);

            txtDescription.Text = "Açıklama";
            txtDescription.ForeColor = Color.Gray;

            dgvSeasons.ClearSelection();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtSeasonName.Text.Trim();
                DateTime start = dtpStartDate.Value.Date;
                DateTime end = dtpEndDate.Value.Date;
                string description = txtDescription.Text.Trim();

                // Validasyon
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Lütfen sezon adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (start >= end)
                {
                    MessageBox.Show("Bitiş tarihi, başlangıç tarihinden sonra olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_seasonRepo.SeasonNameExists(name))
                {
                    MessageBox.Show("Bu isimde bir sezon zaten var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var season = new Seasons
                {
                    SeasonName = name,
                    StartDate = start,
                    EndDate = end,
                    Description = description
                };

                _seasonRepo.Add(season); // Add() zaten EF ile SaveChanges yapar

                // Log kaydı
                GunesMotel.DataAccess.Helpers.LogHelper.AddLog(
                    GunesMotel.Common.CurrentUser.UserID,
                    "Sezonlar",
                    "Ekle",
                    $"Yeni sezon eklendi: {name}"
                );

                MessageBox.Show("Sezon başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadSeasons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSeasons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSeasons.SelectedRows.Count > 0)
            {
                var row = dgvSeasons.SelectedRows[0];

                txtSeasonName.Text = row.Cells["colSeasonName"].Value?.ToString();
                dtpStartDate.Value = Convert.ToDateTime(row.Cells["colStartDate"].Value);
                dtpEndDate.Value = Convert.ToDateTime(row.Cells["colEndDate"].Value);
                txtDescription.Text = row.Cells["colDescription"].Value?.ToString();

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSeasons.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen güncellenecek sezonu seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvSeasons.SelectedRows[0];
                int seasonId = Convert.ToInt32(selectedRow.Cells["colSeasonID"].Value);

                string name = txtSeasonName.Text.Trim();
                DateTime start = dtpStartDate.Value.Date;
                DateTime end = dtpEndDate.Value.Date;
                string description = txtDescription.Text.Trim();

                // Validasyon
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Lütfen sezon adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (start >= end)
                {
                    MessageBox.Show("Bitiş tarihi, başlangıç tarihinden sonra olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var context = new GunesMotel.DataAccess.Contexts.GunesMotelContext())
                {
                    var season = context.Seasons.Find(seasonId);
                    if (season == null)
                    {
                        MessageBox.Show("Sezon bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    season.SeasonName = name;
                    season.StartDate = start;
                    season.EndDate = end;
                    season.Description = description;

                    context.SaveChanges();
                }

                // Log kaydı
                GunesMotel.DataAccess.Helpers.LogHelper.AddLog(
                    GunesMotel.Common.CurrentUser.UserID,
                    "Sezonlar",
                    "Güncelle",
                    $"Sezon güncellendi: {name}"
                );

                MessageBox.Show("Sezon başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadSeasons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSeasons.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silinecek sezonu seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var dialog = MessageBox.Show("Seçilen sezonu silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog != DialogResult.Yes)
                    return;

                var selectedRow = dgvSeasons.SelectedRows[0];
                int seasonId = Convert.ToInt32(selectedRow.Cells["colSeasonID"].Value);
                string seasonName = selectedRow.Cells["colSeasonName"].Value.ToString();

                using (var context = new GunesMotel.DataAccess.Contexts.GunesMotelContext())
                {
                    var season = context.Seasons.Find(seasonId);
                    if (season == null)
                    {
                        MessageBox.Show("Sezon bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    context.Seasons.Remove(season);
                    context.SaveChanges();
                }

                // Log kaydı
                GunesMotel.DataAccess.Helpers.LogHelper.AddLog(
                    GunesMotel.Common.CurrentUser.UserID,
                    "Sezonlar",
                    "Sil",
                    $"Sezon silindi: {seasonName}"
                );

                MessageBox.Show("Sezon başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadSeasons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                ClearForm();
                LoadSeasons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yenileme sırasında hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSeasonName_Enter(object sender, EventArgs e)
        {
            if (txtSeasonName.Text == "Sezon Adı")
            {
                txtSeasonName.Text = "";
                txtSeasonName.ForeColor = Color.Black;
            }
        }

        private void txtSeasonName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSeasonName.Text))
            {
                txtSeasonName.Text = "Sezon Adı";
                txtSeasonName.ForeColor = Color.Gray;
            }
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            if (txtDescription.Text == "Açıklama")
            {
                txtDescription.Text = "";
                txtDescription.ForeColor = Color.Black;
            }
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                txtDescription.Text = "Açıklama";
                txtDescription.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Ara")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Ara";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower().Trim();

            var filtered = _seasonList
                .Where(s =>
                    (s.SeasonName != null && s.SeasonName.ToLower().Contains(keyword)) ||
                    (s.Description != null && s.Description.ToLower().Contains(keyword)))
                .ToList();

            BindToGrid(filtered);
        }
    }
}
