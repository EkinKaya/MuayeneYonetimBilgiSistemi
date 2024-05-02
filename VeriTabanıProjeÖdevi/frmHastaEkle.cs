using Npgsql;
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
    public partial class frmHastaEkle : Form
    {
        public frmHastaEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbmuayenesistemi; user ID=postgres; password=33337069396");
        private void frmHastaEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komutekleme = new NpgsqlCommand("insert into hasta (\"tc_kimlik\", \"hasta_ad\", \"hasta_soyad\", \"dogum_yeri\", \"dogum_tarihi\", \"hasta_adres\", \"medeni_durum\", \"telefon_no\", \"kan_grubu\") values (@hastatc, @hastaad, @hastasoyad, @dogumyeri, @dogumtarihi, @adres, @medenidurum, @telefon, @kangrubu)", baglanti);
            komutekleme.Parameters.AddWithValue("@hastatc", txtTC.Text);
            komutekleme.Parameters.AddWithValue("@hastaad", txtAd.Text);
            komutekleme.Parameters.AddWithValue("@hastasoyad", txtSoyad.Text);
            komutekleme.Parameters.AddWithValue("@dogumyeri", txtDogumYeri.Text);
            komutekleme.Parameters.AddWithValue("@dogumtarihi", maskedTxtDogumTarihi.Text);
            komutekleme.Parameters.AddWithValue("@adres", richTxtAdres.Text);
            komutekleme.Parameters.AddWithValue("@medenidurum", rdbtnBekar.Text);
            komutekleme.Parameters.AddWithValue("@telefon", maskedTextBoxTel.Text);
            komutekleme.Parameters.AddWithValue("@kangrubu", comboBoxKanGrup.Text);
            komutekleme.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hasta ekleme başarılı");
        }
    }
}
