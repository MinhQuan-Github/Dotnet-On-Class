using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetEx2
{
    public class NV
    {
        public int ID;
        public string HoTen;
        public string Lop;
        public NV(int id , string hoten , string lop ){
            this.HoTen = hoten;
            this.ID = id;
            this.Lop = lop;
        }
    }
}