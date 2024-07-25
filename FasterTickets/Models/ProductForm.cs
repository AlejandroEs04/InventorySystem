using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasterTickets.Models
{
    public class ProductForm
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public decimal Iva { get; set; }
    }
}
