using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HilarioMarket.DTO
{
    public class UserDTO
    {
        public class Request
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }
        public class Response
        {
            public bool success { get; set; }
            [JsonProperty(PropertyName = "Data")]
            public List<User> Data { get; set; }
            public class  User
            {
                public int IdUser { get; set; }
                public string Name { get; set; }
                public string LastName { get; set; }
                public string UserName { get; set; }
                public string Password { get; set; }
            }
        }
    }
}
