using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tes1
{
    public class Program
    {
        static void Main(String [] args){
            try {
                f2();
            }
            catch (DivideByZeroException dex) 
            {
                Console.Write("Divide by zero exception : \n" + dex.StackTrace);
            }
            catch (Exception ex )
            {
                Console.WriteLine("General exception :" + ex.Message);
            }
            Console.ReadLine();
        }
        static void f2()
        {
            f1();
        }
        static void f1()
        {
            int a = 5;
            int b = 1;
            Console.Write(a/b);
        }
    }
}