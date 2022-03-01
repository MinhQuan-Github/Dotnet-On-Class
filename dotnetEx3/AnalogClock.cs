using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetEx3
{
    public class AnalogClock
    {
        public void showAC(object o , EventArgs e) 
        {
            DateTime d = DateTime.Now;
            Console.WriteLine("AC: {0}:{1}:{2}:{3}" , d.Hour , d.Minute , d.Second , d.Millisecond);
        }
    }
}