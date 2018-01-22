using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_LINQInvoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice[] invoice = new Invoice[] {
                new Invoice (77, "Hammer", 76, 11.98M),
                new Invoice (83, "Electric sander", 7, 57.98M),
                new Invoice (56, "Jig saw", 21, 11.00M),
                new Invoice (39, "Lawn mower", 3, 79.50M),
                new Invoice (24, "Power saw", 18, 99.99M),
                new Invoice (68, "Screwdriver", 106, 6.99M),
                new Invoice (7, "Sledge hammer", 11, 21.50M),
                new Invoice (3, "Wrench", 34, 7.50M)
            };

            var sortByDescription =
                from element in invoice
                orderby element.PartDescription
                select element;

            foreach(var i in sortByDescription)
            {
                Console.WriteLine(i);
            }
        }
    }
}
