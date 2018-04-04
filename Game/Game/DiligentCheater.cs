using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class DiligentCheater : Gamers
    {
        public int attempt;
        public int attempt1 = Menu.minValue;
        public bool diligentCheaterWin = false;
        public void YourTurn()
        {
            for (int i = 0; i < Game.guessWork.Length; i++)
            {
               

                attempt1++;

                for (int j = 0; j < Game.guessWork.Length; j++)
                {
                    if (attempt1 != Game.guessWork[j])
                    {
                        attempt = attempt1;
                        Console.WriteLine($"The Diigent Cheater Gamer's attempt is {attempt}");
                    }
                    else
                    {
                        attempt = attempt1++;
                    }

                    break;
                }

                break;
            }
                if (attempt == Menu.guessedNumber)
                {
                    diligentCheaterWin = true;
                }
            }

        }
    }

    


