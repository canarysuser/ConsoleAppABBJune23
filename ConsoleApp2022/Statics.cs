using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2022
{
    class StaticClass
    {
        //Fields 
        public static int StaticField = 0;
        public int InstanceField = 0; 

        static StaticClass()
        {
            StaticField++;
            //InstanceField++;
            Console.WriteLine($"Static Constructor called. Static Field: {StaticField}");
        }
        //instance constructor
        public StaticClass()
        {
            StaticField++;
            InstanceField++;
            Console.WriteLine($"Instance Constructor called. "); 
            Console.WriteLine($"Static Field: {StaticField}, Instance Field: {InstanceField}");
        }
        public static void StaticMethod()
        {
            Console.WriteLine($"{nameof(StaticMethod)}called. Static Field: {StaticField}");
            //StaticClass sc = new StaticClass();
            //Console.WriteLine(sc.InstanceField);
        }
        public void InstanceMethod()
        {
            Console.WriteLine($"{nameof(InstanceMethod)}called. Static Field: {StaticField}");
            Console.WriteLine($"{nameof(InstanceMethod)}called. Instance Field: {InstanceField}");
        }
    }
    class Singleton
    {
        private int counter = 1; 
        public int Counter
        {
            get { return counter;  }
            private set { counter = value; }
        }
        private static Singleton _instance; 
        public static Singleton Instance
        {
            get
            {
                if(_instance is null)
                {
                    _instance = new Singleton();
                    _instance.Counter++;
                }
                return _instance;
            }
        }
        //prevent new instance from being created 
        private Singleton() { }
    }
    internal class StaticExample
    {
        internal static void Test()
        {
            Singleton s1 = Singleton.Instance;
            Console.WriteLine($"Instance counter: {s1.Counter}");
            Singleton s2 = Singleton.Instance;
            Console.WriteLine($"Instance counter: {s2.Counter}");
            
            StaticClass scc = new StaticClass();
            scc.InstanceMethod();
            Console.WriteLine("=====================");
            StaticClass scc2 = new StaticClass();
            scc2.InstanceMethod();
            Console.WriteLine("=====================");


        }
    }
}
