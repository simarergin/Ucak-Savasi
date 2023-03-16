using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucak_Savasi
{
    public partial class Form1 : Form
    {
        int solHareket = 0;
        int ducakHareketHiz = 3;
        Random rnd = new Random();
        int mermiHiz = 8;
        bool ates = false;
        int Puan = 0;
        public Form1()
        {
            InitializeComponent();
            ducak1.Top = -500;
            ducak2.Top = -900;
            ducak3.Top = -1300;
            mermi.Top = -100;
            mermi.Left = -100;

        }

        private void ducak1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Start();
            }
            if (e.KeyCode == Keys.P)
            {
                timer1.Stop();
            }

            if (e.KeyCode == Keys.Left)
            {
                if (bucak.Location.X < 0) { solHareket = 0; } else { solHareket =-5; }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (bucak.Location.X > 512)
                {
                    solHareket = 0;
                }
                else
                {
                    solHareket = 5;
                }
            }
            else if (e.KeyCode == Keys.Space)
            {

                if (ates == false)
                {
                    mermiHiz = 8;
                    mermi.Left = bucak.Left+40;
                    mermi.Top = bucak.Top;
                    ates = true;
                }
            }


          
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                solHareket = 0;
            }
            else if (e.KeyCode == Keys.Right)
            {
                solHareket = 0;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            bucak.Left += solHareket;
            mermi.Top -= mermiHiz;
            ducak1.Top += ducakHareketHiz;
            ducak2.Top += ducakHareketHiz;
            ducak3.Top += ducakHareketHiz;
            lblsonuc.Text = "" + Puan;
            if (ducak1.Top >= 660 || ducak2.Top >= 660 || ducak3.Top >= 660)
            {
                oyunSonu();

            }
            if (ates && mermi.Top < 0)
            {
                ates = false;
                mermiHiz = 0;
                mermi.Top = -100;
                mermi.Left = -100;
            }
            Vurulma();
        }

        private void oyunSonu()
        {           
                timer1.Enabled = false;
                MessageBox.Show(Puan + " Puan Kazandınız....", "Uçak Oyunu V1.0 www.bilisimogretmeni.com", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Puan = 0;
                lblsonuc.Text = "0";
                ducak1.Top = -500;
                ducak2.Top = -900;
                ducak3.Top = -1300;
                mermi.Top = -100;
                mermi.Left = -100;
                timer1.Enabled = true;
        }

        private void Vurulma()
        {
            if (mermi.Bounds.IntersectsWith(ducak1.Bounds))
            {
                Puan += 1;
                ducak1.Top = -500;
                int ranP = rnd.Next(1, 300);
                ducak1.Left = ranP;
                ates = false;
                mermiHiz = 0;
                mermi.Top = -100;
                mermi.Left = -100;

            }
            else if (mermi.Bounds.IntersectsWith(ducak2.Bounds))
            {
                Puan += 1;
                ducak2.Top = -900;
                int ranP = rnd.Next(1, 400);
                ducak2.Left = ranP;
                ates = false;
                mermiHiz = 0;
                mermi.Top = -100;
                mermi.Left = -100;

            }
            else if (mermi.Bounds.IntersectsWith(ducak3.Bounds))
            {
                Puan += 1;
                ducak3.Top = -1300;
                int ranP = rnd.Next(1, 500);
                ducak3.Left = ranP;
                ates = false;
                mermiHiz = 0;
                mermi.Top = -100;
                mermi.Left = -100;

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
