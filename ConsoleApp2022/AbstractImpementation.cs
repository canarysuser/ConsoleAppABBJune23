using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;

namespace ConsoleApp2022
{

    internal class AbstractImpementation
    {
        static void Print(Account acc)
        {
            Console.WriteLine(acc);
        }
        internal static void Test()
        {

            //Account acc = new Account(); //Account is an abstract class 
            Savings acc = new Savings(101, "John Doe", AccountType.Savings, 6000);
            Print(acc);
            acc.Deposit(12345);
            Console.WriteLine(acc);
            try
            {
                acc.Withdraw(23456);
            }
            catch (InsufficientFundsException ie)
            {
                Console.WriteLine(ie.CustomMessage);
            }
            finally
            {
                Console.WriteLine("\nDone");
            }
            Console.WriteLine(acc);
            Current acc2 = new Current(102, "Jon Dhoe", AccountType.Current, 12345);
            Print(acc2);
        }
    }
}
