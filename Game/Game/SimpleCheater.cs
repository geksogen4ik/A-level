using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class SimpleCheater : Gamers

    {
        public int attempt;
        public int attempt1;
        public bool simpleCheaterWin = false;

        public void YourTurn()
        {

            for (int i = 0; i < Game.guessWork.Length; i++)
            {
                Random random = new Random();

                attempt1 = random.Next(Menu.minValue, Menu.minValue);

                if (attempt1 != Game.guessWork[i])
                {
                    attempt = attempt1;
                    Console.WriteLine($"The Simple Cheater Gamer's attempt is {attempt}");
                }
                else
                {
                    attempt1 = random.Next(Menu.minValue, Menu.minValue);
                }
                break;
            }

            if (attempt == Menu.guessedNumber)
            {
                simpleCheaterWin = true;
            }
        }
    }
}









