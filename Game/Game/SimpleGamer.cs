using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class SimpleGamer : Gamers
    {
        public int attempt;
      
        public void YourTurn()
        {
            for (int i = 0; i < Menu.maxValue; i++)
            {
                Random random = new Random();
                attempt = random.Next(Menu.minValue, Menu.minValue);
                Console.WriteLine($"The Simple Gamer's attempt is {attempt}");
                
            }
            
           
        }
    }
}

