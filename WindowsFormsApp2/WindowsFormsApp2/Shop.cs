using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myspace
{
    public partial class Shop : Form
    {
        private int count1 = 0;
        private int count2 = 0;
        public Shop()
        {
            InitializeComponent();
            label6.Text += $"{PlayerVSplayer.player1.Name}";
            label1.Text += $"{PlayerVSplayer.player1.Health}";
            label2.Text += $"{PlayerVSplayer.player1.ResistanceToPhysical}";
            label3.Text += $"{PlayerVSplayer.player1.ResistanceToMagical}";
            label4.Text += $"{PlayerVSplayer.player1.CriticalChance}";
            label5.Text += $"{PlayerVSplayer.player1.AttackPower}";

            label8.Text += $"{PlayerVSplayer.player2.Name}";
            label13.Text += $"{PlayerVSplayer.player2.Health}";
            label12.Text += $"{PlayerVSplayer.player2.ResistanceToPhysical}";
            label11.Text += $"{PlayerVSplayer.player2.ResistanceToMagical}";
            label10.Text += $"{PlayerVSplayer.player2.CriticalChance}";
            label9.Text += $"{PlayerVSplayer.player2.AttackPower}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count1 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            PlayerVSplayer.player1.Health += 20;
            count1++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count1 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            PlayerVSplayer.player1.ResistanceToPhysical += 3;
            count1++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count1 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            PlayerVSplayer.player1.ResistanceToMagical += 3;
            count1++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (count1 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            PlayerVSplayer.player1.CriticalChance += 15;
            count1++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (count1 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            PlayerVSplayer.player1.AttackPower += 10;
            count1++;
        }



        private void button10_Click(object sender, EventArgs e)
        {
            if (count2 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            PlayerVSplayer.player2.Health += 20;
            count2++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (count2 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            PlayerVSplayer.player2.ResistanceToPhysical += 3;
            count2++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (count2 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            PlayerVSplayer.player2.ResistanceToMagical += 3;
            count2++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (count2 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            PlayerVSplayer.player2.CriticalChance += 15;
            count2++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (count2 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            PlayerVSplayer.player2.AttackPower += 10;
            count2++;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
