using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_game
{
    class Program
    {
        public static int min = 1;
        public static int max = 101;
        public static string choice = "";
        public static bool gameOver = false;

        static void Main(string[] args)
        {


            //ask to think of number
            Console.WriteLine("Think of a number 1-100");
            Console.ReadKey();

            while (gameOver == false)
            {
                //Generate number and print it
                Random random = new Random();
                int guess = random.Next(min, max);

                Console.WriteLine();


                //ask if that's their number
                Console.WriteLine("Is this your number?:" + guess);
                Console.WriteLine("1: Yes 2: No");
                choice = Console.ReadLine();

                //if yes
                if (choice == "1")
                {
                    //end
                    gameOver = true;
                    Console.WriteLine("Game Over");
                    Console.ReadKey();
                }

                //if no
                if (choice == "2")
                {
                    //ask user if higher or lower
                    Console.WriteLine("Is your number higher or lower than the shown value?");
                    Console.WriteLine("1: Higher 2: Lower");
                    choice = Console.ReadLine();

                    //if higher
                    if (choice == "1")
                    {
                        min = guess + 1;
                    }

                    //if lower
                    if (choice == "2")
                    {
                        max = guess;
                    }
                }

                //if player cheats
                if (min == max || min <= 0 || max >= 102)
                {
                    Console.WriteLine("liar detected! I can't believe you've done this!");
                    gameOver = true;
                    Console.ReadKey();
                }

            }

        }
    }
}
