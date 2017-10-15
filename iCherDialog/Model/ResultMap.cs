using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace iCherDialog.Model
{
    public class ResultMap
    {
        [JsonProperty("SEARCH_RESULTS")]
        public List<SearchResult> Search_Results { get; set; }
    }
}