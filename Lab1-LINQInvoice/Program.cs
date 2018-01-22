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

            Console.WriteLine("a) Sorted by description:\n");
            foreach(var i in sortByDescription)
            {
                Console.WriteLine(i);
            }

            var sortByPrice =
                from element in invoice
                orderby element.Price

                select element;

            Console.WriteLine("\nb) Sorted by price:\n");
            foreach (var i in sortByPrice)
            {
                Console.WriteLine(i);
            }

            var descriptionAndQuantity =
                from element in invoice
                orderby element.Quantity
                select new { PartDescription = element.PartDescription, Quantity = element.Quantity };

            Console.WriteLine("\nc) Description and quantity, sort by quantity:\n");
            foreach (var i in descriptionAndQuantity)
            {
                Console.WriteLine(i);
            }

            var descriptionAndInvoice =
                from element in invoice
                orderby element.Price * element.Quantity
                select new {PartDescription = element.PartDescription, Total = element.Price * element.Quantity };

            Console.WriteLine("\nd) Description and invoice total, sort by invoice total:\n");
            foreach (var i in descriptionAndInvoice)
            {
                Console.WriteLine(i);
            }

            var total200_500 =
                from element in invoice
                orderby element.Price * element.Quantity
                where 200 < element.Price * element.Quantity && element.Price * element.Quantity  < 500
                select new { PartDescription = element.PartDescription, InvoiceTotal = element.Price * element.Quantity };

            Console.WriteLine("\ne) Invoice totals between $200.00 and $500.00:\n");
            foreach (var i in total200_500)
            {
                Console.WriteLine(i);
            }
        }
    }
}
