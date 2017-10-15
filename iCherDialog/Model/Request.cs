using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace iCherDialog.Model
{
    public class Request
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
        [JsonProperty("requestingApp")]
        public string RequestingApp { get; set; }
        [JsonProperty("requestUser")]
        public RequestUser RequestUser { get; set; }
        [JsonProperty("timeout")]
        public int Timeout { get; set; }
        [JsonProperty("useCache")]
        public bool UseCache { get; set; }
        [JsonProperty("filters")]
        public List<Filter> Filters { get; set; }
        [JsonProperty("finalQueries")]
        public List<string> FinalQueries { get; set; }
        [JsonProperty("collapseField")]
        public string CollapseField { get; set; }
        [JsonProperty("collapseFieldMax")]
        public string CollapseFieldMax { get; set; }
        [JsonProperty("collection")]
        public string Collection { get; set; }
        [JsonProperty("formatQuery")]
        public bool FormatQuery { get; set; }
        [JsonProperty("query")]
        public string Query { get; set; }
        [JsonProperty("queryField")]
        public string QueryField { get; set; }
        [JsonProperty("removeDynamicFieldSuffix")]
        public bool RemoveDynamicFieldSuffix { get; set; }
        [JsonProperty("responseFields")]
        public List<string> ResponseFields { get; set; }
        [JsonProperty("withholdComplexFields")]
        public bool WithholdComplexFields { get; set; }
        [JsonProperty("withholdFields")]
        public List<string> WithholdFields { get; set; }
    }
}