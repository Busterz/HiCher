using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace iCherDialog.Model
{
    public class SearchResult
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        [JsonProperty("calculationTime")]
        public int CalculationTime { get; set; }
        [JsonProperty("request")]
        public Request Request { get; set; }
        [JsonProperty("maxScore")]
        public double MaxScore { get; set; }
        [JsonProperty("numFound")]
        public int NumFound { get; set; }
        [JsonProperty("responseHeader")]
        public ResponseHeader ResponseHeader { get; set; }
        [JsonProperty("resultLength")]
        public int ResultLength { get; set; }
        [JsonProperty("resultList")]
        public List<ResultList> ResultList { get; set; }
        [JsonProperty("solrQueryTime")]
        public int SolrQueryTime { get; set; }
    }
}