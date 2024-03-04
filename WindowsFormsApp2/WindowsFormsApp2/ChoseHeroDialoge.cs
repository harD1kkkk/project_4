using Myspace;
using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ChoseHeroDialoge : Form
    {
   
        private int num;
        public ChoseHeroDialoge(int num)
        {
            InitializeComponent();
            this.num = num;
            if (num == 1)
            {
                label1.Text = $"Player1, choose your character:\r\n";
            }
            else if (num == 2)
            {
                label1.Text = $"Player2, choose your character:\r\n";
            }
        }

        private void ChoseHero_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                ChooseHero.player1 = ChooseHero.mage1;
                ChooseHero.image1 = BMenu.mage;
                this.Close();
            }
            ChooseHero.player2 = ChooseHero.mage2;
            ChooseHero.image2 = BMenu.mage;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                ChooseHero.player1 = ChooseHero.archer1;
                ChooseHero.image1 = BMenu.archer;
                this.Close();
            }
            ChooseHero.player2 = ChooseHero.archer2;
            ChooseHero.image2 = BMenu.archer;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                ChooseHero.player1 = ChooseHero.warrior1;
                ChooseHero.image1 = BMenu.warrior;
                this.Close();
            }
            ChooseHero.player2 = ChooseHero.warrior2;
            ChooseHero.image2 = BMenu.warrior;
            this.Close();
        }
    }
}
