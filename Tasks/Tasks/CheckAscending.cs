using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class CheckAscending
    {
        int[] array1 = new int[] { 1, 2, 4, 7, 19 };
        int[] array2 = new int[] { 1, 2, 3, 4, 5 };
        int[] array3 = new int[] { 1, 6, 10, 18, 2, 4, 20 };
        int[] array4 = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };


        public bool IsAscending = true;
        public void CheckIsAscending()
        {

            while (IsAscending)
            {
                for (int i = 0; i < array1.Length-1; i++)
                {
                    if (array1[i] < array4[i + 1])
                    {

                        Console.WriteLine("Array1 is Ascending");
                        break;
                    }
                    else
                    {
                        IsAscending = false;
                        Console.WriteLine("Array1 is Discending");
                        break;
                    }
                }




                for (int i = 0; i < array2.Length-1; i++)
                {
                    if (array2[i] < array4[i + 1])
                    {

                        Console.WriteLine("Array2 is Ascending");
                        break;
                    }
                    else
                    {
                        IsAscending = false;
                        Console.WriteLine("Array2 is Discending");
                        break;
                    }
                }




                for (int i = 0; i < array3.Length-1; i++)
                {
                    if (array3[i] < array4[i + 1])
                    {

                        Console.WriteLine("Array3 is Ascending");
                        break;
                    }
                    else
                    {
                        IsAscending = false;
                        Console.WriteLine("Array3 is Discending");
                        break;
                    }
                }




                for (int i = 0; i < array4.Length-1; i++)
                {
                    if (array4[i] < array4[i+1])
                    {

                        Console.WriteLine("Array4 is Ascending");
                        break;
                    }
                    else
                    {
                        IsAscending = false;
                        Console.WriteLine("Array4 is Discending");
                        break;
                    }

                    
                }

            }
            Console.ReadKey();

        }
    }
}
    


                
        
    


            

        

    

    


