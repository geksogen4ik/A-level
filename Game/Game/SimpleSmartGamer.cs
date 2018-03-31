using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class SimpleSmartGamer : Gamers
    {
        public static int[] attempts = new int[Menu.maxValue - Menu.minValue];
        public int attempt;
        int index = 0;
        public void YourTurn()
        {
            for(int i = 0; i < Menu.maxValue; i++)
            {
                Random random = new Random();
                attempt = random.Next(Menu.minValue, Menu.minValue);
                attempts[index] = attempt;
                index++;
                Console.WriteLine($"The Simple Smart Gamer's attempt is {attempt}");
                
            }
        }
    }
}
