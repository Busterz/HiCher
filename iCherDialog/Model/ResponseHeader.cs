using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace iCherDialog.Model
{
    public class ResponseHeader
    {
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("QTime")]
        public int QTime { get; set; }
        [JsonProperty("params")]
        public Params Params { get; set; }
    }
}