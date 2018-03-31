using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class DiligentGamer : Gamers
    {
        public int attempt = Menu.minValue;
        public void YourTurn()
        {
            for (int i = 0; i < Menu.maxValue; i++)
            {
                attempt = attempt++;
                Console.WriteLine($"The Diligent Gamer's attempt is {attempt}");
               
            }
        }
        
    }
}
