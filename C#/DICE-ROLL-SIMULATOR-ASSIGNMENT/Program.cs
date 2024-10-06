using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int menuOption;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Roll Dice Once");
                Console.WriteLine("2. Roll Dice 5 Times");
                Console.WriteLine("3. Roll Dice 'n' Times");
                Console.WriteLine("4. Roll Dice until two 1's");
                Console.WriteLine("5. Exit");

                menuOption = int.Parse(Console.ReadLine());

                switch (menuOption)
                {
                    case 1:
                        int dice1 = rnd.Next(1, 7);
                        int dice2 = rnd.Next(1, 7);
                        int sum = dice1 + dice2;
                        Console.WriteLine("You rolled a " + dice1 + " and a " + dice2 + " for a sum of " + sum);
                        break;
                    case 2:
                        for (int i = 0; i < 5; i++)
                        {
                            int dice3 = rnd.Next(1, 7);
                            int dice4 = rnd.Next(1, 7);
                            int sum2 = dice3 + dice4;
                            Console.WriteLine("You rolled a " + dice3 + " and a " + dice4 + " for a sum of " + sum2);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the number of rolls:");
                        int rolls = int.Parse(Console.ReadLine());
                        for (int i = 0; i < rolls; i++)
                        {
                            int dice5 = rnd.Next(1, 7);
                            int dice6 = rnd.Next(1, 7);
                            int sum3 = dice5 + dice6;
                            Console.WriteLine("You rolled a " + dice5 + " and a " + dice6 + " for a sum of " + sum3);
                        }
                        break;
                    case 4:
                        int dice7, dice8, rollsUntilDoubleOnes = 0;
                        do
                        {
                            dice7 = rnd.Next(1, 7);
                            dice8 = rnd.Next(1, 7);
                            int sum4 = dice7 + dice8;
                            Console.WriteLine("You rolled a " + dice7 + " and a " + dice8 + " for a sum of " + sum4);
                            rollsUntilDoubleOnes++;
                        } while (dice7 != 1 || dice8 != 1);
                        Console.WriteLine("It took " + rollsUntilDoubleOnes + " rolls to roll two 1's");
                        break;
                    case 5:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            } while (menuOption != 5);
        }
    }
}
