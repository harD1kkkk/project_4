using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Myspace
{
    public partial class PlayerVSPlayerBattle : Form
    {
        private Random random = new Random();
        private int count1 = 0;
        private int count2 = 0;

        private int timeMin = 0;
        private int timeSeconds = 0;

        private Round round1 = new Round();
        private Round round2 = new Round();

        private int countShop = 0;

        private int currentPlayer = 0;

        private int round = 1;
        public PlayerVSPlayerBattle()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            PictureBox pictureBox1 = new PictureBox();
            System.Drawing.Image image1 = PlayerVSplayer.image1;
            pictureBox1.Location = new Point(16, 134);
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Size = new Size(image1.Width, image1.Height);
            pictureBox1.Image = image1;
            this.Controls.Add(pictureBox1);

            PictureBox pictureBox2 = new PictureBox();
            System.Drawing.Image image2 = PlayerVSplayer.image2;
            pictureBox2.Location = new Point(1513, 138);
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Size = new Size(image2.Width, image2.Height);
            pictureBox2.Image = image2;
            this.Controls.Add(pictureBox2);

            if (BattlefieldPlayer.ChoseMap == 1)
            {
                this.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\student\\source\\repos\\WindowsFormsApp2\\WindowsFormsApp2\\assets\\jpg");
            }
            else if (BattlefieldPlayer.ChoseMap == 2)
            {
                this.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\student\\source\\repos\\WindowsFormsApp2\\WindowsFormsApp2\\assets\\Forest.jpg");
            }
            else if (BattlefieldPlayer.ChoseMap == 3)
            {
                this.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\student\\source\\repos\\WindowsFormsApp2\\WindowsFormsApp2\\assets\\1660691661_1-kartinkin-net-p-anime-fon-pole-boya-krasivo-2.jpg");
            }
            label2.Text = $"{PlayerVSplayer.player1.Name}";
            label1.Text = $"Health: {PlayerVSplayer.player1.Health}";
            label3.Text = $"Damage: 0";

            label5.Text = $"{PlayerVSplayer.player2.Name}";
            label4.Text = $"Health: {PlayerVSplayer.player2.Health}";
            label6.Text = $"Damage: 0";

            currentPlayer = random.Next(1, 3);
            label7.Text = $"current Player: {currentPlayer}";

            label8.Text = $"Def: 3/0";
            label9.Text = $"Def: 3/0";

            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;

            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;

            label10.Visible = false;
            label11.Visible = false;

        }

        private void PlayerVSPlayerBattle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (PlayerVSplayer.player1.Health <= 0 || PlayerVSplayer.player2.Health <= 0)
            {
                if (PlayerVSplayer.player1.Health <= 0)
                {
                    MessageBox.Show("Player 2 has won the battle!", "Won");
                    return;
                }
                else if (PlayerVSplayer.player2.Health <= 0)
                {
                    MessageBox.Show("Player 1 has won the battle!", "Won");
                    return;
                }
            }

            if (currentPlayer == 1)
            {
                Form attacks = new Attacks();
                attacks.StartPosition = FormStartPosition.CenterScreen;
                attacks.ShowDialog();

                double damageDealt = 0;
                Attack selectedAttack;
                if (Attacks.attack == Attack.Physical)
                {
                    selectedAttack = Attack.Physical;
                    damageDealt = PlayerVSplayer.player1.AttackPow(selectedAttack, PlayerVSplayer.player1.AttackPower);
                    if (damageDealt <= 0)
                    {
                        PlayerVSplayer.player2.Health -= damageDealt;
                    }
                    else if (damageDealt > 0)
                    {
                        damageDealt -= PlayerVSplayer.player2.ResistanceToPhysical;
                        round1.PhysicalDamage += damageDealt;
                        label3.Text = $"Damage: {damageDealt}";
                        PlayerVSplayer.player2.Health -= damageDealt;
                    }
                }
                else if (Attacks.attack == Attack.Magical)
                {
                    selectedAttack = Attack.Magical;
                    damageDealt = PlayerVSplayer.player1.AttackPow(selectedAttack, PlayerVSplayer.player1.AttackPower);
                    if (damageDealt <= 0)
                    {
                        PlayerVSplayer.player2.Health -= damageDealt;
                    }
                    else if (damageDealt > 0)
                    {
                        damageDealt -= PlayerVSplayer.player2.ResistanceToPhysical;
                        round1.MagicDamage += damageDealt;
                        label3.Text = $"Damage: {damageDealt}";
                        PlayerVSplayer.player2.Health -= damageDealt;
                    }
                }
                label1.Text = $"Health: {PlayerVSplayer.player1.Health}";
                label4.Text = $"Health: {PlayerVSplayer.player2.Health}";
                label11.Text = $"Player1 with HERO:{PlayerVSplayer.player1.Name} attack with DAMAGE: {damageDealt}  Player2 with HERO:{PlayerVSplayer.player2.Name}";
                label11.Visible = true;
            }

            else if (currentPlayer == 2)
            {
                Form attacks = new Attacks();
                attacks.StartPosition = FormStartPosition.CenterScreen;
                attacks.ShowDialog();

                double damageDealt = 0;
                Attack selectedAttack;
                if (Attacks.attack == Attack.Physical)
                {
                    selectedAttack = Attack.Physical;
                    damageDealt = PlayerVSplayer.player2.AttackPow(selectedAttack, PlayerVSplayer.player2.AttackPower);
                    if (damageDealt <= 0)
                    {
                        PlayerVSplayer.player1.Health -= damageDealt;
                    }
                    else if (damageDealt > 0)
                    {
                        damageDealt -= PlayerVSplayer.player1.ResistanceToPhysical;
                        round2.PhysicalDamage += damageDealt;
                        label6.Text = $"Damage: {damageDealt}";
                        PlayerVSplayer.player1.Health -= damageDealt;
                    }
                }
                else if (Attacks.attack == Attack.Magical)
                {
                    selectedAttack = Attack.Magical;
                    damageDealt = PlayerVSplayer.player2.AttackPow(selectedAttack, PlayerVSplayer.player2.AttackPower);
                    if (damageDealt <= 0)
                    {
                        PlayerVSplayer.player1.Health -= damageDealt;
                    }
                    else if (damageDealt > 0)
                    {
                        damageDealt -= PlayerVSplayer.player1.ResistanceToPhysical;
                        round2.MagicDamage += damageDealt;
                        label6.Text = $"Damage: {damageDealt}";
                        PlayerVSplayer.player1.Health -= damageDealt;
                    }
                }

                label1.Text = $"Health: {PlayerVSplayer.player1.Health}";
                label4.Text = $"Health: {PlayerVSplayer.player2.Health}";
                label11.Text = $"Player2 with HERO:{PlayerVSplayer.player2.Name} attack with DAMAGE: {damageDealt}  Player1 with HERO:{PlayerVSplayer.player1.Name}";
                label11.Visible = true;
            }


            if (countShop == 5)
            {
                Form shop = new Shop();
                shop.StartPosition = FormStartPosition.CenterScreen;
                shop.ShowDialog();
                countShop = 0;
            }

            currentPlayer = (currentPlayer % 2) + 1;
            label10.Text = $"Round: {round++}";
            label10.Visible = true;
            label7.Text = $"current Player: {currentPlayer}";
            countShop++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form statisticPlayer = new StatisticPlayer();
            statisticPlayer.StartPosition = FormStartPosition.CenterScreen;
            statisticPlayer.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (currentPlayer == 1)
            {
                if (count1 == 3)
                {
                    MessageBox.Show("Limit", "Error");
                    return;
                }
                PlayerVSplayer.player1.ResistanceToPhysical += 3;
                PlayerVSplayer.player1.ResistanceToMagical += 3;

                count1++;
                label8.Text = $"Def: 3/{count1}";
                label11.Text = $"Player1 with HERO:{PlayerVSplayer.player1.Name}  defends and increases resistance";
                label11.Visible = true;
            }
            else if (currentPlayer == 2)
            {
                if (count2 == 3)
                {
                    MessageBox.Show("Limit", "Error");
                    return;
                }
                PlayerVSplayer.player2.ResistanceToPhysical += 3;
                PlayerVSplayer.player2.ResistanceToMagical += 3;

                count2++;
                label9.Text = $"Def: 3/{count2}";
                label11.Text = $"Player2 with HERO:{PlayerVSplayer.player2.Name}  defends and increases resistance";
                label11.Visible = true;
            }
            currentPlayer = (currentPlayer % 2) + 1;
            label10.Text = $"Round: {round++}";
            label10.Visible = true;
            label7.Text = $"current Player: {currentPlayer}";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeSeconds++;
            if (timeSeconds < 10)
            {
                label12.Text = $"{timeMin}:0{timeSeconds}";
            }
            else if (timeSeconds > 10 && timeSeconds < 60) 
            {
                label12.Text = $"{timeMin}:{timeSeconds}";
            }
            else if (timeSeconds > 60)
            {
                timeSeconds = 0;
                timeMin++;
                label12.Text = $"{timeMin}:{timeSeconds}";
            }
        }
    }

}
