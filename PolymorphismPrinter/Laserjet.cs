using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPrinter
{
    public class Laserjet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Laser Jet Display Dimension : 9x11");
        }

        public override void Print()
        {
            Console.WriteLine("Laser Jet is printing...");
        }
    }
}
