
namespace VeriTabanıProjeÖdevi
{
    partial class frmMuayeneListeleme
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
            this.dataGridViewListeleme = new System.Windows.Forms.DataGridView();
            this.lblBaslık = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            this.btnAranan = new System.Windows.Forms.Button();
            this.maskedTxtTarih = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeleme)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListeleme
            // 
            this.dataGridViewListeleme.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewListeleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeleme.GridColor = System.Drawing.Color.Brown;
            this.dataGridViewListeleme.Location = new System.Drawing.Point(43, 100);
            this.dataGridViewListeleme.Name = "dataGridViewListeleme";
            this.dataGridViewListeleme.RowHeadersWidth = 51;
            this.dataGridViewListeleme.RowTemplate.Height = 24;
            this.dataGridViewListeleme.Size = new System.Drawing.Size(729, 209);
            this.dataGridViewListeleme.TabIndex = 23;
            // 
            // lblBaslık
            // 
            this.lblBaslık.AutoSize = true;
            this.lblBaslık.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslık.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBaslık.Location = new System.Drawing.Point(37, 36);
            this.lblBaslık.Name = "lblBaslık";
            this.lblBaslık.Size = new System.Drawing.Size(250, 33);
            this.lblBaslık.TabIndex = 24;
            this.lblBaslık.Text = "Muayene Listesi:";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Teal;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListele.Location = new System.Drawing.Point(43, 360);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(176, 42);
            this.btnListele.TabIndex = 25;
            this.btnListele.Text = "Tümünü Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTarih.Location = new System.Drawing.Point(337, 360);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(125, 17);
            this.lblTarih.TabIndex = 26;
            this.lblTarih.Text = "Muayene Tarihi:";
            // 
            // btnAranan
            // 
            this.btnAranan.BackColor = System.Drawing.Color.Teal;
            this.btnAranan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAranan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAranan.Location = new System.Drawing.Point(552, 360);
            this.btnAranan.Name = "btnAranan";
            this.btnAranan.Size = new System.Drawing.Size(176, 42);
            this.btnAranan.TabIndex = 27;
            this.btnAranan.Text = "Aranan Kaydı Listele";
            this.btnAranan.UseVisualStyleBackColor = false;
            this.btnAranan.Click += new System.EventHandler(this.btnAranan_Click);
            // 
            // maskedTxtTarih
            // 
            this.maskedTxtTarih.Location = new System.Drawing.Point(340, 380);
            this.maskedTxtTarih.Mask = "0000/00/00";
            this.maskedTxtTarih.Name = "maskedTxtTarih";
            this.maskedTxtTarih.Size = new System.Drawing.Size(141, 22);
            this.maskedTxtTarih.TabIndex = 36;
            this.maskedTxtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // frmMuayeneListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTxtTarih);
            this.Controls.Add(this.btnAranan);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lblBaslık);
            this.Controls.Add(this.dataGridViewListeleme);
            this.Name = "frmMuayeneListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMuayeneListeleme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeleme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListeleme;
        private System.Windows.Forms.Label lblBaslık;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Button btnAranan;
        private System.Windows.Forms.MaskedTextBox maskedTxtTarih;
    }
}