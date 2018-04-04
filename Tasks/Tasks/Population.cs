using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Population
    {
        static int years = 0;
        public static void CountYears(int default_people, int percent, int foreign, int target_population)
        {
            int currant_population = 0;
            default_people = currant_population;

            do
            {
                currant_population = default_people + currant_population * (percent / 100) + foreign;
                years++;

            }
            while (target_population <= 1200);
            Console.WriteLine($"{years} years");
            Console.ReadKey();
        }
       
        }
    
    }

