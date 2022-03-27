using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinasıForm
{
    public partial class Form1 : Form
    {
        class metot
        {
            public string Hesap(string islem, int ilksayi, int ikinci)
            {
                switch (islem)
                {
                    case "+":
                        return (ilksayi + ikinci).ToString();
                        break;
                    case "-":
                        return (ilksayi - ikinci).ToString();
                        break;
                    case "x":
                        return (ilksayi * ikinci).ToString();
                        break;
                    case "/":
                        return (ilksayi / ikinci).ToString();
                        break;
                }
                return "";
            }
        }


        public Form1()
        {
            InitializeComponent();
        }
        int ilksayi,ikinci;
        string islem;
        private void button1_Click(object sender, EventArgs e)
        {
            if (snclbl.Text == "0")
            {
                snclbl.Text = "";
            }
            snclbl.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (snclbl.Text == "0")
            {
                snclbl.Text = "";
            }
            snclbl.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (snclbl.Text == "0")
            {
                snclbl.Text = "";
            }
            snclbl.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (snclbl.Text == "0")
            {
                snclbl.Text = "";
            }
            snclbl.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (snclbl.Text == "0")
            {
                snclbl.Text = "";
            }
            snclbl.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (snclbl.Text == "0")
            {
                snclbl.Text = "";
            }
            snclbl.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (snclbl.Text == "0")
            {
                snclbl.Text = "";
            }
            snclbl.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (snclbl.Text == "0")
            {
                snclbl.Text = "";
            }
            snclbl.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (snclbl.Text == "0")
            {
                snclbl.Text = "";
            }
            snclbl.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (snclbl.Text == "0")
            {
                snclbl.Text = "";
            }
            snclbl.Text += "0";
        }

        private void arti_Click(object sender, EventArgs e)
        {
            islem = "+";
            ilksayi = int.Parse(snclbl.Text);
            snclbl.Text = "";
        }

        private void eksi_Click(object sender, EventArgs e)
        {
            islem = "-";
            ilksayi = int.Parse(snclbl.Text);
            snclbl.Text = "";
        }

        private void carpi_Click(object sender, EventArgs e)
        {
            islem = "x";
            ilksayi = int.Parse(snclbl.Text);
            snclbl.Text = "";
        }

        private void bolme_Click(object sender, EventArgs e)
        {
            islem = "/";
            ilksayi = int.Parse(snclbl.Text);
            snclbl.Text = "";
        }

        private void esittir_Click(object sender, EventArgs e)
        {
            ikinci = int.Parse(snclbl.Text);
            metot nesne = new metot();
            snclbl.Text=nesne.Hesap(islem,ilksayi, ikinci);
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            snclbl.Text = "";
        }

       
    }
}
