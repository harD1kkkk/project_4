using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            if (BMenu.Chose == 1)
            {
                int choice = Int32.Parse(textBox1.Text.ToString());
                ChoseMap = choice;
                if (choice == 0 || choice > 3)
                {
                    MessageBox.Show("You entered an incorrect value", "Error");
                    return;
                }
                switch (choice)
                {
                    case 1:
                        BLocation.Storm(PlayerVSplayer.mage1, PlayerVSplayer.mage2, PlayerVSplayer.archer1, PlayerVSplayer.archer2, PlayerVSplayer.warrior1, PlayerVSplayer.warrior2);
                        break;
                    case 2:
                        BLocation.Forest(PlayerVSplayer.mage1, PlayerVSplayer.mage2, PlayerVSplayer.archer1, PlayerVSplayer.archer2, PlayerVSplayer.warrior1, PlayerVSplayer.warrior2);
                        break;
                    case 3:
                        BLocation.Desert(PlayerVSplayer.mage1, PlayerVSplayer.mage2, PlayerVSplayer.archer1, PlayerVSplayer.archer2, PlayerVSplayer.warrior1, PlayerVSplayer.warrior2);
                        break;
                }

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
            else if(BMenu.Chose == 4) {
            
            }

        }

        private void BattlefieldPlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
