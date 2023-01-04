using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassaan_Khalil_Exercise1
{
    class InvoiceTest
    {
        static void Main(string[] args)
        {

            Invoice[] invoices =
            {
                //Part A
                new Invoice(87, "Electric Sander", 7, (decimal)57.98),
                new Invoice(24, "Power Saw", 18, (decimal)99.99),
                new Invoice(7, "Sledge Hammer", 11, (decimal)21.50),
                new Invoice(77, "Hammer", 76, (decimal)11.99),
                new Invoice(39, "Lawn Mower", 3, (decimal)79.50),
                new Invoice(68, "Screwdriver", 106, (decimal)6.99),
                new Invoice(56, "Jig saw", 21, (decimal)11.00)
            };

            var values =
                from inv in invoices
                select inv.Quantity * inv.Price;

            Console.WriteLine("Partnumber\t Part Description\t Quantity\t Price\t Invoice Total");
            int i = 0;
            foreach (var value in values)
            {
                Console.WriteLine($"{invoices[i].PartNumber} \t\t {invoices[i].PartDescription} \t\t {invoices[i].Quantity} \t\t {invoices[i].Price} \t {value}");
                i++;
            }

            //Part B
            var highest =
                from inv in invoices
                orderby inv.Quantity
                select inv.PartDescription;
            Console.WriteLine($"Invoice with Highest Quantity: {highest.Last()}");

            //Part C
            var average =
                (from inv in invoices
                 select inv.Price).Average();
            Console.WriteLine($"Average price is: {average}");

        }//end main    
    }//end class
}//end namespace
