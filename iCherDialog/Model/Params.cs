using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace iCherDialog.Model
{
    public class Params
    {
        [JsonProperty("q")]
        public string Q { get; set; }
        [JsonProperty("defType")]
        public string DefType { get; set; }
        [JsonProperty("qf")]
        public string Qf { get; set; }
        [JsonProperty("fl")]
        public string Fl { get; set; }
        [JsonProperty("fq")]
        public List<string> Fq { get; set; }
        [JsonProperty("collection")]
        public string Collection { get; set; }
        [JsonProperty("wt")]
        public string Wt { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}