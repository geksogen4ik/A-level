using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The 1th task");
            CheckAscending ch = new CheckAscending();
            ch.CheckIsAscending();

            Console.WriteLine("The 2th task");
            Population.CountYears(1000, 2, 50, 1200);
           

            Console.WriteLine("The 3th task");
            Str s = new Str();
            s.Ref();
            


        }
    }
}

