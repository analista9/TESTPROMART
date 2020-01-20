using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HilarioMarket.Models
{
    [Serializable]
    public class Company
    {      
        [Key]
        public int IdCompany { get; set; }
        public string Description { get; set; }
        public Collection<Product> products { get; set; }
    }    
}
