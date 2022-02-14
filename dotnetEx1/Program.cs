// See https://aka.ms/new-console-template for more information
using System;

namespace DOTNET // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void swap(ref int a , ref int b){
            int t = a ;
            a = b;
            b = t;
        }
        static void Main(string[] args)
        {
            // int x = 100 ;
            // object obj = new Object();
            // obj = x;
            // Console.Write(obj);
            // object obj ;
            // int x = 100;
            // obj = x;
            // int y = (int)obj;
            // Console.Write(y);
            int a = 100 , b = 2;
            swap(ref a , ref b);
            Console.Write("a = {0} , b = {1}" , a , b);
        }
    }
}