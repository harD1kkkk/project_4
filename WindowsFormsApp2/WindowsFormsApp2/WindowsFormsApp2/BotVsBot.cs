﻿using System;

namespace Myspace
{
    static class BotVsBot
    {
        public static void botVsBot()
        {
            Round roundBot1 = new Round();
            Round roundBot2 = new Round();

            // Create the characters
            Mage mage1 = new Mage("Mage", 500, 35, 10, 20, 40);
            Archer archer1 = new Archer("Archer", 450, 40, 15, 10, 50);
            Warrior warrior1 = new Warrior("Warrior", 600, 45, 30, 15, 20);

            Mage mage2 = new Mage("Mage", 500, 35, 10, 20, 40);
            Archer archer2 = new Archer("Archer", 450, 40, 15, 10, 50);
            Warrior warrior2 = new Warrior("Warrior", 600, 45, 30, 15, 20);

            Random botChoiceMenu1 = new Random();
            int botchoicemenu1 = botChoiceMenu1.Next(1, 4);
            Hero bot1 = null;
            switch (botchoicemenu1)
            {
                case 1:
                    Console.WriteLine("Bot1: Choosed Mage");
                    bot1 = mage1;
                    break;
                case 2:
                    Console.WriteLine("Bot1: Choosed Archer");
                    bot1 = archer1;
                    break;
                case 3:
                    Console.WriteLine("Bot1: Choosed Warrior");
                    bot1 = warrior1;
                    break;
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();

            Random botChoiceMenu2 = new Random();
            int botchoicemenu2 = botChoiceMenu2.Next(1, 4);
            Hero bot2 = null;
            switch (botchoicemenu2)
            {
                case 1:
                    Console.WriteLine("Bot2: Choosed Mage");
                    bot2 = mage2;
                    break;
                case 2:
                    Console.WriteLine("Bot2: Choosed Archer");
                    bot2 = archer2;
                    break;
                case 3:
                    Console.WriteLine("Bot2: Choosed Warrior");
                    bot2 = warrior2;
                    break;
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();

            Random Battlefield = new Random();
            int battlefield = Battlefield.Next(1, 4);
            if (battlefield == 1)
            {
                Console.WriteLine("Randomly choosed Storm");
                BLocation.Storm(mage1, mage2, archer1, archer2, warrior1, warrior2);
            }
            else if (battlefield == 2)
            {
                Console.WriteLine("Randomly choosed Forest");
                BLocation.Forest(mage1, mage2, archer1, archer2, warrior1, warrior2);
            }
            else
            {
                Console.WriteLine("Randomly choose Desert");
                BLocation.Desert(mage1, mage2, archer1, archer2, warrior1, warrior2);
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();

            // Start the battle
            Random random = new Random();

            // Choose the first player randomly
            int currentPlayer = random.Next(1, 3);
            int countBot1 = 0;
            int countBot2 = 0;
            int countShop = 0;
            while (bot1.Health > 0 && bot2.Health > 0)
            {
                int action;
                Attack selectedAttack;

                if (countShop == 5)
                {
                    Console.WriteLine("Bot1 statistic");
                    PrintManager.printStatistic(bot1);
                    BotLogic.botLogicShop(bot1);

                    Console.WriteLine();
                    System.Threading.Thread.Sleep(1000);

                    Console.WriteLine("Bot2 statistic");
                    PrintManager.printStatistic(bot2);
                    BotLogic.botLogicShop(bot2);
                    countShop = 0;
                }

                Console.WriteLine();
                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("Current bot: " + currentPlayer);
                System.Threading.Thread.Sleep(1000);

                if (currentPlayer == 1)
                {
                    if (countBot1 == 3)
                    {
                        action = 1;
                    }
                    else
                    {
                        action = BotLogic.botLogicBot1VSBot2(bot1, bot2);
                    }

                    if (action == 1)
                    {
                        selectedAttack = PrintManager.printAttackTypeBot(bot1, mage1, archer1);
                        PrintManager.printActionBot1(selectedAttack, bot1, bot2, roundBot1);
                        System.Threading.Thread.Sleep(1000);
                    }
                    else if (action == 2) // Defend
                    {
                        // Increase the resistance of the Bot
                        PrintManager.printDefend(bot1);
                        PrintManager.printDefendsBot(bot1);
                        countBot1++;
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(1000);
                    }
                }
                else
                {
                    if (countBot2 == 3)
                    {
                        action = 1;
                    }
                    else
                    {
                        action = BotLogic.botLogicBot2VSBot1(bot1, bot2);
                    }

                    if (action == 1)
                    {
                        selectedAttack = PrintManager.printAttackTypeBot(bot2, mage2, archer2);
                        PrintManager.printActionBot2(selectedAttack, bot2, bot1, roundBot2);
                        System.Threading.Thread.Sleep(1000);
                    }
                    else if (action == 2) // Defend
                    {
                        // Increase the resistance of the Bot
                        PrintManager.printDefend(bot2);
                        PrintManager.printDefendsBot(bot2);
                        countBot2++;
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(1000);
                    }
                }
                currentPlayer = (currentPlayer % 2) + 1;
                countShop++;

                // Declare the winner
                PrintManager.printWinnerBotvsBot(bot1, bot2, roundBot1, roundBot2);
                Console.WriteLine();
            }
        }
    }
}
