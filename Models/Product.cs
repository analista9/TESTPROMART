using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HilarioMarket.Models
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double BaseAmount { get; set; }
        public double MarketAmount { get; set; }
        public int IdCompany { get; set; }
        public Collection<PurchaseDetails> purchaseDetails { get; set; }
    }
}
