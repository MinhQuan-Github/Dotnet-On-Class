using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetEx4
{
    public class SV
    {
        public int MSSV;
        public string Name;
        public SV(int MSSV , string Name)
        {
            this.MSSV = MSSV;
            this.Name = Name;
        }
        public override string ToString()
        {
            return MSSV + ", " + Name + ".";
        }
        public static bool Compare_Name(object o1, object o2)
        {
            if (String.Compare(((SV)o1).Name , ((SV)o2).Name) > 0) 
                return true;
            else 
                return false;

        }
        public static bool Compare_MSSV(object o1, object o2)
        {
            return ((SV)o1).MSSV > ((SV)o1).MSSV;
        }
    }
}