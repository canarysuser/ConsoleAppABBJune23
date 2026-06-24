
using System;

namespace ConsoleApp2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ConsoleApp2022.Sample s = new ConsoleApp2022.Sample();
            s.Show();
            //FQN -> Fully qualified name of the type
            ConsoleApp2022.Dotnet.Sample s2 = new ConsoleApp2022.Dotnet.Sample();
            s2.Show();
            ConsoleApp2022.Dotnet.Training.Sample s3 =
                new ConsoleApp2022.Dotnet.Training.Sample();
            s3.Show();*/

            /*Console.WriteLine(10 + " + " + 20 + " = " + 30);
            //Positional arguments 
            Console.WriteLine("{0} + {1} = {2}", 10, 20, 30);
            Console.WriteLine("{2} - {2} = {0}" ,
                arg0: 100 + 200, //0th 
                arg1: null,
                arg2: 500 - 300 + 100); //3rd 
            Console.WriteLine(
                arg0: 100 + 200, //0th 
                arg2: 500 - 300 + 100, //2nd 
                arg1: 500 + 500, //1st 
                format: "{2} - {1} = {0}");

            Console.WriteLine("{0} - {1} = " + (500 + 500),
                    100 + 200, 
                    500 - 300 + 100);
            

            //Templated strings 
            Console.WriteLine($"{10} + {20} = {10 + 20}");

            int a = 10, b = 20, c = 30;
            Console.WriteLine($"{a} + {b} = {(c==30?"Thirty" : "Not Thirty")}");
*/

            /*string name = string.Empty;
            Console.Write("Enter Name: ");
            name = Console.ReadLine(); //getting the input from user
            Console.WriteLine($"Hello {name}. Welcome to C# Programming!!");

            Console.Write("\nEnter Salary: ");
            //string x = Console.ReadLine(); 
            //x = "10.0A"; 
            double salary = double.Parse(Console.ReadLine()); 
            //throws exception if the string cannot be parsed or contains non-digit chars
            
            //Alternate method -> double.TryParse(s, out x); 
            //-> returns true if parsing is successful, else returns false 
            //-> out variable contains the value, if successful, else default value-0
            //-> does not throw exception 

            Console.WriteLine($"Your Salary is: {salary:C3}");
            //:N -> nummber format, :P - percent format, :G, :000,000.000, :dd-mm-yyyy

            if(salary > 20000)
            {
                Console.WriteLine("Salary greater than 20000");
            } else
            {
                Console.WriteLine("Salary less than 20000"); 
            }
            int counter = 1;
            Console.WriteLine("DO..WHILE.....\n");
            do
            {
                Console.Write($"{counter++},\t");
            } while (counter < 10);
            Console.WriteLine("\nWHILE......\n");
            while(counter > 0)
            {
                Console.Write($"{counter--},\t");
            }
            Console.WriteLine("\nfor.....");
            for (counter = 0; counter < 10; counter++)
            {
                Console.Write($"{counter},\t");
            }
            Console.WriteLine("\n\nPress a key to terminate....");
            Console.ReadKey();*/

            //Arrays.Test();
            //Methods.Test();
            //Employee e1 = new Employee();
            //e1.Show();
            //e1.Id = 9999;
            //e1.Name = "Microsoft";
            //e1.City = "Chennai";
            //e1.Salary = 9876.54;
            //e1.Show();
            ////Object Initializers 
            //Employee e2 = new Employee
            //{
            //    Id = 1234,
            //    Name = "John Doe",
            //    City = "Hyderabad",
            //    Salary = 12345.67,
            //    Address = "Awaiting details"
            //};
            //e2.Show();

            //Inheritance.Test();
            // AbstractImpementation.Test();
            //Interfaces.Test();
            //StaticExample.Test();
            //ExceptionHandling.Test();
            //AbstractImpementation.Test();
            DelegateSample.Test();
        }
    }
}
