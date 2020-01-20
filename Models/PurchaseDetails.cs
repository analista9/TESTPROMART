using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HilarioMarket.Models
{
    public class PurchaseDetails
    {
        [Key]
        public int IdPurchaseDetails { get; set; }
        public int IdPurchase { get; set; }
        public int IdProduct { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; } 
        public double TotalAmount { get; set; } 
    }
}
