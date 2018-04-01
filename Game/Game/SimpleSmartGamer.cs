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
        public bool simpleSmartGamerWin = false;
        
        public void YourTurn()
        {

            Random random = new Random();
            attempt = random.Next(Menu.minValue, Menu.minValue);

            for (int i = 0; i < attempts.Length; i++)
            {
                attempts[i] = attempt;


                Console.WriteLine($"The Simple Smart Gamer's attempt is {attempt}");
                break;
            }

                if (attempt == Menu.guessedNumber)
                {
                    simpleSmartGamerWin = true;
                }
               
            }
            
        }
    }


