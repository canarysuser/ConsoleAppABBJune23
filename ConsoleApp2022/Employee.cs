using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2022
{
    public class Employee
    {
        #region Fields
        private int _id;
        private string _name;
        private string _city;
        private double _salary;
        #endregion

        #region Constructors or Initializers 
        //First methods that is invoked on the object, immediately after creating the object 
        public Employee() : this(9999, "DEFAULT")
        {
            Console.WriteLine("Employee.ctor( ) called.");
        }
        public Employee(int id, string name) : this(id, name, "DEFAULT")
        {
            Console.WriteLine("Employee.ctor( int id, string name ) called.");
        }
        //Constructors can be overloaded 
        public Employee(int id, string name, string city) : this(id, name, city, 0)
        {
            Console.WriteLine("Employee.ctor( int id, string name, string city ) called.");
        }
        public Employee(int id, string name, string city, double salary)
        {
            _id = id;
            _name = name;
            _city = city;
            _salary = salary;
            Console.WriteLine("Employee.ctor( int id, string name, string city, double salary ) called.");
        }
        #endregion

        #region Methods 
        public void Show()
        {
            Console.WriteLine($"ID: {_id}, Name:{_name}, City:{_city},Salary:{_salary}");
        }
        #endregion


    }
}
