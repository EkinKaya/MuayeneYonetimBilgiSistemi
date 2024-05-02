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
    public partial class frmMuayeneListeleme : Form
    {
        public frmMuayeneListeleme()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbmuayenesistemi; user ID=postgres; password=33337069396");
        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from muayene";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewListeleme.DataSource = ds.Tables[0];
        }

        private void btnAranan_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from muayene where \"muayene_tarih\"= @tarih";
            NpgsqlCommand komutAranan = new NpgsqlCommand(sorgu, baglanti);
            komutAranan.Parameters.AddWithValue("@tarih", maskedTxtTarih.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komutAranan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewListeleme.DataSource = dt;
            baglanti.Close();
        }
    }
}
