using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2022
{
    //enum are used to restrict user choices and improve readability of code
    //minimize string usage
    public enum AccountType
    {
        None,   //0
        Savings,//1
        Current //2
    }

    //Class for holding the app data 
    //SRP - supposed to manage account information
    public class AccountInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AccountType Type { get; set; }
        public double Balance { get; set; }
    }
    public abstract class Account
    {
        protected AccountInfo _info; 
        public Account(int id, string name, AccountType type, double amount)
        {
            if (_info == null) _info = new AccountInfo();
            _info.Id = id;
            _info.Name = name;
            _info.Type = type;
            _info.Balance = amount;
        }
        public void FundTransfer() { }
        public void Deposit(double amount) { _info.Balance += amount; }
        /*public void Withdraw(double amount)
        {
            if (_info.Type == AccountType.Savings && (_info.Balance - amount) > 4999)
                _info.Balance -= amount;
            else if (_info.Type == AccountType.Current &&
                (_info.Balance - amount) > 9999)
                _info.Balance -= amount;
            else
            {
                //throw Exception 
            }
        }*/
        //Defer the business rules to the derived classes 
        public abstract void Withdraw(double amount);//No definition, only declaration

        public override string ToString()
        {
            return $"Id:{_info.Id}, Name:{_info.Name}, Type:{_info.Type}, Balance:{_info.Balance}";
        }
    }
    public class Savings : Account
    {
        public Savings(int id, string name, AccountType type, double amount)
            :base(id, name, type, amount)
        {
        }
        public override void Withdraw(double amount)
        {
            if (_info.Balance - amount > 4999)
                _info.Balance -= amount;
            else
            {
                throw new Exception("Insufficient funds.");
            }
        }
    }
    public class Current : Account
    {
        public Current(int id, string name, AccountType type, double amount)
            : base(id, name, type, amount)
        {
        }
        public override void Withdraw(double amount)
        {
            if (_info.Balance - amount > 9999)
                _info.Balance -= amount;
            else
            {
                throw new Exception("Insufficient funds.");
            }
        }
    }

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
            acc.Withdraw(2345);
            Console.WriteLine(acc);
            Current acc2 = new Current(102, "Jon Dhoe", AccountType.Current, 12345);
            Print(acc2);
        }
    }
}
