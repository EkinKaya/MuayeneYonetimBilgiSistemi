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
    public partial class frmIlacEkle : Form
    {
        public frmIlacEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbmuayenesistemi; user ID=postgres; password=33337069396");
        private void frmIlacEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnilacEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komutekleme = new NpgsqlCommand("insert into ilac (\"barkod_no\", \"ilac_ad\", \"ilac_tip\") values (@barkodno, @ilacad, @ilactip)", baglanti);
            komutekleme.Parameters.AddWithValue("@barkodno", int.Parse(txtBarkod.Text));
            komutekleme.Parameters.AddWithValue("@ilacad", txtilacAd.Text);
            komutekleme.Parameters.AddWithValue("@ilactip", comboBoxIlacTip.Text);
            komutekleme.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İlaç ekleme başarılı");
        }

        private void btnilacListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from ilac";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
