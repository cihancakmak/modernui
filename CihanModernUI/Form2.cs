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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int Move;
        int Mouse_X;
        int Mouse_Y;

        public static string KalanKucukSuDepo;
        public static string KalanOrtaSuDepo;
        public static string KalanBuyukSuDepo;
        public static string KalanSadeSodaDepo;
        public static string KalanMeyveliSodaDepo;

        private void Form2_Load(object sender, EventArgs e)
        {
            KalanKucukSuDepo = label35.Text;
            KalanOrtaSuDepo = label33.Text;
            KalanBuyukSuDepo = label31.Text;
            KalanSadeSodaDepo = label36.Text;
            KalanMeyveliSodaDepo = label40.Text;

            label1.Text = Form1.uyelogin;
            pictureBox6.Visible = true;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            panel4.Controls.Clear();
            Form3 form3 = new Form3();
            form3.TopLevel = false;
            panel4.Controls.Add(form3);
            form3.Show();
            form3.Dock = DockStyle.Fill;
            form3.BringToFront();

            OleDbConnection con2 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\VeriTabani\Database1.accdb;Persist Security Info=False;");
            con2.Open();
            OleDbCommand cmd2 = new OleDbCommand("Select * FROM Depo", con2);
            OleDbDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                label35.Text = dr["KalanKucukSu"].ToString();
                label33.Text = dr["KalanOrtaSu"].ToString();
                label31.Text = dr["KalanBuyukSu"].ToString();
                label36.Text = dr["KalanSadeSoda"].ToString();
                label40.Text = dr["KalanMeyveliSoda"].ToString();
            }
            con2.Close();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();

            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            panel4.Controls.Clear();
            Form3 form3 = new Form3();
            form3.TopLevel = false;
            panel4.Controls.Add(form3);
            form3.Show();
            form3.Dock = DockStyle.Fill;
            form3.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            panel4.Controls.Clear();
            Form4 form4 = new Form4();
            form4.TopLevel = false;
            panel4.Controls.Add(form4);
            form4.Show();
            form4.Dock = DockStyle.Fill;
            form4.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = true;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            panel4.Controls.Clear();
            Form6 form6 = new Form6();
            form6.TopLevel = false;
            panel4.Controls.Add(form6);
            form6.Show();
            form6.Dock = DockStyle.Fill;
            form6.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = true;
            pictureBox10.Visible = false;
            panel4.Controls.Clear();
            Form5 form5 = new Form5();
            form5.TopLevel = false;
            panel4.Controls.Add(form5);
            form5.Show();
            form5.Dock = DockStyle.Fill;
            form5.BringToFront();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string veritabani;
            veritabani = @"C:\VeriTabani\Database1.accdb";
            System.Diagnostics.Process.Start(veritabani);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = true;

            panel4.Controls.Clear();
            Form8 form8 = new Form8();
            form8.TopLevel = false;
            panel4.Controls.Add(form8);
            form8.Show();
            form8.Dock = DockStyle.Fill;
            form8.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
