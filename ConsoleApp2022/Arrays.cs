using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2022
{
    internal class Arrays
    {
        public static void Test()
        {
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * i;
            }
            Console.WriteLine("Array created and initialized..."); 
            foreach(var item in arr)
            {
                Console.Write($"{item:0000}, ");
            }
            Console.WriteLine("\nMUlti dimension");
            int[,] twoD = new int[5, 5];  //new int[0:5, 1:5, 2:10, 3:44,  ]
            //Length - number of items in the array  = 5*5 = 25 items 
            //GetLength(dimension) -> number of items in the specified dimension 
            for(int i = 0; i< twoD.GetLength(0); i++)
            {
                for(int j=0; j<twoD.GetLength(1); j++ )
                {
                    twoD[i, j] = i + j + 1;
                }
            }
            Console.WriteLine("\nPrinting two D");
            for (int i = 0; i < twoD.GetLength(0); i++)
            {
                for (int j = 0; j < twoD.GetLength(1); j++)
                {
                    Console.Write($"{twoD[i, j]: 00}");
                }
                Console.WriteLine();
            }
            //All Array elements are initialized to the default values.
            //No concept of junk values 
            //default values => 0 for numerics, false for bools, null for object types 


        }
    }
}
