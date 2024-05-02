
namespace VeriTabanıProjeÖdevi
{
    partial class frmReceteGoruntule
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
            this.lblTarih = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblBaslık = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.btnListeleBarkod = new System.Windows.Forms.Button();
            this.dataGridViewListeleme = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeleme)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTarih.Location = new System.Drawing.Point(30, 98);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(152, 17);
            this.lblTarih.TabIndex = 27;
            this.lblTarih.Text = "Hasta TC Kimlik No:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(33, 118);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(141, 22);
            this.txtTC.TabIndex = 33;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Teal;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListele.Location = new System.Drawing.Point(205, 98);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(176, 42);
            this.btnListele.TabIndex = 52;
            this.btnListele.Text = "Aranan Kaydı Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblBaslık
            // 
            this.lblBaslık.AutoSize = true;
            this.lblBaslık.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslık.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBaslık.Location = new System.Drawing.Point(27, 36);
            this.lblBaslık.Name = "lblBaslık";
            this.lblBaslık.Size = new System.Drawing.Size(222, 33);
            this.lblBaslık.TabIndex = 53;
            this.lblBaslık.Text = "Reçete Listesi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(417, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "İlaç Barkod No:";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(420, 118);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(141, 22);
            this.txtBarkod.TabIndex = 55;
            // 
            // btnListeleBarkod
            // 
            this.btnListeleBarkod.BackColor = System.Drawing.Color.Teal;
            this.btnListeleBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeleBarkod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListeleBarkod.Location = new System.Drawing.Point(589, 98);
            this.btnListeleBarkod.Name = "btnListeleBarkod";
            this.btnListeleBarkod.Size = new System.Drawing.Size(176, 42);
            this.btnListeleBarkod.TabIndex = 56;
            this.btnListeleBarkod.Text = "Aranan Kaydı Listele";
            this.btnListeleBarkod.UseVisualStyleBackColor = false;
            this.btnListeleBarkod.Click += new System.EventHandler(this.btnListeleBarkod_Click);
            // 
            // dataGridViewListeleme
            // 
            this.dataGridViewListeleme.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewListeleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeleme.GridColor = System.Drawing.Color.Brown;
            this.dataGridViewListeleme.Location = new System.Drawing.Point(33, 183);
            this.dataGridViewListeleme.Name = "dataGridViewListeleme";
            this.dataGridViewListeleme.RowHeadersWidth = 51;
            this.dataGridViewListeleme.RowTemplate.Height = 24;
            this.dataGridViewListeleme.Size = new System.Drawing.Size(729, 209);
            this.dataGridViewListeleme.TabIndex = 58;
            // 
            // frmReceteGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewListeleme);
            this.Controls.Add(this.btnListeleBarkod);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBaslık);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.lblTarih);
            this.Name = "frmReceteGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReceteGoruntule";
            this.Load += new System.EventHandler(this.frmReceteGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeleme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lblBaslık;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Button btnListeleBarkod;
        private System.Windows.Forms.DataGridView dataGridViewListeleme;
    }
}