using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace iCherDialog.Model
{
    public class SecuritiesSearchResponse
    {
            [JsonProperty("@type")]
            public string Type { get; set; }
            [JsonProperty("allDataReturned")]
            public bool AllDataReturned { get; set; }
            [JsonProperty("bmsRequestTime")]
            public int BmsRequestTime { get; set; }
            [JsonProperty("requestId")]
            public string RequestId { get; set; }
            [JsonProperty("requestTime")]
            public int RequestTime { get; set; }
            [JsonProperty("resultLength")]
            public int ResultLength { get; set; }
            [JsonProperty("serverNumber")]
            public int ServerNumber { get; set; }
            [JsonProperty("success")]
            public bool Success { get; set; }
            [JsonProperty("totalRequestTime")]
            public int TotalRequestTime { get; set; }
            [JsonProperty("resultMap")]
            public ResultMap ResultMap { get; set; }
    }
}