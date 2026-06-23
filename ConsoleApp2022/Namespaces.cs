using System; 

namespace ConsoleApp2022
{
    public class Sample
    {
        public void Show()
        {
            Console.WriteLine("ConsoleApp2022.Sample.Show() called.");
        }
    }
    //sub-namespace or nested namespace 
    namespace Dotnet
    {
        public class Sample
        {
            public void Show()
            {
                Console.WriteLine("ConsoleApp2022.Dotnet.Sample.Show() called.");
            }
        }
    }
}
namespace ConsoleApp2022.Dotnet.Training
{
    public class Sample
    {
        public void Show()
        {
            Console.WriteLine("ConsoleApp2022.Dotnet.Training.Sample.Show() called.");
        }
    }
}

