using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetEx3
{
    public class Program
    {
        static void Main(string [] args) {
            Clock c = new Clock();
            AnalogClock ac = new AnalogClock();
            DigitalClock dc = new DigitalClock();

            c.OnSecondChange += new SecondHandler(ac.showAC);
            c.OnSecondChange += new SecondHandler(dc.showDC);
            
            c.Run();
        }
    }
}