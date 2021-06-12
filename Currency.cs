using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDolar
{
    public class Currency
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "buy")]
        public decimal buy { get; set; }

        [JsonProperty(PropertyName = "sell")]
        public decimal sell  { get; set; }

        [JsonProperty(PropertyName = "variation")]
        public decimal Varaiation { get; set; }
    }
}
