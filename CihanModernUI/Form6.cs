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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            

            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\VeriTabani\Database1.accdb;Persist Security Info=False;");
            baglanti.Open();

            OleDbDataAdapter adapter = new OleDbDataAdapter(" select * from uyeler ",baglanti);

            DataTable tablo = new DataTable();
            adapter.Fill(tablo);

            dataGridView1.DataSource= tablo;

            baglanti.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {


            

        }



        private void uyelerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
