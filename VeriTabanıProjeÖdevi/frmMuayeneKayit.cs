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
    public partial class frmMuayeneKayit : Form
    {
        public frmMuayeneKayit()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbmuayenesistemi; user ID=postgres; password=33337069396");
        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komutGano = new NpgsqlCommand("select \"hasta_tckimlik\", \"muayene_tarih\" from muayene", baglanti);
            NpgsqlDataReader dr = komutGano.ExecuteReader();

            string tarihkontrol = maskedTxtMuayeneTarihi.Text;
            string tckontrol = txtHastaTC.Text;
            bool hatalimi = false;

            while (dr.Read())
            {
                if (dr[0].ToString() == tckontrol && dr[1].ToString() == tarihkontrol)
                {
                    hatalimi = true;
                    break;
                }
            }
            baglanti.Close();

            if (hatalimi == false)
            { 
            baglanti.Open();
            NpgsqlCommand komutekleme = new NpgsqlCommand("insert into muayene (\"muayene_no\", \"hasta_tckimlik\", \"muayene_tarih\", \"hasta_sikayet\", \"hasta_tani\", \"onerilen_tedavi\", \"mrecete_no\") values (@muayeneno, @hastatc, @muayenetarih, @hastasikayet, @hastatani, @onerilentedavi, @receteno)", baglanti);
            komutekleme.Parameters.AddWithValue("@muayeneno", int.Parse(txtMuayeneNo.Text));
            komutekleme.Parameters.AddWithValue("@hastatc", txtHastaTC.Text);
            komutekleme.Parameters.AddWithValue("@muayenetarih", maskedTxtMuayeneTarihi.Text);
            komutekleme.Parameters.AddWithValue("@hastasikayet", richTxtSikayet.Text);
            komutekleme.Parameters.AddWithValue("@hastatani", txtTani.Text);
            komutekleme.Parameters.AddWithValue("@onerilentedavi", txtTedavi.Text);
            komutekleme.Parameters.AddWithValue("@receteno", int.Parse(txtReceteNo.Text));
            komutekleme.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Randevu ekleme başarılı");
            }
            else
            {
                MessageBox.Show("Bir hasta günde yalnızca bir randevu alabilir. Lütfen yarın tekrar deneyiniz.");
            }
        }
    }
}
