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
        public bool diligentGamerWin = false;
        public void YourTurn()
        {
           
            while (attempt < Menu.maxValue) { 
                attempt++;
                Console.WriteLine($"The Diligent Gamer's attempt is {attempt}");
                break;

            }
            if(attempt == Menu.guessedNumber)
            {
                diligentGamerWin = true;
            }

        }

    }
}

