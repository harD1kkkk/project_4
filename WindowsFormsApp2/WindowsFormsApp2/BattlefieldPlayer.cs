using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace Myspace
{
    public partial class BattlefieldPlayer : Form
    {
        public static int ChoseMap { get; set; }
        public BattlefieldPlayer()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChoseMap = 1;

            if (BMenu.Chose == 1)
            {
                BLocation.Storm(ChooseHero.mage1, ChooseHero.mage2, ChooseHero.archer1, ChooseHero.archer2, ChooseHero.warrior1, ChooseHero.warrior2);
                Form playerVSplayerBattle = new PlayerVSPlayerBattle();
                playerVSplayerBattle.StartPosition = FormStartPosition.Manual;
                playerVSplayerBattle.Height = this.Height;
                playerVSplayerBattle.Width = this.Width;
                playerVSplayerBattle.Location = this.Location;
                playerVSplayerBattle.Show();
                this.Hide();
            }
            else if (BMenu.Chose == 2)
            {

            }
            else if (BMenu.Chose == 3)
            {

            }
            else if (BMenu.Chose == 4)
            {

            }

        }

        private void BattlefieldPlayer_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChoseMap = 2;
            if (BMenu.Chose == 1)
            {
                BLocation.Forest(ChooseHero.mage1, ChooseHero.mage2, ChooseHero.archer1, ChooseHero.archer2, ChooseHero.warrior1, ChooseHero.warrior2);
                Form playerVSplayerBattle = new PlayerVSPlayerBattle();
                playerVSplayerBattle.StartPosition = FormStartPosition.Manual;
                playerVSplayerBattle.Height = this.Height;
                playerVSplayerBattle.Width = this.Width;
                playerVSplayerBattle.Location = this.Location;
                playerVSplayerBattle.Show();
                this.Hide();
            }
            else if (BMenu.Chose == 2)
            {
                BLocation.Forest(ChooseHero.mage1, ChooseHero.mage2, ChooseHero.archer1, ChooseHero.archer2, ChooseHero.warrior1, ChooseHero.warrior2);
                Form playerVSplayerBattle = new PlayerVSBot();
                playerVSplayerBattle.StartPosition = FormStartPosition.Manual;
                playerVSplayerBattle.Height = this.Height;
                playerVSplayerBattle.Width = this.Width;
                playerVSplayerBattle.Location = this.Location;
                playerVSplayerBattle.Show();
                this.Hide();
            }
            else if (BMenu.Chose == 3)
            {

            }
            else if (BMenu.Chose == 4)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChoseMap = 3;
            if (BMenu.Chose == 1)
            {
                BLocation.Desert(ChooseHero.mage1, ChooseHero.mage2, ChooseHero.archer1, ChooseHero.archer2, ChooseHero.warrior1, ChooseHero.warrior2);
                Form playerVSplayerBattle = new PlayerVSPlayerBattle();
                playerVSplayerBattle.StartPosition = FormStartPosition.Manual;
                playerVSplayerBattle.Height = this.Height;
                playerVSplayerBattle.Width = this.Width;
                playerVSplayerBattle.Location = this.Location;
                playerVSplayerBattle.Show();
                this.Hide();
            }
            else if (BMenu.Chose == 2)
            {

            }
            else if (BMenu.Chose == 3)
            {

            }
            else if (BMenu.Chose == 4)
            {

            }
        }
    }
}
