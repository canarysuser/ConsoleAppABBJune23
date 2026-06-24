using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2022
{

    internal class ExceptionHandling
    {
        static void MethodThrowsException()
        {
            int a = 10, b = 0, c = 0;
            c = a / b; //throws DivideByZeroException 
        }
        static void HandleExceptions()
        {
            //MethodThrowsException();
            try
            {
                MethodThrowsException();
            }
            catch (DivideByZeroException de)
            {
                //Exception class has 2 core properties -> Message, StackTrace
                //Message -> gives the exception message 
                //StackTrace -> gives the call stack location and line which triggered 
                //              the exception 
                Console.WriteLine($"ERROR:\nMessage:{de.Message}\nStack: {de.StackTrace}");
                //throw;      //rethrow - preserves the stack trace
                throw de;   //throw new - create a new stack trace, original is lost.
            }
            catch (ArithmeticException ae)
            {
                Console.WriteLine($"ERROR:\nMessage:{ae.Message}\nStack: {ae.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR:\nMessage:{ex.Message}\nStack: {ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("FINALLY executed.");
            }
        }
        internal static void Test()
        {
            HandleExceptions();
        }
    }
}
