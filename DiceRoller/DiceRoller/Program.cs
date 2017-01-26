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
            Dice dice = new Dice();
            dice = initializeSides(dice);
            int rollValue = rollDice(dice);
            displayRoll(rollValue);
        }

        static Dice initializeSides(Dice d)
        {
            bool notValid = true;

            while (notValid)
            {
                Console.Write("Enter the number of sides: ");
                try
                {
                    int s = Int32.Parse(Console.ReadLine());
                    if(s <= 0)
                    {
                        Console.WriteLine("Please enter in a value greater than 0.");
                        continue;
                    }
                    d.sides = s;
                    notValid = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect Input. Please try again.");

                }
               
            }
            return d;
        }


        static int rollDice(Dice d)
        {
           
            Console.Write("Press enter to roll the dice...");
            Console.ReadLine();
            Random rand = new Random();
            int roll = rand.Next(1, (d.sides + 1));
            return roll;
        }
        static void displayRoll(int r)
        {
            Console.WriteLine("You rolled a {0}!", r);
        }
    }
}
