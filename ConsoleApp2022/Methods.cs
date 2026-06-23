using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2022
{
    internal class Methods
    {
        internal static void Test()
        {
            string byVal = nameof(SwapByValue), byRef = nameof(SwapByRef);
            string format = "{0} calling {1}, x:{2}, y:{3}";
            string bf = "Before", af = "After";
            int x = 10, y = 20;
            string line = "\n".PadLeft(60, '=');

            int num1 = 10;
            int num2 = num1;
            num2++;
            Console.WriteLine($"{num1}, {num2}");

            Console.WriteLine(format, bf, byVal, x, y);
            SwapByValue(x, y);
            Console.WriteLine(format, af, byVal, x, y);
            Console.WriteLine(line);

            Console.WriteLine(format, bf, byRef, x, y);
            SwapByRef(ref x, ref y);
            Console.WriteLine(format, af, byRef, x, y);
            Console.WriteLine(line);

            int num = 2;
            //Calling Function - Test
            int result = Power(num, out int sq, out int cube); 
            Console.WriteLine("Number: {0}, Square: {1}, Cube: {2}, Result: {3}",
                num, sq, cube, result);
            Console.WriteLine(line);
            Params("Zero numbers passed");
            Params("One number passed", 10);
            Params("Two numbers passed", 10, 20);
            Params("Three numbers passed", 11,22,33);
            Params("Unknown numbers passed", 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 3, 3, 3, 4, 4, 3, 2, 2, 2, 2);
            Console.WriteLine(line);
            OptionalArgs(); //No args passed, default values taken for all args 
            OptionalArgs(salary: 12345); //name and id have default values 
            OptionalArgs(name: "ABB"); //id and salary have default values 
            OptionalArgs(
                salary: 9999, //Comment can be added per line here
                id: 123,    
                name: "Unilever");
            //id=555, name="ABB", salary="
            OptionalArgs(555, "Abb", 8765); 
            //passing arguments in random order, not is declared order
            Console.WriteLine(line);
        }

        static void OptionalArgs(int id=0, string name="", double salary=0)
        {
            Console.WriteLine($"Id: {id}, Name: {(string.IsNullOrEmpty(name) ? "<<EMPTY>>" : name)}, Salary : {salary}"); 
        }
        static void Params(string msg, params int[] args)
        {
            Console.WriteLine(msg);
            Console.WriteLine($"Number of args: {args.Length}");
            foreach (var item in args) Console.Write($"{item},\t");
            Console.WriteLine();
        }

        //Power(2) => return 2sq, 2cube, 2fourth
        //Called Function - Power
        static int Power(int number, out int square, out int cube)
        {
            square = number * number;
            cube = square * number;
            return cube * number;
        }
        static void SwapByValue(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Inside SwapByValue: {a}, {b}");
        }
        static void SwapByRef(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
