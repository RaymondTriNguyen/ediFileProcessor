using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ediFileProcessor.Models
{
    public class InvoiceItem
    {
        public string InvoiceNumber { get; set; }
        public string InvoiceDate { get; set; }
        public string PONumber { get; set; }
        public string PODate { get; set; }
        public string ShipAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
        public string ItemNumber { get; set; }
        public string Quantity { get; set; }
        public string UnitPrice { get; set; }
        public string UPC { get; set; }
    }
}
