
namespace VeriTabanıProjeÖdevi
{
    partial class frmMuayeneKayit
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
            this.lblMuayeneNo = new System.Windows.Forms.Label();
            this.lblTCKimlik = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSikayet = new System.Windows.Forms.Label();
            this.lblTani = new System.Windows.Forms.Label();
            this.lblTedavi = new System.Windows.Forms.Label();
            this.lblRecete = new System.Windows.Forms.Label();
            this.txtMuayeneNo = new System.Windows.Forms.TextBox();
            this.txtHastaTC = new System.Windows.Forms.TextBox();
            this.maskedTxtMuayeneTarihi = new System.Windows.Forms.MaskedTextBox();
            this.richTxtSikayet = new System.Windows.Forms.RichTextBox();
            this.txtTani = new System.Windows.Forms.TextBox();
            this.txtTedavi = new System.Windows.Forms.TextBox();
            this.txtReceteNo = new System.Windows.Forms.TextBox();
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.lblBaslık = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMuayeneNo
            // 
            this.lblMuayeneNo.AutoSize = true;
            this.lblMuayeneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMuayeneNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMuayeneNo.Location = new System.Drawing.Point(38, 121);
            this.lblMuayeneNo.Name = "lblMuayeneNo";
            this.lblMuayeneNo.Size = new System.Drawing.Size(137, 17);
            this.lblMuayeneNo.TabIndex = 1;
            this.lblMuayeneNo.Text = "Muayene Sıra No:";
            // 
            // lblTCKimlik
            // 
            this.lblTCKimlik.AutoSize = true;
            this.lblTCKimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCKimlik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTCKimlik.Location = new System.Drawing.Point(38, 188);
            this.lblTCKimlik.Name = "lblTCKimlik";
            this.lblTCKimlik.Size = new System.Drawing.Size(152, 17);
            this.lblTCKimlik.TabIndex = 2;
            this.lblTCKimlik.Text = "Hasta TC Kimlik No:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTarih.Location = new System.Drawing.Point(38, 252);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(125, 17);
            this.lblTarih.TabIndex = 3;
            this.lblTarih.Text = "Muayene Tarihi:";
            // 
            // lblSikayet
            // 
            this.lblSikayet.AutoSize = true;
            this.lblSikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSikayet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSikayet.Location = new System.Drawing.Point(38, 301);
            this.lblSikayet.Name = "lblSikayet";
            this.lblSikayet.Size = new System.Drawing.Size(117, 17);
            this.lblSikayet.TabIndex = 4;
            this.lblSikayet.Text = "Hasta Şikayeti:";
            // 
            // lblTani
            // 
            this.lblTani.AutoSize = true;
            this.lblTani.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTani.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTani.Location = new System.Drawing.Point(478, 188);
            this.lblTani.Name = "lblTani";
            this.lblTani.Size = new System.Drawing.Size(45, 17);
            this.lblTani.TabIndex = 5;
            this.lblTani.Text = "Tanı:";
            // 
            // lblTedavi
            // 
            this.lblTedavi.AutoSize = true;
            this.lblTedavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTedavi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTedavi.Location = new System.Drawing.Point(478, 252);
            this.lblTedavi.Name = "lblTedavi";
            this.lblTedavi.Size = new System.Drawing.Size(129, 17);
            this.lblTedavi.TabIndex = 6;
            this.lblTedavi.Text = "Önerilen Tedavi:";
            // 
            // lblRecete
            // 
            this.lblRecete.AutoSize = true;
            this.lblRecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRecete.Location = new System.Drawing.Point(478, 306);
            this.lblRecete.Name = "lblRecete";
            this.lblRecete.Size = new System.Drawing.Size(89, 17);
            this.lblRecete.TabIndex = 7;
            this.lblRecete.Text = "Reçete No:";
            // 
            // txtMuayeneNo
            // 
            this.txtMuayeneNo.Location = new System.Drawing.Point(198, 116);
            this.txtMuayeneNo.Name = "txtMuayeneNo";
            this.txtMuayeneNo.Size = new System.Drawing.Size(141, 22);
            this.txtMuayeneNo.TabIndex = 9;
            // 
            // txtHastaTC
            // 
            this.txtHastaTC.Location = new System.Drawing.Point(198, 183);
            this.txtHastaTC.Name = "txtHastaTC";
            this.txtHastaTC.Size = new System.Drawing.Size(141, 22);
            this.txtHastaTC.TabIndex = 10;
            // 
            // maskedTxtMuayeneTarihi
            // 
            this.maskedTxtMuayeneTarihi.Location = new System.Drawing.Point(198, 247);
            this.maskedTxtMuayeneTarihi.Mask = "0000/00/00";
            this.maskedTxtMuayeneTarihi.Name = "maskedTxtMuayeneTarihi";
            this.maskedTxtMuayeneTarihi.Size = new System.Drawing.Size(141, 22);
            this.maskedTxtMuayeneTarihi.TabIndex = 36;
            this.maskedTxtMuayeneTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // richTxtSikayet
            // 
            this.richTxtSikayet.Location = new System.Drawing.Point(198, 301);
            this.richTxtSikayet.Name = "richTxtSikayet";
            this.richTxtSikayet.Size = new System.Drawing.Size(216, 67);
            this.richTxtSikayet.TabIndex = 37;
            this.richTxtSikayet.Text = "";
            // 
            // txtTani
            // 
            this.txtTani.Location = new System.Drawing.Point(613, 188);
            this.txtTani.Name = "txtTani";
            this.txtTani.Size = new System.Drawing.Size(141, 22);
            this.txtTani.TabIndex = 38;
            // 
            // txtTedavi
            // 
            this.txtTedavi.Location = new System.Drawing.Point(613, 247);
            this.txtTedavi.Name = "txtTedavi";
            this.txtTedavi.Size = new System.Drawing.Size(141, 22);
            this.txtTedavi.TabIndex = 39;
            // 
            // txtReceteNo
            // 
            this.txtReceteNo.Location = new System.Drawing.Point(613, 301);
            this.txtReceteNo.Name = "txtReceteNo";
            this.txtReceteNo.Size = new System.Drawing.Size(141, 22);
            this.txtReceteNo.TabIndex = 40;
            this.txtReceteNo.Text = "0";
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.BackColor = System.Drawing.Color.Teal;
            this.btnHastaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHastaEkle.Location = new System.Drawing.Point(578, 355);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(176, 42);
            this.btnHastaEkle.TabIndex = 41;
            this.btnHastaEkle.Text = "Randevu Ekle";
            this.btnHastaEkle.UseVisualStyleBackColor = false;
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
            // 
            // lblBaslık
            // 
            this.lblBaslık.AutoSize = true;
            this.lblBaslık.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslık.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBaslık.Location = new System.Drawing.Point(35, 46);
            this.lblBaslık.Name = "lblBaslık";
            this.lblBaslık.Size = new System.Drawing.Size(428, 33);
            this.lblBaslık.TabIndex = 42;
            this.lblBaslık.Text = "Muayene Randevusu Ekleme:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VeriTabanıProjeÖdevi.Properties.Resources._2272129_810x458;
            this.pictureBox1.Location = new System.Drawing.Point(511, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // frmMuayeneKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBaslık);
            this.Controls.Add(this.btnHastaEkle);
            this.Controls.Add(this.txtReceteNo);
            this.Controls.Add(this.txtTedavi);
            this.Controls.Add(this.txtTani);
            this.Controls.Add(this.richTxtSikayet);
            this.Controls.Add(this.maskedTxtMuayeneTarihi);
            this.Controls.Add(this.txtHastaTC);
            this.Controls.Add(this.txtMuayeneNo);
            this.Controls.Add(this.lblRecete);
            this.Controls.Add(this.lblTedavi);
            this.Controls.Add(this.lblTani);
            this.Controls.Add(this.lblSikayet);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblTCKimlik);
            this.Controls.Add(this.lblMuayeneNo);
            this.Name = "frmMuayeneKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMuayeneKayit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMuayeneNo;
        private System.Windows.Forms.Label lblTCKimlik;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSikayet;
        private System.Windows.Forms.Label lblTani;
        private System.Windows.Forms.Label lblTedavi;
        private System.Windows.Forms.Label lblRecete;
        private System.Windows.Forms.TextBox txtMuayeneNo;
        private System.Windows.Forms.TextBox txtHastaTC;
        private System.Windows.Forms.MaskedTextBox maskedTxtMuayeneTarihi;
        private System.Windows.Forms.RichTextBox richTxtSikayet;
        private System.Windows.Forms.TextBox txtTani;
        private System.Windows.Forms.TextBox txtTedavi;
        private System.Windows.Forms.TextBox txtReceteNo;
        private System.Windows.Forms.Button btnHastaEkle;
        private System.Windows.Forms.Label lblBaslık;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}