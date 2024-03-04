using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace Myspace
{
    public partial class ChooseHero : Form
    {
        private Random botChoice = new Random();
        private int num;
        public static Image image1;
        public static Image image2;
        public static Hero player1 = null;
        public static Hero player2 = null;
        public static Mage mage1;
        public static Archer archer1;
        public static Warrior warrior1;

        public static Mage mage2;
        public static Archer archer2;
        public static Warrior warrior2;
        public ChooseHero(int num)
        {
            InitializeComponent();
            this.num = num;
            label1.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                mage1 = new Mage("Mage", 500, 35, 10, 20, 40);
                archer1 = new Archer("Archer", 450, 40, 15, 10, 50);
                warrior1 = new Warrior("Warrior", 600, 45, 30, 15, 20);

                mage2 = new Mage("Mage", 500, 35, 10, 20, 40);
                archer2 = new Archer("Archer", 450, 40, 15, 10, 50);
                warrior2 = new Warrior("Warrior", 600, 45, 30, 15, 20);

                Form statisticPlayer = new ChoseHeroDialoge(1);
                statisticPlayer.StartPosition = FormStartPosition.CenterScreen;
                statisticPlayer.ShowDialog();

                Form statisticPlayer2 = new ChoseHeroDialoge(2);
                statisticPlayer2.StartPosition = FormStartPosition.CenterScreen;
                statisticPlayer2.ShowDialog();

                Form Battlefield = new BattlefieldPlayer();
                Battlefield.StartPosition = FormStartPosition.Manual;
                Battlefield.Height = this.Height;
                Battlefield.Width = this.Width;
                Battlefield.Location = this.Location;
                Battlefield.Show();
                this.Hide();
            }
            else if (num == 2)
            {
                mage1 = new Mage("Mage", 500, 35, 10, 20, 40);
                archer1 = new Archer("Archer", 450, 40, 15, 10, 50);
                warrior1 = new Warrior("Warrior", 600, 45, 30, 15, 20);

                mage2 = new Mage("Mage", 500, 35, 10, 20, 40);
                archer2 = new Archer("Archer", 450, 40, 15, 10, 50);
                warrior2 = new Warrior("Warrior", 600, 45, 30, 15, 20);

                Form statisticPlayer = new ChoseHeroDialoge(1);
                statisticPlayer.StartPosition = FormStartPosition.CenterScreen;
                statisticPlayer.ShowDialog();

                int botchoice = botChoice.Next(1, 4);
                switch (botchoice)
                {
                    case 1:
                        ChooseHero.player2 = ChooseHero.mage2;
                        ChooseHero.image2 = BMenu.mage;
                        break;
                    case 2:
                        ChooseHero.player2 = ChooseHero.archer2;
                        ChooseHero.image2 = BMenu.archer;
                        break;
                    case 3:
                        ChooseHero.player2 = ChooseHero.warrior2;
                        ChooseHero.image2 = BMenu.warrior;
                        break;
                }

                MessageBox.Show($"Bot chosed {player2.Name}");
                Form Battlefield = new BattlefieldPlayer();
                Battlefield.StartPosition = FormStartPosition.Manual;
                Battlefield.Height = this.Height;
                Battlefield.Width = this.Width;
                Battlefield.Location = this.Location;
                Battlefield.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
