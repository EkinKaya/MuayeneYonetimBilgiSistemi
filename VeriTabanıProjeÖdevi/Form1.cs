using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabanıProjeÖdevi
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void hastaKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHastaEkle frmHastaEkle = new frmHastaEkle();
            frmHastaEkle.MdiParent = this;
            frmHastaEkle.Show();
        }

        private void hastaEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHastaEkle frmHastaEkle = new frmHastaEkle();
            frmHastaEkle.MdiParent = this;
            frmHastaEkle.Show();
        }

        private void ilaçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIlacEkle frmIlacEkle = new frmIlacEkle();
            frmIlacEkle.MdiParent = this;
            frmIlacEkle.Show();
        }

        private void muayeneKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuayeneKayit frmMuayeneKayit = new frmMuayeneKayit();
            frmMuayeneKayit.MdiParent = this;
            frmMuayeneKayit.Show();
        }

        private void muayeneleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuayeneListeleme frmMuayeneListeleme = new frmMuayeneListeleme();
            frmMuayeneListeleme.MdiParent = this;
            frmMuayeneListeleme.Show();
        }

        private void reçeteYazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceteYazma frmReceteYazma = new frmReceteYazma();
            frmReceteYazma.MdiParent = this;
            frmReceteYazma.Show();
        }

        private void hastaBilgileriniGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHastaBilgiEkrani frmHastaBilgiEkrani = new frmHastaBilgiEkrani();
            frmHastaBilgiEkrani.MdiParent = this;
            frmHastaBilgiEkrani.Show();
        }

        private void reçeteleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceteGoruntule frmReceteGoruntule = new frmReceteGoruntule();
            frmReceteGoruntule.MdiParent = this;
            frmReceteGoruntule.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
