using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HilarioMarket.Models
{
    public class Customer
    {
        [Key]
        public int IdCustomer { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool FrequentBuyer { get; set; }
        public Collection<Purchase> purchases { get; set; }
    }
}
