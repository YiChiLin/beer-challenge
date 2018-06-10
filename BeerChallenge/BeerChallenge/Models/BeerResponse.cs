using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BeerChallenge.Models
{
    public class BeerResponse
    {
        [JsonProperty("data")]
        public List<BeerResponseDetail> Data { get; set; }

        [JsonIgnore]
        public DateTime LatestUpdateTime { get; set; }
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

        [JsonProperty("isOrganic")]
        public char IsOrganic { get; set; }

        [JsonProperty("nameDisplay")]
        public string Name { get; set; }

        [JsonProperty("originalGravity")]
        public string OriginalGravity { get; set; }

        [JsonProperty("statusDisplay")]
        public string Status { get; set; }

        [JsonProperty("style")]
        public BeerStyle Style { get; set; }
    }

    public class BeerStyle
    {
        [JsonProperty("abvMax")]
        public string AbvMax { get; set; }

        [JsonProperty("abvMin")]
        public string AbvMin { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("fgMax")]
        public string FgMax { get; set; }

        [JsonProperty("fgMin")]
        public string FgMin { get; set; }

        [JsonProperty("ibuMax")]
        public string IbuMax { get; set; }

        [JsonProperty("ibuMin")]
        public string IbuMin { get; set; }

        [JsonProperty("ogMin")]
        public string OgMin { get; set; }

        [JsonProperty("srmMax")]
        public string SrmMax { get; set; }

        [JsonProperty("srmMin")]
        public string SrmMin { get; set; }

        [JsonProperty("description")]
        public string StyleDescription { get; set; }

        [JsonProperty("name")]
        public string StyleName { get; set; }
    }
}