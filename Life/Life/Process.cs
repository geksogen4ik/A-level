using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    public class Process
    {
        public static string[] checkers = { "lowChecker", "upChecker", "leftChecker", "leftUpDiagonalChecker", "leftLowDiagonalChecker", "rightChecker", "rightUpDiagonalChecker", "rightLowDiagonalChecker" };
      
        public static void Cycle()
        {
            int condition = 0;

            for (int x = 0; x < Store.arr.Length / 2; x++)
            {


                for (int y = 0; y < Store.arr.Length / 2; y++)
                {

                    string emptyChecker = Store.arr[x, y].ToString();
                    checkers[1] = Store.arr[x + 1, y].ToString(); //lowChecker
                    checkers[2] = Store.arr[x - 1, y].ToString(); //upChecker
                    checkers[3] = Store.arr[x, y - 1].ToString(); //leftChecker
                    checkers[4] = Store.arr[x - 1, y - 1].ToString(); //leftUpDiagonalChecker
                    checkers[5] = Store.arr[x + 1, y - 1].ToString(); //leftLowDiagonalChecker
                    checkers[6] = Store.arr[x, y + 1].ToString(); //rightChecker
                    checkers[7] = Store.arr[x - 1, y + 1].ToString(); //rightUpDiagonalChecker
                    checkers[8] = Store.arr[x + 1, y + 1].ToString(); //rightLowDiagonalChecker

                    if (string.IsNullOrWhiteSpace(emptyChecker))
                    {
                        for (int i = 0; i < checkers.Length; i++)
                        {
                            if (string.IsNullOrWhiteSpace(checkers[i]))
                            {
                                condition++;
                            }
                        }
                    }

                    if (condition == 3)
                    {
                        Store.arr[x, y] = '\u0223';
                    }

                    if (!string.IsNullOrWhiteSpace(emptyChecker))
                    {
                        for (int i = 0; i < checkers.Length; i++)
                        {
                            if (string.IsNullOrWhiteSpace(checkers[i]))
                            {
                                condition++;
                            }
                        }
                        if (condition < 2 || condition > 3)
                        {
                            emptyChecker = null;
                        }
                    }

                }
            }
            for (int x = 0; x < Store.arr.Length / 2; x++)
            {


                for (int y = 0; y < Store.arr.Length / 2; y++)
                {

                    Console.WriteLine(Store.arr);
                }

            }

           
            Console.ReadKey();
        }
    }
}

