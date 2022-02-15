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
            // int a = 100 , b = 2;
            // swap(ref a , ref b);
            // Console.Write("a = {0} , b = {1}" , a , b);
            // int y ; string y1 = "23h";
            // try {
            //     y = Convert.ToInt32(y1);
            // } catch {
            //     Console.WriteLine(error);
            // }
            // Console.WriteLine(y+1);
            String[] A = new string[3];
            for (int i = 0 ; i < A.Length ; i++){
                Console.Write("A[{0}] = " , i);
                A[i] = Console.ReadLine();
            }
            for (int i = 0 ; i < A.Length ;i++){
                Console.Write("A[{0}] = {1} ", i , A[i]);
            }
            foreach(string i in A){
                Console.Write(i + " ");
            }
            string [,] B = new string [2,3] {
                {"A1","A2","A3"},
                {"B1","B2","B3"}
            };
            foreach (string i in B) {
                Console.Write(i + " ");
            }
            string[][]  s = new string [2][];
            s[0] = new string[] {
                "Trinh" , "Quan" , "Phu"
            };
            s[1] = new string[] {
                "Anh" , "Bao" , "Long"
            };
            foreach (string [] srr in s){
                foreach (string i in srr) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}