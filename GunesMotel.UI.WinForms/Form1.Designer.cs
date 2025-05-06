namespace GunesMotel.UI.WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPositions = new System.Windows.Forms.DataGridView();
            this.btnGetPositions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPositions
            // 
            this.dgvPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositions.Location = new System.Drawing.Point(12, 12);
            this.dgvPositions.Name = "dgvPositions";
            this.dgvPositions.RowHeadersWidth = 51;
            this.dgvPositions.RowTemplate.Height = 24;
            this.dgvPositions.Size = new System.Drawing.Size(384, 298);
            this.dgvPositions.TabIndex = 0;
            // 
            // btnGetPositions
            // 
            this.btnGetPositions.Location = new System.Drawing.Point(363, 332);
            this.btnGetPositions.Name = "btnGetPositions";
            this.btnGetPositions.Size = new System.Drawing.Size(124, 40);
            this.btnGetPositions.TabIndex = 1;
            this.btnGetPositions.Text = "button1";
            this.btnGetPositions.UseVisualStyleBackColor = true;
            this.btnGetPositions.Click += new System.EventHandler(this.btnGetPositions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetPositions);
            this.Controls.Add(this.dgvPositions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPositions;
        private System.Windows.Forms.Button btnGetPositions;
    }
}

