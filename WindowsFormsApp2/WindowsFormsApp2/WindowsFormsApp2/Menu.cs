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
    public partial class BMenu : Form
    {
        public static Image mage = Image.FromFile("C:\\Users\\student\\source\\repos\\WindowsFormsApp2\\WindowsFormsApp2\\assets\\Mage.jpg");
        public static Image archer = Image.FromFile("C:\\Users\\student\\source\\repos\\WindowsFormsApp2\\WindowsFormsApp2\\assets\\Archer.jpg");
        public static Image warrior = Image.FromFile("C:\\Users\\student\\source\\repos\\WindowsFormsApp2\\WindowsFormsApp2\\assets\\Warrior.jpg");
        public static int Chose {  get; set; }
        public BMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int playerChoice = Int32.Parse(textBox1.Text.ToString());
            Chose = playerChoice;
            if (playerChoice == 0 || playerChoice > 5)
            {
                MessageBox.Show("You entered an incorrect value", "Error");
                return;

            }
            else if (playerChoice == 1)
            {
                Form playerVSplayer = new ChooseHero(1);
                playerVSplayer.StartPosition = FormStartPosition.Manual;
                playerVSplayer.Height = this.Height;
                playerVSplayer.Width = this.Width;
                playerVSplayer.Location = this.Location;
                playerVSplayer.Show();
                this.Hide();
            }
            else if (playerChoice == 2)
            {
                Form playerVSplayer = new ChooseHero(2);
                playerVSplayer.StartPosition = FormStartPosition.Manual;
                playerVSplayer.Height = this.Height;
                playerVSplayer.Width = this.Width;
                playerVSplayer.Location = this.Location;
                playerVSplayer.Show();
                this.Hide();
            }
            else if (playerChoice == 3)
            {
                BotVsBot.botVsBot();
            }
            else if (playerChoice == 4)
            {
                Levels.levels();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
