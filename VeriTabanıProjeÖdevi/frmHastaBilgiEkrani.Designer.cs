
namespace VeriTabanıProjeÖdevi
{
    partial class frmHastaBilgiEkrani
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
            this.lblTCKimlik = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.lblBaslık = new System.Windows.Forms.Label();
            this.btnAranan = new System.Windows.Forms.Button();
            this.dataGridViewListeleme = new System.Windows.Forms.DataGridView();
            this.dataGridViewMuayene = new System.Windows.Forms.DataGridView();
            this.lblMuayeneBilgi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuayene)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTCKimlik
            // 
            this.lblTCKimlik.AutoSize = true;
            this.lblTCKimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCKimlik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTCKimlik.Location = new System.Drawing.Point(44, 89);
            this.lblTCKimlik.Name = "lblTCKimlik";
            this.lblTCKimlik.Size = new System.Drawing.Size(152, 17);
            this.lblTCKimlik.TabIndex = 27;
            this.lblTCKimlik.Text = "Hasta TC Kimlik No:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(47, 109);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(141, 22);
            this.txtTC.TabIndex = 29;
            // 
            // lblBaslık
            // 
            this.lblBaslık.AutoSize = true;
            this.lblBaslık.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslık.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBaslık.Location = new System.Drawing.Point(41, 35);
            this.lblBaslık.Name = "lblBaslık";
            this.lblBaslık.Size = new System.Drawing.Size(195, 33);
            this.lblBaslık.TabIndex = 30;
            this.lblBaslık.Text = "Hasta Profili:";
            // 
            // btnAranan
            // 
            this.btnAranan.BackColor = System.Drawing.Color.Teal;
            this.btnAranan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAranan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAranan.Location = new System.Drawing.Point(300, 89);
            this.btnAranan.Name = "btnAranan";
            this.btnAranan.Size = new System.Drawing.Size(206, 42);
            this.btnAranan.TabIndex = 31;
            this.btnAranan.Text = "Aranan Hastayı Listele";
            this.btnAranan.UseVisualStyleBackColor = false;
            this.btnAranan.Click += new System.EventHandler(this.btnAranan_Click);
            // 
            // dataGridViewListeleme
            // 
            this.dataGridViewListeleme.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewListeleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeleme.GridColor = System.Drawing.Color.Brown;
            this.dataGridViewListeleme.Location = new System.Drawing.Point(47, 158);
            this.dataGridViewListeleme.Name = "dataGridViewListeleme";
            this.dataGridViewListeleme.RowHeadersWidth = 51;
            this.dataGridViewListeleme.RowTemplate.Height = 24;
            this.dataGridViewListeleme.Size = new System.Drawing.Size(729, 74);
            this.dataGridViewListeleme.TabIndex = 32;
            // 
            // dataGridViewMuayene
            // 
            this.dataGridViewMuayene.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMuayene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMuayene.GridColor = System.Drawing.Color.Brown;
            this.dataGridViewMuayene.Location = new System.Drawing.Point(47, 316);
            this.dataGridViewMuayene.Name = "dataGridViewMuayene";
            this.dataGridViewMuayene.RowHeadersWidth = 51;
            this.dataGridViewMuayene.RowTemplate.Height = 24;
            this.dataGridViewMuayene.Size = new System.Drawing.Size(729, 74);
            this.dataGridViewMuayene.TabIndex = 33;
            // 
            // lblMuayeneBilgi
            // 
            this.lblMuayeneBilgi.AutoSize = true;
            this.lblMuayeneBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMuayeneBilgi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMuayeneBilgi.Location = new System.Drawing.Point(43, 283);
            this.lblMuayeneBilgi.Name = "lblMuayeneBilgi";
            this.lblMuayeneBilgi.Size = new System.Drawing.Size(111, 20);
            this.lblMuayeneBilgi.TabIndex = 35;
            this.lblMuayeneBilgi.Text = "Muayeneler:";
            // 
            // frmHastaBilgiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMuayeneBilgi);
            this.Controls.Add(this.dataGridViewMuayene);
            this.Controls.Add(this.dataGridViewListeleme);
            this.Controls.Add(this.btnAranan);
            this.Controls.Add(this.lblBaslık);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.lblTCKimlik);
            this.Name = "frmHastaBilgiEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHastaBilgiEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuayene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTCKimlik;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label lblBaslık;
        private System.Windows.Forms.Button btnAranan;
        private System.Windows.Forms.DataGridView dataGridViewListeleme;
        private System.Windows.Forms.DataGridView dataGridViewMuayene;
        private System.Windows.Forms.Label lblMuayeneBilgi;
    }
}