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
    public partial class frmReceteGoruntule : Form
    {
        public frmReceteGoruntule()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbmuayenesistemi; user ID=postgres; password=33337069396");
        private void frmReceteGoruntule_Load(object sender, EventArgs e)
        {
            string sorgu = "select \"tc_kimlik\", \"hasta_ad\", \"hasta_soyad\", \"muayene_tarih\", \"hasta_tani\", \"doktor_adi\", \"ilac1_barkod\", \"ilac1_adet\", \"ilac_ad\"," +
                " \"ilac2_barkod\", \"ilac2_adet\", \"ilac3_barkod\", \"ilac3_adet\", \"ilac4_barkod\", \"ilac4_adet\", \"ilac5_barkod\", \"ilac5_adet\" from hasta "+
                "INNER JOIN muayene on \"tc_kimlik\" = \"hasta_tckimlik\" " +
                "INNER JOIN recete on \"muayene_no\" = \"recetemuayene_no\" " +
                "INNER JOIN recete_detay on \"recetedetay_no\" = \"recete_no\" " +
                "INNER JOIN ilac on \"ilac1_barkod\" = \"barkod_no\" order by \"muayene_tarih\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewListeleme.DataSource = ds.Tables[0];
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select \"tc_kimlik\", \"hasta_ad\", \"hasta_soyad\", \"muayene_tarih\", \"hasta_tani\", \"doktor_adi\", \"ilac1_barkod\", \"ilac1_adet\", \"ilac_ad\"," +
                " \"ilac2_barkod\", \"ilac2_adet\", \"ilac3_barkod\", \"ilac3_adet\", \"ilac4_barkod\", \"ilac4_adet\", \"ilac5_barkod\", \"ilac5_adet\" from hasta " +
                "INNER JOIN muayene on \"tc_kimlik\" = \"hasta_tckimlik\" " +
                "INNER JOIN recete on \"muayene_no\" = \"recetemuayene_no\" " +
                "INNER JOIN recete_detay on \"recetedetay_no\" = \"recete_no\" " +
                "INNER JOIN ilac as i on \"ilac1_barkod\" = \"barkod_no\" " +
                "where \"tc_kimlik\"= @hastatc order by \"muayene_tarih\"";
            NpgsqlCommand komutAranan = new NpgsqlCommand(sorgu, baglanti);
            komutAranan.Parameters.AddWithValue("@hastatc", txtTC.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutAranan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewListeleme.DataSource = dt;
            baglanti.Close();
        }

        private void btnListeleBarkod_Click(object sender, EventArgs e)
        {
            baglanti.Open();
           string sorgu = "select \"tc_kimlik\", \"hasta_ad\", \"hasta_soyad\", \"muayene_tarih\", \"hasta_tani\", \"doktor_adi\", \"ilac1_barkod\", \"ilac1_adet\", \"ilac_ad\"," +
                " \"ilac2_barkod\", \"ilac2_adet\", \"ilac3_barkod\", \"ilac3_adet\", \"ilac4_barkod\", \"ilac4_adet\", \"ilac5_barkod\", \"ilac5_adet\" from hasta "+
                "INNER JOIN muayene on \"tc_kimlik\" = \"hasta_tckimlik\" " +
                "INNER JOIN recete on \"muayene_no\" = \"recetemuayene_no\" " +
                "INNER JOIN recete_detay on \"recetedetay_no\" = \"recete_no\" " +
                "INNER JOIN ilac on \"ilac1_barkod\" = \"barkod_no\" " +
                "where \"ilac1_barkod\"= @barkod or \"ilac2_barkod\"= @barkod or \"ilac3_barkod\"= @barkod or \"ilac4_barkod\"= @barkod or \"ilac5_barkod\"= @barkod order by \"muayene_tarih\"";
            NpgsqlCommand komutAranan = new NpgsqlCommand(sorgu, baglanti);
            komutAranan.Parameters.AddWithValue("@barkod", int.Parse(txtBarkod.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutAranan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewListeleme.DataSource = dt;
            baglanti.Close();
        }
    }
}
