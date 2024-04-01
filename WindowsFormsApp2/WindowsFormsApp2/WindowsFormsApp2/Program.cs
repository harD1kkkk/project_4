﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace Myspace
{

    public enum Attack
    {
        Physical,
        Magical
    }
    public enum Action
    {
        Attack,
        Defend
    }



    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMenu());

            bool exit = true;
            while (exit)
            {
                Console.WriteLine("Make your choice:");
                Console.WriteLine("player vs player - 1");
                Console.WriteLine("player vs bot - 2");
                Console.WriteLine("bot vs bot - 3");
                Console.WriteLine("Levels - 4");
                Console.WriteLine("exit - 5");
                if (Int32.TryParse(Console.ReadLine(), out int playerChoice) == false || playerChoice == 0 || playerChoice > 5)
                {
                    Console.WriteLine("Error.You entered an incorrect value");
                }
                else if (playerChoice == 1)
                {
                    StartPlayer.startPlayer();
                }
                else if (playerChoice == 2)
                {
                    StartBot.startBot();
                }
                else if (playerChoice == 3)
                {
                    BotVsBot.botVsBot();
                }
                else if (playerChoice == 4)
                {
                    Levels.levels();
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    exit = false;
                }
            }
        }
    }
}