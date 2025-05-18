using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FISHOP
{
    public class ApiResponse
    {
        [JsonProperty("shopping")]
        public List<Item> Shopping { get; set; }
    }
}
