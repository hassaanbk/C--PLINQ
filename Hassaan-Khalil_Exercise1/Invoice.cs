using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassaan_Khalil_Exercise1
{
    class Invoice
    {

        public int PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Invoice(int partNumber, string partDescription, int quantity, decimal price)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            Price = price;
        }

        public override string ToString() => $"{PartNumber}\t{PartDescription}\t{Quantity}\t{Price}";

    }
}
