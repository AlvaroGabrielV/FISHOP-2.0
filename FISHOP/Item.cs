using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace FISHOP
{
    public class Item
    {

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("source")]
        public string Source {  get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("rating")]
        public float Rating { get; set; }

        [JsonProperty("ratingCount")]
        public double RatingCount { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("position")]
        public int Position {  get; set; }
    }
}
