using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// delegate & event
namespace test2
{
    public class Program
    {
        public delegate int MyDel(int x , int y);
        public static int add(int x , int y){
            return x+y;
        }
        public static int sub(int x, int y) {
            return x-y;
        }
        public static int TinhToan(int x, int y , MyDel d){
            return d(x,y);
        }
        static void Main(string[] args) {
            MyDel D = new MyDel(add);
            // xem d nhu la phuong thuc
            int z = D(3,4);
            Console.WriteLine(z);
            // xem d nhu la mot doi tuong cu the
            int t = D.Invoke(3,4);
            Console.WriteLine(t);
            // xem d nhu la 1 tham so cua ham
            int z1 = TinhToan(1 , 5 , D);
            Console.WriteLine(z1);
            int z2 = TinhToan(4 , 2 , sub);
            Console.WriteLine(z2);
        }
    }
}