using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary
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
    public interface IMobileBanking
    {
        void Deposit(double amount); 
    }
    public interface INetBanking
    {
        void Deposit(double amount);
        void Withdraw(double amount); 
    }
    public abstract class Account : IMobileBanking, INetBanking
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
        //Defer the business rules to the derived classes 
        public abstract void Withdraw(double amount);//No definition, only declaration

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


        public override string ToString()
        {
            return $"Id:{_info.Id}, Name:{_info.Name}, Type:{_info.Type}, Balance:{_info.Balance}";
        }
    }
    public class Savings : Account
    {
        public Savings(int id, string name, AccountType type, double amount)
            : base(id, name, type, amount)
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
    //public - class is accessible in other projects
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

}
