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
        public void YourTurn()
        {
            for (int i = 0; i < Menu.maxValue; i++)
            {
                Random random = new Random();

                attempt1++;

                for(int j = 0; j < Game.guessWork.Length; j++)
                {
                    if(attempt1 != Game.guessWork[i])
                    {
                        attempt = attempt1;
                        Console.WriteLine($"The Diigent Cheater Gamer's attempt is {attempt}");
                    }
                    else
                    {
                        attempt = attempt1++;
                    }
                    
                }
                
                
            }
        }
    }
}
