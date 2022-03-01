using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetEx4
{
    public class Program
    {   
        public delegate bool Compare(object o1 , object o2);
        public static void Sort(object [] arr , Compare cmp)
        {
            for (int i = 0 ; i < arr.Length - 1 ; i++)
            {
                for (int j = i+1 ; j < arr.Length ; j++)
                {
                    if (cmp(arr[i],arr[j]))
                    {
                        object temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static void Main(string []args)
        {
            SV s1 = new SV(1,"ABC");
            SV s2 = new SV(2,"DEF");
            SV s3 = new SV(3,"IJK");
            // SV s1 = new SV {MSSV = 1 , Name = "HKL"};
            // SV s2 = new SV {MSSV = 3 , Name = "MNP"};
            // SV s3 = new SV {MSSV = 2 , Name = "EFL"};

            SV[] s = {s1 , s2 , s3};
            Sort(s , SV.Compare_MSSV);
            foreach( SV i in s) 
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}