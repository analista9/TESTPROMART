using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HilarioMarket.DTO
{
    public class ProductDTO
    {
        public int IdProduct { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double BaseAmount { get; set; }
        public double MarketAmount { get; set; }
    }
}
