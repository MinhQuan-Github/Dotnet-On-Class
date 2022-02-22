using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetEx2 
{
    public class Program
    {
        static void Main(String [] args){
            QLNV db = new QLNV();
            NV N1 = new NV(1,"NV1","20T2");
            NV N2 = new NV(2,"NV2","20T2");
            NV N3 = new NV(3,"NV3","20T2");
            NV N4 = new NV(4,"NV4","20T2");
            NV N5 = new NV(5,"NV5","20T2");
            db.Add(N1);
            db.Add(N4);
            db.Add(N5);
            db.Add(N2);
            db.Add(N3);
            Console.WriteLine(db.ToString());
            Console.WriteLine("Vị trí của NV 3 là " + db.IndexOf(N3));
            db.Insert(3,N1);
            Console.WriteLine(db.ToString());
            db.Remove(N5);
            Console.WriteLine(db.ToString());
            db.Add(N5);
            Console.WriteLine(db.ToString());
            db.RemoveAt(3);
            Console.WriteLine(db.ToString());
            // In mang da sap xep theo id
            NV []nv = db.sort();
            for (int i = 0 ; i < db.Length ; i++){
                Console.WriteLine("{0}   {1}   {2}\n" , nv[i].ID , nv[i].HoTen , nv[i].Lop);
            }
        }

    }
}