using System;
using System.Windows.Forms;

namespace Myspace
{
    public partial class Shop : Form
    {
        private Random botChoiceShop = new Random();
        private int count1 = 0;
        private int count2 = 0;
        public Shop()
        {
            InitializeComponent();
            if (BMenu.Chose == 1)
            {
                label6.Text += $"{ChooseHero.player1.Name}";
                label1.Text += $"{ChooseHero.player1.Health}";
                label2.Text += $"{ChooseHero.player1.ResistanceToPhysical}";
                label3.Text += $"{ChooseHero.player1.ResistanceToMagical}";
                label4.Text += $"{ChooseHero.player1.CriticalChance}";
                label5.Text += $"{ChooseHero.player1.AttackPower}";

                label8.Text += $"{ChooseHero.player2.Name}";
                label13.Text += $"{ChooseHero.player2.Health}";
                label12.Text += $"{ChooseHero.player2.ResistanceToPhysical}";
                label11.Text += $"{ChooseHero.player2.ResistanceToMagical}";
                label10.Text += $"{ChooseHero.player2.CriticalChance}";
                label9.Text += $"{ChooseHero.player2.AttackPower}";
            }
            else if (BMenu.Chose == 2)
            {
                label6.Text += $"{ChooseHero.player1.Name}";
                label1.Text += $"{ChooseHero.player1.Health}";
                label2.Text += $"{ChooseHero.player1.ResistanceToPhysical}";
                label3.Text += $"{ChooseHero.player1.ResistanceToMagical}";
                label4.Text += $"{ChooseHero.player1.CriticalChance}";
                label5.Text += $"{ChooseHero.player1.AttackPower}";

                label8.Text += $"{ChooseHero.player2.Name}";
                label13.Text += $"{ChooseHero.player2.Health}";
                label12.Text += $"{ChooseHero.player2.ResistanceToPhysical}";
                label11.Text += $"{ChooseHero.player2.ResistanceToMagical}";
                label10.Text += $"{ChooseHero.player2.CriticalChance}";
                label9.Text += $"{ChooseHero.player2.AttackPower}";

                button10.Hide();
                button9.Hide();
                button8.Hide();
                button7.Hide();
                button6.Hide();

                int botchoiceshop = botChoiceShop.Next(1, 3);
                if (ChooseHero.player2.Health <= 100)
                {
                    MessageBox.Show($"Bot choosed: +20 health");
                    ChooseHero.player2.Health += 20;
                }
                else if (ChooseHero.player2.ResistanceToPhysical <= 10)
                {
                    MessageBox.Show($"Bot choosed: +3 Resistance To Physical");
                    ChooseHero.player2.ResistanceToPhysical += 3;
                }
                else if (ChooseHero.player2.ResistanceToMagical <= 10)
                {
                    MessageBox.Show($"Bot choosed: +3 Resistance To Magical");
                    ChooseHero.player2.ResistanceToMagical += 3;
                }
                else if (botchoiceshop <= 50)
                {
                    MessageBox.Show($"Bot choosed: +15 Critical chance");
                    ChooseHero.player2.CriticalChance += 15;
                }
                else if (botchoiceshop > 50)
                {
                    MessageBox.Show($"Bot choosed: +10 Attack Power");
                    ChooseHero.player2.AttackPower += 10;
                }
            }
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
            ChooseHero.player1.Health += 20;
            count1++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count1 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            ChooseHero.player1.ResistanceToPhysical += 3;
            count1++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count1 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            ChooseHero.player1.ResistanceToMagical += 3;
            count1++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (count1 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            ChooseHero.player1.CriticalChance += 15;
            count1++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (count1 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            ChooseHero.player1.AttackPower += 10;
            count1++;
        }



        private void button10_Click(object sender, EventArgs e)
        {
            if (count2 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            ChooseHero.player2.Health += 20;
            count2++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (count2 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            ChooseHero.player2.ResistanceToPhysical += 3;
            count2++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (count2 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            ChooseHero.player2.ResistanceToMagical += 3;
            count2++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (count2 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            ChooseHero.player2.CriticalChance += 15;
            count2++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (count2 == 1)
            {
                MessageBox.Show("Limit", "Error");
                return;
            }
            ChooseHero.player2.AttackPower += 10;
            count2++;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
