using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
    public class MyClass:IFile1, IFile2
    {
        // public void A()
        // {
        //     Console.WriteLine("A");
        // }
        void IFile1.A(){
            Console.WriteLine("A-1");
        }
        void IFile2.A(){
            Console.WriteLine("A-2");
        }
        public void A1()
        {
            Console.WriteLine("A1");
        }
        public void B1()
        {
            Console.WriteLine("B1");
        }
        public void A2()
        {
            Console.WriteLine("A2");
        }
        public void B2()
        {
            Console.WriteLine("B2");
        }
        public void M()
        {
            Console.WriteLine("M");
        }
    }
}