using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Game
    {
        public static int[] guessWork = new int[Menu.maxValue - Menu.minValue];
        public static int indx = 0;


        public static void GameProcess()
        {
            DiligentGamer dg = new DiligentGamer();
            SimpleGamer sg = new SimpleGamer();
            SimpleSmartGamer ssg = new SimpleSmartGamer();
            DiligentCheater dch = new DiligentCheater();
            SimpleCheater sch = new SimpleCheater();

            for(int i = 0; i < guessWork.Length; i++) { 
            
                dg.YourTurn();
                guessWork[indx] = dg.attempt;
                indx++;
            
                sg.YourTurn();
                guessWork[indx] = sg.attempt;
                indx++;         
            
                ssg.YourTurn();
                guessWork[indx] = ssg.attempt;
                indx++;           
            
                dch.YourTurn();
                guessWork[indx] = dch.attempt;
                indx++;
           
                sch.YourTurn();
                guessWork[indx] = sch.attempt;
                indx++;
    
            }
            
        }
    }
}

