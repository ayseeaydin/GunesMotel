namespace GunesMotel.UI.WinForms.Control
{
    partial class RoomStatusControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbKatlar;
        private System.Windows.Forms.Label lblKatSec;
        private System.Windows.Forms.FlowLayoutPanel flpRooms;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Label lblBos;
        private System.Windows.Forms.Label lblDolu;
        private System.Windows.Forms.Label lblTemizlikte;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbKatlar = new System.Windows.Forms.ComboBox();
            this.lblKatSec = new System.Windows.Forms.Label();
            this.flpRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.lblBos = new System.Windows.Forms.Label();
            this.lblDolu = new System.Windows.Forms.Label();
            this.lblTemizlikte = new System.Windows.Forms.Label();
            this.pnlLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKatlar
            // 
            this.cmbKatlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKatlar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbKatlar.FormattingEnabled = true;
            this.cmbKatlar.Location = new System.Drawing.Point(120, 13);
            this.cmbKatlar.Name = "cmbKatlar";
            this.cmbKatlar.Size = new System.Drawing.Size(100, 31);
            this.cmbKatlar.TabIndex = 0;
            this.cmbKatlar.SelectedIndexChanged += new System.EventHandler(this.cmbKatlar_SelectedIndexChanged);
            // 
            // lblKatSec
            // 
            this.lblKatSec.AutoSize = true;
            this.lblKatSec.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblKatSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblKatSec.Location = new System.Drawing.Point(20, 15);
            this.lblKatSec.Name = "lblKatSec";
            this.lblKatSec.Size = new System.Drawing.Size(81, 25);
            this.lblKatSec.TabIndex = 0;
            this.lblKatSec.Text = "Kat Seç:";
            // 
            // flpRooms
            // 
            this.flpRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpRooms.AutoScroll = true;
            this.flpRooms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpRooms.Location = new System.Drawing.Point(20, 55);
            this.flpRooms.Name = "flpRooms";
            this.flpRooms.Padding = new System.Windows.Forms.Padding(5);
            this.flpRooms.Size = new System.Drawing.Size(784, 355);
            this.flpRooms.TabIndex = 2;
            // 
            // pnlLegend
            // 
            this.pnlLegend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLegend.BackColor = System.Drawing.Color.White;
            this.pnlLegend.Controls.Add(this.lblBos);
            this.pnlLegend.Controls.Add(this.lblDolu);
            this.pnlLegend.Controls.Add(this.lblTemizlikte);
            this.pnlLegend.Location = new System.Drawing.Point(521, 9);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(300, 35);
            this.pnlLegend.TabIndex = 1;
            // 
            // lblBos
            // 
            this.lblBos.AutoSize = true;
            this.lblBos.Location = new System.Drawing.Point(10, 10);
            this.lblBos.Name = "lblBos";
            this.lblBos.Size = new System.Drawing.Size(46, 16);
            this.lblBos.TabIndex = 0;
            this.lblBos.Text = "🟩 Boş";
            // 
            // lblDolu
            // 
            this.lblDolu.AutoSize = true;
            this.lblDolu.Location = new System.Drawing.Point(90, 10);
            this.lblDolu.Name = "lblDolu";
            this.lblDolu.Size = new System.Drawing.Size(50, 16);
            this.lblDolu.TabIndex = 1;
            this.lblDolu.Text = "🟥 Dolu";
            // 
            // lblTemizlikte
            // 
            this.lblTemizlikte.AutoSize = true;
            this.lblTemizlikte.Location = new System.Drawing.Point(170, 10);
            this.lblTemizlikte.Name = "lblTemizlikte";
            this.lblTemizlikte.Size = new System.Drawing.Size(83, 16);
            this.lblTemizlikte.TabIndex = 2;
            this.lblTemizlikte.Text = "🟨 Temizlikte";
            // 
            // RoomStatusControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblKatSec);
            this.Controls.Add(this.cmbKatlar);
            this.Controls.Add(this.pnlLegend);
            this.Controls.Add(this.flpRooms);
            this.Name = "RoomStatusControl";
            this.Size = new System.Drawing.Size(824, 435);
            this.pnlLegend.ResumeLayout(false);
            this.pnlLegend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
