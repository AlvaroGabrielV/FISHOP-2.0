using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace FISHOP
{
    public class Item
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("rating")]
        public float Rating { get; set; }

        [JsonProperty("ratingCount")]
        public double RatingCount { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonIgnore]
        public int Quantidade { get; set; } = 1;

        private decimal _valorNumerico;

        public decimal ValorNumerico
        {
            get
            {
                if (_valorNumerico == 0 && !string.IsNullOrEmpty(Price))
                {
                    var precoLimpo = new string(Price.Where(c => char.IsDigit(c) || c == ',' || c == '.').ToArray());
                    precoLimpo = precoLimpo.Replace(',', '.');

                    if (decimal.TryParse(precoLimpo, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal valor))
                        _valorNumerico = valor;
                }
                return _valorNumerico;
            }
            set => _valorNumerico = value;
        }

    }
}
