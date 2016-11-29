using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoyMikkCasino
{
    public partial class Form1 : Form
    {
        int cash = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void dvig1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int dig = rand.Next(8);
            label1.Text = System.Convert.ToString(dig);
        }

        private void dvig2_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int dig = rand.Next(8);
            label2.Text = System.Convert.ToString(dig);
        }

        private void dvig3_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int dig = rand.Next(8);
            label3.Text = System.Convert.ToString(dig);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbcash.Text = System.Convert.ToString(cash);
            dvig1.Enabled = true;
            dvig2.Enabled = true;
            dvig3.Enabled = true;
            stop1.Enabled = true;
            stop2.Enabled = true;
            stop3.Enabled = true;
        }

        private void stop1_Tick(object sender, EventArgs e)
        {
            dvig1.Enabled = false;
            stop1.Enabled = false;
        }

        private void stop2_Tick(object sender, EventArgs e)
        {
            dvig2.Enabled = false;
            stop2.Enabled = false;
        }

        private void stop3_Tick(object sender, EventArgs e)
        {
            dvig3.Enabled = false;
            stop3.Enabled = false;
            // ***********************
            // Swich case 80 lvl
            //************************
            //WINS
            if (cash <= 0)
            {
                MessageBox.Show("Вы все проиграли!");
                button1.Enabled = false;
            }
            if ((label1.Text == "2") && (label2.Text == "2") && (label3.Text == "8"))
            {
                MessageBox.Show("Вы выиграли супер бонус от МИХИ228 228$");
                cash += 228;
            }

            if ((label1.Text == "2") && (label2.Text == "2") && (label3.Text == "2"))
            {
                MessageBox.Show("Вы выиграли 100$");
                cash += 100;
            }

            if ((label1.Text == "1") && (label2.Text == "1") && (label3.Text == "1"))
            {
                MessageBox.Show("Вы выиграли 100$");
                cash += 100;
            }

            if ((label1.Text == "3") && (label2.Text == "3") && (label3.Text == "3"))
            {
                MessageBox.Show("Вы выиграли 100$");
                cash += 100;
            }

            if ((label1.Text == "4") && (label2.Text == "4") && (label3.Text == "4"))
            {
                MessageBox.Show("Вы выиграли 100$");
                cash += 100;
            }

            if ((label1.Text == "5") && (label2.Text == "5") && (label3.Text == "5"))
            {
                MessageBox.Show("Вы выиграли 100$");
                cash += 100;
            }

            if ((label1.Text == "6") && (label2.Text == "6") && (label3.Text == "6"))
            {
                MessageBox.Show("Вы выиграли 100$");
                cash += 100;
            }

            if ((label1.Text == "7") && (label2.Text == "7") && (label3.Text == "7"))
            {
                MessageBox.Show("Вы выиграли 100$");
                cash += 100;
            }

            if ((label1.Text == "3") && (label2.Text == "2") && (label3.Text == "2"))
            {
                MessageBox.Show("Вы выиграли супер бонус от СОЛО322 322$");
                cash += 322;
            }
            if ((label1.Text == "7") || (label2.Text == "7") || (label3.Text == "7"))
            {
                MessageBox.Show("Вы выиграли 10$");
                cash += 10;
            }
                //LOSE
            else
            {
                cash -= 10;
            }
            lbcash.Text = System.Convert.ToString(cash);
        }
    }
}
