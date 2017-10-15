using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace iCherDialog.Model
{
    public class Filter
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        [JsonProperty("field")]
        public string Field { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}