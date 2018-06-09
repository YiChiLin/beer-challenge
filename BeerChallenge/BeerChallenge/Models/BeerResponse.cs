using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BeerChallenge.Models
{
    public class BeerResponse
    {
        [JsonProperty("data")]
        public List<BeerResponseDetail> Data { get; set; }
    }

    public class BeerResponseDetail
    {
        [JsonProperty("abv")]
        public string AlcoholByVolume { get; set; }

        [JsonProperty("createDate")]
        public DateTime CreateDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ibu")]
        public string InternationalBitternessUnite { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameDisplay")]
        public string NameDisplay { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}