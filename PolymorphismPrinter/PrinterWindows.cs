using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPrinter
{
    public class PrinterWindows
    {
        public string Name { set; get; }

        public virtual void Show() 
        {
            Console.WriteLine("Printer Display Dimension :");
        }

        public virtual void Print()
        {
            Console.WriteLine("Printer is Printing...");
        }
    }
}
