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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string Cinsiyet;
        string KanGrubu;

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Cinsiyet = "Erkek";
            }
            if (radioButton2.Checked)
            {
                Cinsiyet = "Kadın";
            }
            if (radioButton3.Checked)
            {
                KanGrubu = "A Rh+";
            }
            if (radioButton4.Checked)
            {
                KanGrubu = "B Rh+";
            }
            if (radioButton5.Checked)
            {
                KanGrubu = "AB Rh-";
            }
            if (radioButton6.Checked)
            {
                KanGrubu = "AB Rh+";
            }
            if (radioButton13.Checked)
            {
                KanGrubu = "0 Rh+";
            }
            if (radioButton10.Checked)
            {
                KanGrubu = "0 Rh-";
            }
            if (radioButton9.Checked)
            {
                KanGrubu = "B Rh-";
            }
            if (radioButton12.Checked)
            {
                KanGrubu = "A Rh-";
            }


            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\VeriTabani\Database1.accdb;Persist Security Info=False;";
            con.Open();
            OleDbCommand kmt = new OleDbCommand("insert into uyeler(Ad,Soyad,TCKimlik,Telefon,AcilTelefon,Eposta,Adres,Cinsiyet,KanGrubu,Süresi,OdemeSekli,Tarih,BaslangicTarihi,BitisTarihi)" +
                " values('" + textBox1.Text + "' " +
                ", '" + textBox2.Text + "' " +
                ", '" + textBox3.Text + "' " +
                ", '" + textBox4.Text + "' " +
                ", '" + textBox6.Text + "' " +
                ", '" + textBox7.Text + comboBox3.SelectedItem + "'" +
                ", '" + textBox5.Text + "' " +
                ", '" + Cinsiyet + "'" +
                ", '" + KanGrubu + "'" +
                ", '" + comboBox1.SelectedItem + "'" +
                ", '" + comboBox2.SelectedItem + "'" +
                ", '" + label7.Text + "' " +
                ", '" + label11.Text + "' " +
                ", '" + label12.Text + "' )", con);
            kmt.ExecuteNonQuery();
            MessageBox.Show("Kayıt Edildi.");

            con.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongDateString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label11.Text = dateTimePicker1.Text;
            label12.Text = dateTimePicker2.Text;
        }

    }
}
