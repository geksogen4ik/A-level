using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        public static int round = 0;
        static void Main(string[] args)
        {
            Menu.Parametrs();
            Game.GameProcess();


            //for (int i = 0; i < Game.guessWork.Length; i++)
            //{
            //    Game.GameProcess();
            //    //round++;
            //    //Console.WriteLine($"The {round} is over");

            //    if (Game.guessWork[i] == Menu.guessedNumber)
            //    {
            //        Console.WriteLine("The game is Completed");
            //        break;
            //    }
            //    else
            //    {
            //        Game.GameProcess();
            //    }
            //}

        }
    }
}

