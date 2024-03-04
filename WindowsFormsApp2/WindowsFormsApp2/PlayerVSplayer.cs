using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace Myspace
{
    public partial class PlayerVSplayer : Form
    {
        public static Image image1;
        public static Image image2;
        public static Hero player1 = null;
        public static Hero player2 = null;
        public static Mage mage1 = new Mage("Mage", 500, 35, 10, 20, 40);
        public static Archer archer1 = new Archer("Archer", 450, 40, 15, 10, 50);
        public static Warrior warrior1 = new Warrior("Warrior", 600, 45, 30, 15, 20);

        public static Mage mage2 = new Mage("Mage", 500, 35, 10, 20, 40);
        public static Archer archer2 = new Archer("Archer", 450, 40, 15, 10, 50);
        public static Warrior warrior2 = new Warrior("Warrior", 600, 45, 30, 15, 20);
        public PlayerVSplayer()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form statisticPlayer = new ChoseHero(1);
            statisticPlayer.StartPosition = FormStartPosition.CenterScreen;
            statisticPlayer.ShowDialog();

            Form statisticPlayer2 = new ChoseHero(2);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
