using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPrinter
{
    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson Display Dimension : 10x11");
        }

        public override void Print()
        {
            Console.WriteLine("Epson is printing...");
        }

    }
}
