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

        #region Properties 
        public int Id
        {
            get { return _id;  }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        //Compiler shortcut - compiler generates a backing field and completes the code 
        public string Address { get; set; }
        //Used in training sessions/learning 


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
