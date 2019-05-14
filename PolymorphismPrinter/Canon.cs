using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPrinter
{
    public class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon Display Dimension : 8.5x10");
        }

        public override void Print()
        {
            Console.WriteLine("Canon is printing...");
        }
    }
}
