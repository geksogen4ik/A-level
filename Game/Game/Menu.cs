using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Menu {

        public static int maxValue;
        public static int minValue;
        public static int guessedNumber;


        public static void Parametrs() {
        

            Console.WriteLine("Enter max value");
                try
                {
                   maxValue = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("You should enter the numbers only");
                    Console.WriteLine("Enter max value");
                     Int32.TryParse(Console.ReadLine(), out maxValue);
                }
 
           
                Console.WriteLine("Enter the min value");
                try
                {
                      minValue = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("You should enter the numbers only");
                    Console.WriteLine("Enter min value");
                    Int32.TryParse(Console.ReadLine(), out minValue);

            }

                Console.WriteLine("Enter the guessed value");
                try
                {
                    guessedNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("You should enter the numbers only");
                    Console.WriteLine("Enter the guessed value");
                    Int32.TryParse(Console.ReadLine(), out guessedNumber);
            }
            }
        }

}

    

