using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HilarioMarket.Models
{
    public class Purchase
    {
        [Key]
        public int IdPurchase { get; set; }
        public double Amount { get; set; }
        public int IdCustomer { get; set; }
        public Collection<PurchaseDetails> purchaseDetails { get; set; }
    }
}
