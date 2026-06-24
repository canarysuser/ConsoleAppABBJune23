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

            //Multi-casting the delegate 
            ad += new ArithmeticDelegate(Minus);
            ad += Multiply; //subscribing
            ad += Divide;
            ad -= Multiply; //unsubscribing
            //Anonymous Methods - unnamed methods - Compiler generates a name for us. 
            //inline functions - nested functions defined within a function 
            //nested function can access variable from the outer function.
            int i = 0;
            ad += delegate (int a, int b)
            {
                i++;
                return a % b;
            };
            //Lambda expressions - shortcut to the anonymous method shortcut 
            ad += (a, b) => (a * b) / (a + b);
            InvokeDelegateManually(ad);
            /*
             * Lambdas 
             * -Expression Lambda - single line of code, usually the return statement x=> x
             * -Statement Lambda - multiple lines of code enclosed with { } 
             * Arguments are passed in as
             * 1. No Arguments      -> () to be used        -> ()=>10; 
             * 2. One Argument      -> (a) | a to be used   -> (a)=>a OR  a=>a 
             * 3. 2 or more         -> (a,b) to be used     -> (a,b) => { return a-b;}
             * 
             */

        }
        static void InvokeDelegateManually(ArithmeticDelegate ad)
        {
            foreach(Delegate item in ad.GetInvocationList())
            {
                object result = item.DynamicInvoke(500, 50);
                Console.WriteLine($"Method {item.Method.Name}(500,50) returned {result}");
            }
        }
    }
}
