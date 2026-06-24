using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2022
{
    internal class MemoryManagement : IDisposable
    {
        private int _counter;
        private readonly int MaxSize = 1_00_0;
        private string[] names;
        public MemoryManagement(int counter)
        {
            _counter = counter;
            names = new string[MaxSize];
            for(int i=0; i<MaxSize; i++)
            {
                names[i] = $"A very long string to fill memory {i}";
            }
            Console.WriteLine($"CREATED {_counter} OBJECT"); 
        }
        ~MemoryManagement()
        {
            names = null;
            Console.WriteLine($"\tDESTROYED {_counter} OBJECT");
        }
        public void Dispose()
        {
            names = null;
            Console.WriteLine($"\t\t\tDISPOSED {_counter} OBJECT");
            GC.SuppressFinalize(this);
        }
        internal static void Test()
        {
            MemoryManagement mm;
            for (int i = 0; i < 100; i++)
            {
                mm = new MemoryManagement(i); 
                if(i>25 && i< 65)
                {
                    Console.WriteLine($"Before 1st Coll, Generation of 'mm' {GC.GetGeneration(mm)}");
                    GC.Collect();
                    Console.WriteLine($"After 1st Coll, Generation of 'mm' {GC.GetGeneration(mm)}");
                    if(i > 35 && i <45)
                    {
                        GC.Collect();
                        Console.WriteLine($"After 2nd Coll, Generation of 'mm' {GC.GetGeneration(mm)}");
                    }
                }
                if (i > 80 && i < 91)
                    mm.Dispose();
            }

            using(MemoryManagement mm1 = new MemoryManagement(999999))
            {
                Console.WriteLine("Sinside the using block");
            }
        }
    }
}
