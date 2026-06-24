using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2022
{
    public /*sealed*/ class BaseClass
    {

        private int _private;
        protected int _protected;
        public int _public;
        internal int _internal;
        protected internal int _protectedInternal; 

        public BaseClass()
        {
            Console.WriteLine("BaseClass.ctor() called"); 
        }
        public BaseClass(int value)
        {
            _private = _protected = _public = _internal = _protectedInternal = value;
            Console.WriteLine($"BaseClass.ctor( int {value}) called");
        }
        public virtual void Show()
        {
           // Assign(10).Assign(20).Assign(33)
            //Strings are immutable, every concatenation produces a new string object 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BaseClass.Show() called with: ")
                .AppendLine($"\tPrivate Field: {_private}")
                .AppendLine($"\tProtected Field: {_protected}")
                .AppendLine($"\tPublic Field: {_public}")
                .AppendLine($"\tInternal Field: {_internal}")
                .AppendLine($"\tProtected Internal Field: {_protectedInternal}")
                .AppendLine("========================================================");
            Console.WriteLine(sb.ToString());
        }
        ////Fluid APIs
        //public BaseClass Assign(int num)
        //{
        //    _private = num;
        //    return this;
        //}
    }
    public class DerivedClass : BaseClass
    {
        public DerivedClass() : base()
        {
            Console.WriteLine("DerivedClass.ctor() called");
        }
        public DerivedClass(int value) : base(value)
        {
            Console.WriteLine($"DerivedClass.ctor( int {value}) called");
        }
        /*new*/ public /*sealed*/ override void Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DerivedClass.Show() called with: ")
                .AppendLine($"\tPrivate Field: <<NOT ACCESSIBLE>>")
                .AppendLine($"\tProtected Field: {_protected}")
                .AppendLine($"\tPublic Field: {_public}")
                .AppendLine($"\tInternal Field: {_internal}")
                .AppendLine($"\tProtected Internal Field: {_protectedInternal}")
                .AppendLine("========================================================");
            Console.WriteLine(sb.ToString());
        }
    }

    internal class Inheritance
    {
        internal static void Test()
        {
            BaseClass bc1 = new BaseClass();
            bc1.Show();
            BaseClass bc2 = new BaseClass(9999);
            bc2.Show();

            DerivedClass dc1 = new DerivedClass();
            dc1.Show();
            DerivedClass dc2 = new DerivedClass(7654);
            dc2.Show();

            bc2 = dc2; //derived object  contains an implicit "base" pointer 
            //derived object can be assigned to the parent object 
            //parent object cannot be assigned to a derived object 
            //dc2 = bc2;
            bc2.Show(); //ideally should invoke the derived Show()
            //an object invokes its own member. 

        }
    }
}
