using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CihanModernUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        double toplam;

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = Form5.Ksu.ToString();
            label5.Text = Form5.Osu.ToString();
            label4.Text = Form5.Bsu.ToString();
            label15.Text = Form5.Protein.ToString();
            label9.Text = Form5.Nescafe.ToString();
            label8.Text = Form5.SadeSoda.ToString();
            label7.Text = Form5.MeyveliSoda.ToString();

            label17.Text = Form5.KsuParaToplam.ToString();
            label19.Text = Form5.OsuParaToplam.ToString();
            label20.Text = Form5.BsuParaToplam.ToString();
            label28.Text = Form5.ProteinParaToplam.ToString();
            label24.Text = Form5.NescafeParaToplam.ToString();
            label25.Text = Form5.SadeSodaParaToplam.ToString();
            label26.Text = Form5.MeyveliSodaParaToplam.ToString();

            

            
        }

        #region Gereksiz Labellar
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
        #endregion  Gereksiz Labellar


        private void Form3_Load(object sender, EventArgs e)
        {
            label31.Text = DateTime.Now.ToLongDateString();

            OleDbConnection con2 = new OleDbConnection();
            con2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\VeriTabani\Database1.accdb;Persist Security Info=False;";
            con2.Open();
            OleDbCommand toplamuye = new OleDbCommand("SELECT count(*) FROM uyeler", con2);

            OleDbDataReader dr1 = toplamuye.ExecuteReader();
            while (dr1.Read())
            {
                label33.Text = dr1[0].ToString();
            }

            OleDbCommand bayuye = new OleDbCommand("SELECT count(*) FROM uyeler WHERE Cinsiyet='Erkek' ", con2);

            OleDbDataReader dr2 = bayuye.ExecuteReader();
            while (dr2.Read())
            {
                label39.Text = dr2[0].ToString();
            }

            OleDbCommand bayanuye = new OleDbCommand("SELECT count(*) FROM uyeler WHERE Cinsiyet='Kadın' ", con2);

            OleDbDataReader dr3 = bayanuye.ExecuteReader();
            while (dr3.Read())
            {
                label38.Text = dr3[0].ToString();
            }

            con2.Close();
            dr1.Close();
            dr2.Close();
            dr3.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toplam = Form5.KsuParaToplam + Form5.OsuParaToplam + Form5.BsuParaToplam + Form5.ProteinParaToplam + Form5.NescafeParaToplam + Form5.SadeSodaParaToplam + Form5.MeyveliSodaParaToplam;
            label30.Text = toplam.ToString();

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\VeriTabani\Database1.accdb;Persist Security Info=False;";
            OleDbCommand kmt = new OleDbCommand();
            OleDbCommand kmt2 = new OleDbCommand();
            OleDbCommand kmt3 = new OleDbCommand();
            con.Open();
            kmt.Connection = con;
            kmt2.Connection = con;
            kmt3.Connection = con;
            kmt2.CommandText = "insert into Satilanlar(SatilanKucukSu,SatilanOrtaSu,SatilanBuyukSu,Protein,Nescafe,SadeSoda,MeyveliSoda,Tarih) values('" + label6.Text + "','" + label5.Text + "','" + label4.Text + "','" + label15.Text + "','" + label9.Text + "','" + label8.Text + "','" + label7.Text + "', '" + label31.Text + "')";
            kmt3.CommandText = "insert into Depo(KalanKucukSu,KalanOrtaSu,KalanBuyukSu,KalanSadeSoda,KalanMeyveliSoda,Tarih) values('" + Form2.label35.Text + "' , '" + Form2.label33.Text + "' , '" + Form2.label31.Text + "' , '" + Form2.label36.Text + "' , '" + Form2.label40.Text + "' , '" + label31.Text + "')";
            kmt.CommandText = "insert into KazanilanPara(KucukSu,OrtaSu,BuyukSu,Protein,Nescafe,SadeSoda,MeyveliSoda,ToplamKazanc,Tarih) values('" + label17.Text + "','" + label19.Text + "','" + label20.Text + "','" + label28.Text + "','" + label24.Text + "','" + label25.Text + "','" + label26.Text + "','" + label30.Text + "' , '" + label31.Text + "')";
            kmt2.ExecuteNonQuery();
            kmt.ExecuteNonQuery();
            kmt3.ExecuteNonQuery();
            
            
            MessageBox.Show("Kayıt Edildi.");
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void circleprogressBar1_Load(object sender, EventArgs e)
        {
            
        }

        private void circleprogressBar1_Load_1(object sender, EventArgs e)
        {
        }
    }
}
