using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public static class Game
    {
        //public static int[] guessWork = new int[Menu.maxValue - Menu.minValue];
        //public static int indx;
        public static int[] guessWork;
        public static Random random = new Random();
        public static void GameProcess()
        {
            guessWork = new int[Menu.maxValue - Menu.minValue];
            Console.WriteLine(guessWork.Length);

            DiligentGamer dg = new DiligentGamer();
            SimpleGamer sg = new SimpleGamer();
            SimpleSmartGamer ssg = new SimpleSmartGamer();
            DiligentCheater dch = new DiligentCheater();
            SimpleCheater sch = new SimpleCheater();

            for (int i = 0; i < guessWork.Length; i++)
            {

                dg.YourTurn();
                guessWork[i] = dg.attempt;

                sg.YourTurn();
                guessWork[i] = sg.attempt;

                ssg.YourTurn();
                guessWork[i] = ssg.attempt;
     
                dch.YourTurn();
                guessWork[i] = dch.attempt;

                sch.YourTurn();
                guessWork[i] = sch.attempt;

                if (dg.diligentGamerWin == true)
                {
                    Console.WriteLine("Diligent Gamer is winner");
                    break;
                }

                if(sg.simpleGamerWin == true)
                {
                    Console.WriteLine("Simple Gamer is winner");
                    break;
                }

                if(ssg.simpleSmartGamerWin == true)
                {
                    Console.WriteLine("Simple Smart Gamer is winner");
                    break;
                }

                if(dch.diligentCheaterWin == true)
                {
                    Console.WriteLine("Diligent Cheater is winner");
                    break;
                }
                if(sch.simpleCheaterWin == true)
                {
                    Console.WriteLine("Simple Cheater is winner");
                    break;
                }

            }
            Console.ReadKey();

        }
    }
}


