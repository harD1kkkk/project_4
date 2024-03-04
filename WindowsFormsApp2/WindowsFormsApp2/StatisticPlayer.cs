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
    public partial class StatisticPlayer : Form
    {
        public StatisticPlayer()
        {
            InitializeComponent();
            label6.Text += $"{ChooseHero.player1.Name}";
            label1.Text += $"{ChooseHero.player1.Health}";
            label2.Text += $"{ChooseHero.player1.ResistanceToPhysical}";
            label3.Text += $"{ChooseHero.player1.ResistanceToMagical}";
            label4.Text += $"{ChooseHero.player1.CriticalChance}";
            label5.Text += $"{ChooseHero.player1.AttackPower}";

            label12.Text += $"{ChooseHero.player2.Name}";
            label11.Text += $"{ChooseHero.player2.Health}";
            label10.Text += $"{ChooseHero.player2.ResistanceToPhysical}";
            label9.Text += $"{ChooseHero.player2.ResistanceToMagical}";
            label8.Text += $"{ChooseHero.player2.CriticalChance}";
            label7.Text += $"{ChooseHero.player2.AttackPower}";
        }

      

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StatisticPlayer_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
