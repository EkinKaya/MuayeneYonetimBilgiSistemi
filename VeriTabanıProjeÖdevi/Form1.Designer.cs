
namespace VeriTabanıProjeÖdevi
{
    partial class frmMenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastaKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayeneKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaBilgileriniGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reçeteYazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reçeteleriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayeneleriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Brown;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKayıtToolStripMenuItem,
            this.doktorİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaKayıtToolStripMenuItem
            // 
            this.hastaKayıtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKaydıToolStripMenuItem,
            this.muayeneKaydıToolStripMenuItem});
            this.hastaKayıtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.hastaKayıtToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hastaKayıtToolStripMenuItem.Name = "hastaKayıtToolStripMenuItem";
            this.hastaKayıtToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.hastaKayıtToolStripMenuItem.Text = "Sekreter İşlemleri";
            // 
            // hastaKaydıToolStripMenuItem
            // 
            this.hastaKaydıToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.hastaKaydıToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hastaKaydıToolStripMenuItem.Name = "hastaKaydıToolStripMenuItem";
            this.hastaKaydıToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.hastaKaydıToolStripMenuItem.Text = "Hasta Ekleme";
            this.hastaKaydıToolStripMenuItem.Click += new System.EventHandler(this.hastaKaydıToolStripMenuItem_Click);
            // 
            // muayeneKaydıToolStripMenuItem
            // 
            this.muayeneKaydıToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.muayeneKaydıToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.muayeneKaydıToolStripMenuItem.Name = "muayeneKaydıToolStripMenuItem";
            this.muayeneKaydıToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.muayeneKaydıToolStripMenuItem.Text = "Muayene Kaydı";
            this.muayeneKaydıToolStripMenuItem.Click += new System.EventHandler(this.muayeneKaydıToolStripMenuItem_Click);
            // 
            // doktorİşlemleriToolStripMenuItem
            // 
            this.doktorİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaEklemeToolStripMenuItem,
            this.hastaBilgileriniGörüntüleToolStripMenuItem,
            this.reçeteYazToolStripMenuItem,
            this.reçeteleriGörüntüleToolStripMenuItem,
            this.ilaçEkleToolStripMenuItem,
            this.muayeneleriGörüntüleToolStripMenuItem});
            this.doktorİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.doktorİşlemleriToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doktorİşlemleriToolStripMenuItem.Name = "doktorİşlemleriToolStripMenuItem";
            this.doktorİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.doktorİşlemleriToolStripMenuItem.Text = "Doktor İşlemleri";
            // 
            // hastaEklemeToolStripMenuItem
            // 
            this.hastaEklemeToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.hastaEklemeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hastaEklemeToolStripMenuItem.Name = "hastaEklemeToolStripMenuItem";
            this.hastaEklemeToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.hastaEklemeToolStripMenuItem.Text = "Hasta Ekleme";
            this.hastaEklemeToolStripMenuItem.Click += new System.EventHandler(this.hastaEklemeToolStripMenuItem_Click);
            // 
            // hastaBilgileriniGörüntüleToolStripMenuItem
            // 
            this.hastaBilgileriniGörüntüleToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.hastaBilgileriniGörüntüleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hastaBilgileriniGörüntüleToolStripMenuItem.Name = "hastaBilgileriniGörüntüleToolStripMenuItem";
            this.hastaBilgileriniGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.hastaBilgileriniGörüntüleToolStripMenuItem.Text = "Hasta Bilgilerini Görüntüle";
            this.hastaBilgileriniGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.hastaBilgileriniGörüntüleToolStripMenuItem_Click);
            // 
            // reçeteYazToolStripMenuItem
            // 
            this.reçeteYazToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.reçeteYazToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reçeteYazToolStripMenuItem.Name = "reçeteYazToolStripMenuItem";
            this.reçeteYazToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.reçeteYazToolStripMenuItem.Text = "Reçete Yaz";
            this.reçeteYazToolStripMenuItem.Click += new System.EventHandler(this.reçeteYazToolStripMenuItem_Click);
            // 
            // reçeteleriGörüntüleToolStripMenuItem
            // 
            this.reçeteleriGörüntüleToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.reçeteleriGörüntüleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reçeteleriGörüntüleToolStripMenuItem.Name = "reçeteleriGörüntüleToolStripMenuItem";
            this.reçeteleriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.reçeteleriGörüntüleToolStripMenuItem.Text = "Reçeteleri Görüntüle";
            this.reçeteleriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.reçeteleriGörüntüleToolStripMenuItem_Click);
            // 
            // ilaçEkleToolStripMenuItem
            // 
            this.ilaçEkleToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.ilaçEkleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ilaçEkleToolStripMenuItem.Name = "ilaçEkleToolStripMenuItem";
            this.ilaçEkleToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.ilaçEkleToolStripMenuItem.Text = "İlaç Ekle / Görüntüle";
            this.ilaçEkleToolStripMenuItem.Click += new System.EventHandler(this.ilaçEkleToolStripMenuItem_Click);
            // 
            // muayeneleriGörüntüleToolStripMenuItem
            // 
            this.muayeneleriGörüntüleToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.muayeneleriGörüntüleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.muayeneleriGörüntüleToolStripMenuItem.Name = "muayeneleriGörüntüleToolStripMenuItem";
            this.muayeneleriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.muayeneleriGörüntüleToolStripMenuItem.Text = "Muayene Listesini Görüntüle";
            this.muayeneleriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.muayeneleriGörüntüleToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muayene Bilgi Yönetim Sistemi";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muayeneKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaBilgileriniGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reçeteYazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muayeneleriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reçeteleriGörüntüleToolStripMenuItem;
    }
}

