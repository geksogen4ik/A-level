using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Str
    {
        string str = Console.ReadLine();
        string new_str = "not a palindrome";


        public bool Ref()
        {
            if (str.SequenceEqual(str.Reverse()))
                {
                return true;
                Console.WriteLine(str.Reverse());
            }
            return false;
            Console.WriteLine(new_str);

            

        }



    }
}


