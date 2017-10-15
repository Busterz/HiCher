using iCherDialog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace iCherDialog.Service
{
    public class ICherService : BaseHttpService
    {
        public ICherService(IHttpClientFact clientFactory) : base(clientFactory)
        {
        }

        public async Task<string> GetSecuritiesDescription(string userInput)
        {
            var resp = await this.GetAsync<SecuritiesSearchResponse>($"https://www.blackrock.com/tools/hackathon/search-securities?query={userInput}");
            var maxScore = resp.ResultMap.Search_Results[0].MaxScore;
            var desiredScore = resp.ResultMap.Search_Results[0].ResultList[0].Score;

            string desc = "Nothing";
            if (Math.Round(maxScore, 7) == Math.Round(desiredScore, 7))
            {
                desc = resp.ResultMap.Search_Results[0].ResultList[0].Description;
            }

            return desc;
        }
    }
}