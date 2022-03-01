using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetEx3
{
    public class DigitalClock
    {
        public void showDC(object o , EventArgs e) 
        {
            DateTime d = DateTime.Now;
            Console.WriteLine("DC: {0}:{1}:{2}:{3}" , d.Hour , d.Minute , d.Second , d.Millisecond);
        }
    }
}