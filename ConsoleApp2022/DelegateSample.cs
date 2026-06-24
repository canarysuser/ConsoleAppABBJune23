using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2022
{
    //Step1: Declaration 
    public delegate int ArithmeticDelegate(int a, int b); 

    internal class DelegateSample
    {
        static int Add(int x, int y) { return x + y; }
        static int Minus(int x, int y) { return x - y; }
        static int Multiply(int x, int y) { return x * y; }
        static int Divide(int x, int y) { return y > 0 ? x / y : 0; }
        internal static void Test()
        {
            //Step2 : Instantiation 
            ArithmeticDelegate ad = new ArithmeticDelegate(Add);
            //Step3: Invocation 
            int result = ad(5, 5); //returns 10 
            Console.WriteLine($"ad(5,5) returns {result}");
            result = ad.Invoke(10, 10); //returns 20 
            Console.WriteLine($"ad.Invoke(10,10) returns {result}");

        }
    }
}
