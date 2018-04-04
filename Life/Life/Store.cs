using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    public static class Store
    {
        public static char[,] arr = new char[20, 20];
        public static bool flow = true;

        public static void Filling()
        {
            for (int i = 0; i < Store.arr.Length / 2; i++)
            {
                arr[7, 9] = '\u0223';
                arr[8, 9] = '\u0223';
                arr[9, 9] = '\u0223';

            }

        }
    }
}
