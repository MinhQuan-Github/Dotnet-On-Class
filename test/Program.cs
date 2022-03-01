using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
    public class Program
    {
        public static int Add(ref int a , ref int b)
        {
            return a+b;
        }
        static void Main(string [] args) {
            MyClass o = new MyClass();
            IFile1 f1 = (IFile1)o;
            f1.A();
            IFile2 f2 = (IFile2)o;
            f2.A();
        }
    }
}