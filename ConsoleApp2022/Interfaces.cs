using AccountLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2022
{
    interface IBase
    {
        void Show(); //method declaration 
        string Name { get; } //property declaration
    }
    interface IDerived : IBase
    {
        void DoWork();
    }
    interface ITransact
    {
        void DoWork();
    }
    class InterfaceImplementation : IDerived, ITransact
    {
        private string _name = "Interface Ops"; 
        public string Name {  get { return _name; } }
        public void Show() { Console.WriteLine($"InterfaceImplementation.Show()"); }
        public void DoWork() { Console.WriteLine($"InterfaceImplementation.DoWork()"); }
    }

    internal class Interfaces
    {
        internal static void Test()
        {
            IMobileBanking mb = new Current(101, "John Doe", AccountType.Savings, 15000);
            mb.Deposit(1000);

            INetBanking netBank = new Current(102, "JJJ", AccountType.Current, 12345);
            netBank.Deposit(1);
            netBank.Withdraw(1);
            


           /* InterfaceImplementation ii = new InterfaceImplementation();
            Console.WriteLine(ii.Name);
            ii.Show();
            ii.DoWork();
            Console.WriteLine("==================================");

            //Restrict user operations 
            ITransact it = ii;
            it.DoWork();
            //it.Show();
            Console.WriteLine("==================================");
            IBase ib = ii;
            Console.WriteLine(ib.Name);
            ib.Show();
            //ib.DoWork();
            Console.WriteLine("==================================");
            IDerived id = ii;
            Console.WriteLine(id.Name);
            id.Show();
            id.DoWork();*/
        }
    }
}
