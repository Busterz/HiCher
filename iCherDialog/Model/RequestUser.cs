using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace iCherDialog.Model
{
    public class RequestUser
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
}
}