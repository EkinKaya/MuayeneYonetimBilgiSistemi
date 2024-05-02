
namespace VeriTabanıProjeÖdevi
{
    partial class frmIlacEkle
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
            this.lblBarkod = new System.Windows.Forms.Label();
            this.lblilacAd = new System.Windows.Forms.Label();
            this.lblilacTip = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtilacAd = new System.Windows.Forms.TextBox();
            this.comboBoxIlacTip = new System.Windows.Forms.ComboBox();
            this.lblBaslık = new System.Windows.Forms.Label();
            this.lblBaslikListele = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnilacEkle = new System.Windows.Forms.Button();
            this.btnilacListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarkod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBarkod.Location = new System.Drawing.Point(46, 135);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(119, 17);
            this.lblBarkod.TabIndex = 1;
            this.lblBarkod.Text = "İlaç Barkod No:";
            // 
            // lblilacAd
            // 
            this.lblilacAd.AutoSize = true;
            this.lblilacAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblilacAd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblilacAd.Location = new System.Drawing.Point(46, 195);
            this.lblilacAd.Name = "lblilacAd";
            this.lblilacAd.Size = new System.Drawing.Size(66, 17);
            this.lblilacAd.TabIndex = 2;
            this.lblilacAd.Text = "İlaç Adı:";
            // 
            // lblilacTip
            // 
            this.lblilacTip.AutoSize = true;
            this.lblilacTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblilacTip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblilacTip.Location = new System.Drawing.Point(46, 268);
            this.lblilacTip.Name = "lblilacTip";
            this.lblilacTip.Size = new System.Drawing.Size(70, 17);
            this.lblilacTip.TabIndex = 3;
            this.lblilacTip.Text = "İlaç Tipi:";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(182, 130);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(141, 22);
            this.txtBarkod.TabIndex = 9;
            // 
            // txtilacAd
            // 
            this.txtilacAd.Location = new System.Drawing.Point(182, 195);
            this.txtilacAd.Name = "txtilacAd";
            this.txtilacAd.Size = new System.Drawing.Size(141, 22);
            this.txtilacAd.TabIndex = 10;
            // 
            // comboBoxIlacTip
            // 
            this.comboBoxIlacTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIlacTip.FormattingEnabled = true;
            this.comboBoxIlacTip.Items.AddRange(new object[] {
            "Tablet",
            "Şurup",
            "Ampul",
            "Merhem",
            "Damla",
            "Sprey",
            "Draje"});
            this.comboBoxIlacTip.Location = new System.Drawing.Point(182, 261);
            this.comboBoxIlacTip.Name = "comboBoxIlacTip";
            this.comboBoxIlacTip.Size = new System.Drawing.Size(141, 24);
            this.comboBoxIlacTip.TabIndex = 19;
            // 
            // lblBaslık
            // 
            this.lblBaslık.AutoSize = true;
            this.lblBaslık.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslık.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBaslık.Location = new System.Drawing.Point(43, 44);
            this.lblBaslık.Name = "lblBaslık";
            this.lblBaslık.Size = new System.Drawing.Size(230, 33);
            this.lblBaslık.TabIndex = 20;
            this.lblBaslık.Text = "Yeni İlaç Girişi:";
            // 
            // lblBaslikListele
            // 
            this.lblBaslikListele.AutoSize = true;
            this.lblBaslikListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslikListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBaslikListele.Location = new System.Drawing.Point(403, 44);
            this.lblBaslikListele.Name = "lblBaslikListele";
            this.lblBaslikListele.Size = new System.Drawing.Size(181, 33);
            this.lblBaslikListele.TabIndex = 21;
            this.lblBaslikListele.Text = "Tüm İlaçlar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Brown;
            this.dataGridView1.Location = new System.Drawing.Point(409, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(366, 147);
            this.dataGridView1.TabIndex = 22;
            // 
            // btnilacEkle
            // 
            this.btnilacEkle.BackColor = System.Drawing.Color.Teal;
            this.btnilacEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnilacEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnilacEkle.Location = new System.Drawing.Point(49, 349);
            this.btnilacEkle.Name = "btnilacEkle";
            this.btnilacEkle.Size = new System.Drawing.Size(176, 42);
            this.btnilacEkle.TabIndex = 24;
            this.btnilacEkle.Text = "İlaç Ekle";
            this.btnilacEkle.UseVisualStyleBackColor = false;
            this.btnilacEkle.Click += new System.EventHandler(this.btnilacEkle_Click);
            // 
            // btnilacListele
            // 
            this.btnilacListele.BackColor = System.Drawing.Color.Teal;
            this.btnilacListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnilacListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnilacListele.Location = new System.Drawing.Point(409, 349);
            this.btnilacListele.Name = "btnilacListele";
            this.btnilacListele.Size = new System.Drawing.Size(176, 42);
            this.btnilacListele.TabIndex = 25;
            this.btnilacListele.Text = "İlaçları Listele";
            this.btnilacListele.UseVisualStyleBackColor = false;
            this.btnilacListele.Click += new System.EventHandler(this.btnilacListele_Click);
            // 
            // frmIlacEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnilacListele);
            this.Controls.Add(this.btnilacEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBaslikListele);
            this.Controls.Add(this.lblBaslık);
            this.Controls.Add(this.comboBoxIlacTip);
            this.Controls.Add(this.txtilacAd);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lblilacTip);
            this.Controls.Add(this.lblilacAd);
            this.Controls.Add(this.lblBarkod);
            this.Name = "frmIlacEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIlacEkle";
            this.Load += new System.EventHandler(this.frmIlacEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.Label lblilacAd;
        private System.Windows.Forms.Label lblilacTip;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.TextBox txtilacAd;
        private System.Windows.Forms.ComboBox comboBoxIlacTip;
        private System.Windows.Forms.Label lblBaslık;
        private System.Windows.Forms.Label lblBaslikListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnilacEkle;
        private System.Windows.Forms.Button btnilacListele;
    }
}