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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public static double Ksu;
        public static double Osu;
        public static double Bsu;
        public static double Protein;
        public static double Nescafe;
        public static double MeyveliSoda;
        public static double SadeSoda;
        public static double KsuPara = 1.5;
        public static double OsuPara =2;
        public static double BsuPara = 2.5;
        public static double ProteinPara = 8;
        public static double NescafePara = 4;
        public static double SadeSodaPara = 3;
        public static double MeyveliSodaPara = 4;
        public static double Azalt =1;
        public static double Arttır = 1;
        public static double KsuParaToplam;
        public static double OsuParaToplam;
        public static double BsuParaToplam;
        public static double ProteinParaToplam;
        public static double NescafeParaToplam;
        public static double SadeSodaParaToplam;
        public static double MeyveliSodaParaToplam;
        public static double KalanKucukSu;
        public static double KalanOrtaSu;
        public static double KalanBüyükSu;
        public static double KalanSadeSoda;
        public static double KalanMeyveliSoda;
        public static double KalanKsuDepo;
        public static double KalanOsuDepo;
        public static double KalanBsuDepo;
        public static double KalanSadeSodaDepo;
        public static double KalanMeyveliSodaDepo;






        private void button3_Click(object sender, EventArgs e)
        {
            Ksu++;
            KsuParaToplam = Ksu * KsuPara;
            
            Form2.listBox1.Items.Add("[+] Küçük Su Satıldı " + DateTime.Now.ToLongTimeString());

            KalanKsuDepo = Int32.Parse(Form2.label35.Text);
            KalanKsuDepo = KalanKsuDepo - Azalt;
            Form2.label35.Text = KalanKsuDepo.ToString();
             
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Osu++;
            OsuParaToplam = Osu * OsuPara;

            Form2.listBox1.Items.Add("[+] Orta Su Satıldı " + DateTime.Now.ToLongTimeString());

            KalanOsuDepo = Int32.Parse(Form2.label33.Text);
            KalanOsuDepo = KalanOsuDepo - Azalt;
            Form2.label33.Text = KalanOsuDepo.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bsu++;
            BsuParaToplam = Bsu * BsuPara;

            Form2.listBox1.Items.Add("[+] Büyük Su Satıldı " + DateTime.Now.ToLongTimeString());

            KalanBsuDepo = Int32.Parse(Form2.label31.Text);
            KalanBsuDepo = KalanBsuDepo - Azalt;
            Form2.label31.Text = KalanBsuDepo.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Protein++;
            ProteinParaToplam = Protein * ProteinPara;

            Form2.listBox1.Items.Add("[+] Protein Satıldı " + DateTime.Now.ToLongTimeString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nescafe++;
            NescafeParaToplam = Nescafe * NescafePara;

            Form2.listBox1.Items.Add("[+] Nescafe Satıldı " + DateTime.Now.ToLongTimeString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SadeSoda++;
            SadeSodaParaToplam = SadeSoda * SadeSodaPara;

            Form2.listBox1.Items.Add("[+] Sade Soda Satıldı " + DateTime.Now.ToLongTimeString());

            KalanSadeSodaDepo = Int32.Parse(Form2.label36.Text);
            KalanSadeSodaDepo = KalanSadeSodaDepo - Azalt;
            Form2.label36.Text = KalanSadeSodaDepo.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MeyveliSoda++;
            MeyveliSodaParaToplam = MeyveliSoda * MeyveliSodaPara;

            Form2.listBox1.Items.Add("[+] Meyveli Soda Satıldı " + DateTime.Now.ToLongTimeString());

            KalanMeyveliSodaDepo = Int32.Parse(Form2.label40.Text);
            KalanMeyveliSodaDepo = KalanMeyveliSodaDepo - Azalt;
            Form2.label40.Text = KalanMeyveliSodaDepo.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ksu--;
            KsuParaToplam = KsuParaToplam - KsuPara;

            Form2.listBox1.Items.Add("[-] Küçük Su Çıkartıldı " + DateTime.Now.ToLongTimeString() );

            KalanKsuDepo = Int32.Parse(Form2.label35.Text);
            KalanKsuDepo = KalanKsuDepo + Arttır;
            Form2.label35.Text = KalanKsuDepo.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Osu--;
            OsuParaToplam = OsuParaToplam - OsuPara;

            Form2.listBox1.Items.Add("[-] Orta Su Çıkartıldı " + DateTime.Now.ToLongTimeString());

            KalanOsuDepo = Int32.Parse(Form2.label33.Text);
            KalanOsuDepo = KalanOsuDepo + Arttır;
            Form2.label33.Text = KalanOsuDepo.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Bsu--;
            BsuParaToplam = BsuParaToplam - BsuPara;

            Form2.listBox1.Items.Add("[-] Büyük Su Çıkartıldı " + DateTime.Now.ToLongTimeString());

            KalanBsuDepo = Int32.Parse(Form2.label31.Text);
            KalanBsuDepo = KalanBsuDepo + Arttır;
            Form2.label31.Text = KalanBsuDepo.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Protein--;
            ProteinParaToplam = ProteinParaToplam - ProteinPara;

            Form2.listBox1.Items.Add("[-] Protein Çıkartıldı " + DateTime.Now.ToLongTimeString());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Nescafe--;
            NescafeParaToplam = NescafeParaToplam - NescafePara;

            Form2.listBox1.Items.Add("[-] Nescafe Çıkartıldı " + DateTime.Now.ToLongTimeString());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SadeSoda--;
            SadeSodaParaToplam = SadeSodaParaToplam - SadeSodaPara;

            Form2.listBox1.Items.Add("[-] Sade Soda Çıkartıldı " + DateTime.Now.ToLongTimeString());

            KalanSadeSodaDepo = Int32.Parse(Form2.label36.Text);
            KalanSadeSodaDepo = KalanSadeSodaDepo + Arttır;
            Form2.label36.Text = KalanSadeSodaDepo.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MeyveliSoda--;
            MeyveliSodaParaToplam = MeyveliSodaParaToplam - MeyveliSodaPara;

            Form2.listBox1.Items.Add("[-] Meyveli Soda Çıkartıldı " + DateTime.Now.ToLongTimeString());

            KalanMeyveliSodaDepo = Int32.Parse(Form2.label40.Text);
            KalanMeyveliSodaDepo = KalanMeyveliSodaDepo + Arttır;
            Form2.label40.Text = KalanMeyveliSodaDepo.ToString();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
