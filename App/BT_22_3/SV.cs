using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_22_3
{
    public class SV
    {
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public string LopSH { get; set; }
        public bool Gender { get; set; }
        public DateTime NS { get; set; }
        public double DTB { get; set; }

        public bool Anh { get; set; }
        public bool HB { get; set; }
        public bool CMND { get; set; }
        
        public SV(string MSSV, string NameSV , string LopHP , bool Gender , DateTime NS , double DTB , bool Anh , bool HB , bool CMND)
        {
            this.MSSV = MSSV;
            this.NameSV = NameSV;
            this.LopSH = LopHP;
            this.Gender = Gender;
            this.NS = NS;
            this.DTB = DTB;
            this.Anh = Anh;
            this.HB = HB;
            this.CMND = CMND;
        }
        public SV()
        {
            this.MSSV = "";
            this.NameSV ="";
            this.LopSH = "";
            this.Gender = true;
            this.NS = DateTime.Now;
            this.DTB = 0;
            this.Anh = false;
            this.HB = false;
            this.CMND = false;
        }
    }
}
