﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class SimpleGamer : Gamers
    {
        public int attempt;
        public bool simpleGamerWin = false;

        public void YourTurn()
        {

            for (int i = 0; i < Menu.maxValue; i++)
            {
              
                attempt = Game.random.Next(Menu.minValue, Menu.minValue);
                Console.WriteLine($"The Simple Gamer's attempt is {attempt}");
                break;
            }

                if (attempt == Menu.guessedNumber)
                {
                    simpleGamerWin = true;
                }
               
            }

        }
    }

    


