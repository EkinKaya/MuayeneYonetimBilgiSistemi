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
    public partial class frmReceteYazma : Form
    {
        public frmReceteYazma()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbmuayenesistemi; user ID=postgres; password=33337069396");
        private void btnReceteEkle_Click(object sender, EventArgs e)
        {
            if ((int.Parse(txtilacAdet1.Text) > 3) || (int.Parse(txtilacAdet2.Text) > 3) || (int.Parse(txtilacAdet3.Text) > 3) || (int.Parse(txtilacAdet4.Text) > 3) || (int.Parse(txtilacAdet5.Text) > 3))
            {
                MessageBox.Show("Bir reçeteye aynı ilaçtan max 3 adet girilebilir");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand komutekleme = new NpgsqlCommand("insert into recete (\"recete_no\", \"recetemuayene_no\", \"doktor_adi\") values (@receteno, @muayeneno, @doktorad)", baglanti);
                komutekleme.Parameters.AddWithValue("@receteno", int.Parse(txtRecete.Text));
                komutekleme.Parameters.AddWithValue("@muayeneno", int.Parse(txtMuayene.Text));
                komutekleme.Parameters.AddWithValue("@doktorad", txtDoktor.Text);
                komutekleme.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                NpgsqlCommand komutekleme2 = new NpgsqlCommand("insert into recete_detay (\"detay_no\", \"recetedetay_no\", \"ilac1_barkod\", \"ilac2_barkod\", \"ilac3_barkod\", \"ilac4_barkod\", \"ilac5_barkod\", \"ilac1_adet\", \"ilac2_adet\", \"ilac3_adet\", \"ilac4_adet\", \"ilac5_adet\") values (@detayno, @recetedetayno, @ilac1, @ilac2, @ilac3, @ilac4, @ilac5, @ilac1adet, @ilac2adet, @ilac3adet, @ilac4adet, @ilac5adet)", baglanti);
                komutekleme2.Parameters.AddWithValue("@detayno", int.Parse(txtMuayene.Text));
                komutekleme2.Parameters.AddWithValue("@recetedetayno", int.Parse(txtRecete.Text));
                komutekleme2.Parameters.AddWithValue("@ilac1", int.Parse(txtBarkod1.Text));
                komutekleme2.Parameters.AddWithValue("@ilac2", int.Parse(txtBarkod2.Text));
                komutekleme2.Parameters.AddWithValue("@ilac3", int.Parse(txtBarkod3.Text));
                komutekleme2.Parameters.AddWithValue("@ilac4", int.Parse(txtBarkod4.Text));
                komutekleme2.Parameters.AddWithValue("@ilac5", int.Parse(txtBarkod5.Text));
                komutekleme2.Parameters.AddWithValue("@ilac1adet", int.Parse(txtilacAdet1.Text));
                komutekleme2.Parameters.AddWithValue("@ilac2adet", int.Parse(txtilacAdet2.Text));
                komutekleme2.Parameters.AddWithValue("@ilac3adet", int.Parse(txtilacAdet3.Text));
                komutekleme2.Parameters.AddWithValue("@ilac4adet", int.Parse(txtilacAdet4.Text));
                komutekleme2.Parameters.AddWithValue("@ilac5adet", int.Parse(txtilacAdet5.Text));
                komutekleme2.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Reçete ekleme başarılı");
            }
        }
    }
}
