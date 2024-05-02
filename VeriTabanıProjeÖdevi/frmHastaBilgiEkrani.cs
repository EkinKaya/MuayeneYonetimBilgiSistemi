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
    public partial class frmHastaBilgiEkrani : Form
    {
        public frmHastaBilgiEkrani()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbmuayenesistemi; user ID=postgres; password=33337069396");
        private void btnAranan_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from hasta where \"tc_kimlik\"= @hastatc";
            NpgsqlCommand komutAranan = new NpgsqlCommand(sorgu, baglanti);
            komutAranan.Parameters.AddWithValue("@hastatc", txtTC.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutAranan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewListeleme.DataSource = dt;
            baglanti.Close();

            baglanti.Open();
            string sorgu2 = "select * from muayene where \"hasta_tckimlik\"= @hastatckimlik";
            NpgsqlCommand komutArananMuayene = new NpgsqlCommand(sorgu2, baglanti);
            komutArananMuayene.Parameters.AddWithValue("@hastatckimlik", txtTC.Text);
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(komutArananMuayene);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridViewMuayene.DataSource = dt2;
            baglanti.Close();
        }
    }
}
