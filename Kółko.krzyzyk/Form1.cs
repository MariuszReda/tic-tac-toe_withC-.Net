using System;
using System.Windows.Forms;

namespace Kółko.krzyzyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool player1 = true;
        int movement = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            traffic(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            traffic(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            traffic(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            traffic(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            traffic(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            traffic(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            traffic(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            traffic(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            traffic(sender);
        }

        private void traffic (object sender)
        {
            if (((Button)sender).Text != "O" && ((Button)sender).Text != "X")
            {
                movement++;
                ((Button)sender).Text = player1 ? "O" : "X";
                if (movement >= 5)
                {
                    Checking();
                }
                player1 = !player1;
                label2.Text = player1 ? "O" : "X";
            }
        }


        private void Checking()
        {
            if (button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
            {
                Win();
            }
            else if (button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text)
            {
                Win();
            }
            else if (button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text)
            {
                Win();
            }
            else if (button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text)
            {
                Win();
            }
            else if (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text)
            {
                Win();
            }
            else if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text)
            {
                Win();
            }
            else if (button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text)
            {
                Win();
            }
            else if (button3.Text !="" && button3.Text==button5.Text && button5.Text==button7.Text)
            {
                Win();
            }
            else if(movement==9)
            {
                MessageBox.Show("Drow", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rest();
            }
        }

        private void Win()
        {
            MessageBox.Show("Winning player " + (player1 ? " O" : " X"), " Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (player1)
                label6.Text = ((int.Parse(label6.Text)) + 1).ToString();
            else
                label7.Text = ((int.Parse(label7.Text)) + 1).ToString();
            rest();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            rest();
            label6.Text=("0");
            label7.Text=("0");
            label1.Text = ("X");
            player1 = true;
        }

        private void rest()
        {
            movement = 0;
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
                b.Text = "";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
