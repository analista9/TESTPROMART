using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HilarioMarket.DTO
{
    public class CompanyDTO
    {
        [JsonProperty(PropertyName = "Data")]
        public List<Company> Data { get; set; }
        public class Company
        {
            [Key]
            public int IdCompany { get; set; }
            public string Description { get; set; }
            public List<ProductDTO> products { get; set; }
        }
    }
}
