using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kółko.krzyzyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool gracz1 = true;
        int ruch = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprwadz();
            }
            gracz1 = !gracz1;
            label2.Text = gracz1 ? "O" : "X";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprwadz();
            }
            gracz1 = !gracz1;
            label2.Text = gracz1 ? "O" : "X";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprwadz();
            }
            gracz1 = !gracz1;
            label2.Text = gracz1 ? "O" : "X";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprwadz();
            }
            gracz1 = !gracz1;
            label2.Text = gracz1 ? "O" : "X";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprwadz();
            }
            gracz1 = !gracz1;
            label2.Text = gracz1 ? "O" : "X";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprwadz();
            }
            gracz1 = !gracz1;
            label2.Text = gracz1 ? "O" : "X";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprwadz();
            }
            gracz1 = !gracz1;
            label2.Text = gracz1 ? "O" : "X";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprwadz();
            }
            gracz1 = !gracz1;
            label2.Text = gracz1 ? "O" : "X";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if(ruch>=5)
            {
                Sprwadz();
            }
            gracz1 = !gracz1;
            label2.Text = gracz1 ? "O" : "X";
        }

        private void Sprwadz()
        {
            if (button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
            {
                Wygrana();
            }
            else if (button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text)
            {
                Wygrana();
            }
            else if (button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text)
            {
                Wygrana();
            }
            else if (button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text)
            {
                Wygrana();
            }
            else if (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text)
            {
                Wygrana();
            }
            else if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text)
            {
                Wygrana();
            }
            else if (button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text)
            {
                Wygrana();
            }
            else if (button3.Text !="" && button3.Text==button5.Text && button5.Text==button7.Text)
            {
                Wygrana();
            }
            else if(ruch==9)
            {
                MessageBox.Show("remis", "koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                restaruj();
            }
        }

        private void Wygrana()
        {
            MessageBox.Show("wygrywa gracz" + (gracz1 ? "O" : "X"), "koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (gracz1)
                label6.Text = ((int.Parse(label6.Text)) + 1).ToString();
            else
                label7.Text = ((int.Parse(label7.Text)) + 1).ToString();
            restaruj();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            restaruj();
            label6.Text=("0");
            label7.Text=("0");
            label1.Text = ("X");
            gracz1 = true;
        }

        private void restaruj()
        {
            ruch = 0;
            Button[] all = new Button[9];
            all[0] = button1;
            all[1] = button2;
            all[2] = button3;
            all[3] = button4;
            all[4] = button5;
            all[5] = button6;
            all[6] = button7;
            all[7] = button8;
            all[8] = button9;
            foreach(Button b in all)
            {
                b.Enabled = true;
                b.Text = "";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
