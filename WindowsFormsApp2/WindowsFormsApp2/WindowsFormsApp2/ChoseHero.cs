using Myspace;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ChoseHero : Form
    {
        private int num;
        public ChoseHero(int num)
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
                PlayerVSplayer.player1 = PlayerVSplayer.mage1;
                PlayerVSplayer.image1 = BMenu.mage;
                this.Close();
            }
            PlayerVSplayer.player2 = PlayerVSplayer.mage2;
            PlayerVSplayer.image2 = BMenu.mage;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                PlayerVSplayer.player1 = PlayerVSplayer.archer1;
                PlayerVSplayer.image1 = BMenu.archer;
                this.Close();
            }
            PlayerVSplayer.player2 = PlayerVSplayer.archer2;
            PlayerVSplayer.image2 = BMenu.archer;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                PlayerVSplayer.player1 = PlayerVSplayer.warrior1;
                PlayerVSplayer.image1 = BMenu.warrior;
                this.Close();
            }
            PlayerVSplayer.player2 = PlayerVSplayer.warrior2;
            PlayerVSplayer.image2 = BMenu.warrior;
            this.Close();
        }
    }
}
