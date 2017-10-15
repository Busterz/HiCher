using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace iCherDialog.Model
{
    public class ResultList
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        [JsonProperty("asOfDate")]
        public object AsOfDate { get; set; }
        [JsonProperty("assetClass")]
        public string AssetClass { get; set; }
        [JsonProperty("assetType")]
        public string AssetType { get; set; }
        [JsonProperty("availability")]
        public string Availability { get; set; }
        [JsonProperty("barraId")]
        public string BarraId { get; set; }
        [JsonProperty("bbIdCompany")]
        public string BbIdCompany { get; set; }
        [JsonProperty("bbIdComposite")]
        public string BbIdComposite { get; set; }
        [JsonProperty("bbIdGlobal")]
        public string BbIdGlobal { get; set; }
        [JsonProperty("bbIdUnique")]
        public string BbIdUnique { get; set; }
        [JsonProperty("bcusip")]
        public string Bcusip { get; set; }
        [JsonProperty("blackrockFund")]
        public bool BlackrockFund { get; set; }
        [JsonProperty("bloombergId")]
        public string BloombergId { get; set; }
        [JsonProperty("bloombergTicker")]
        public string BloombergTicker { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("cusip")]
        public string Cusip { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("eqPricesNavId")]
        public string EqPricesNavId { get; set; }
        [JsonProperty("exchangeAcronym")]
        public string ExchangeAcronym { get; set; }
        [JsonProperty("exchangeBbId")]
        public string ExchangeBbId { get; set; }
        [JsonProperty("exchangeCountryCode")]
        public string ExchangeCountryCode { get; set; }
        [JsonProperty("exchangeMic")]
        public string ExchangeMic { get; set; }
        [JsonProperty("exchangeName")]
        public string ExchangeName { get; set; }
        [JsonProperty("gics1Sector")]
        public string Gics1Sector { get; set; }
        [JsonProperty("gics2IndustryGroup")]
        public string Gics2IndustryGroup { get; set; }
        [JsonProperty("gics3Industry")]
        public string Gics3Industry { get; set; }
        [JsonProperty("gics4SubIndustry")]
        public string Gics4SubIndustry { get; set; }
        [JsonProperty("gicsCode")]
        public string GicsCode { get; set; }
        [JsonProperty("globalId")]
        public string GlobalId { get; set; }
        [JsonProperty("isin")]
        public string Isin { get; set; }
        [JsonProperty("issFtse1Industry")]
        public string IssFtse1Industry { get; set; }
        [JsonProperty("issFtse2SuperSector")]
        public string IssFtse2SuperSector { get; set; }
        [JsonProperty("issFtse3Sector")]
        public string IssFtse3Sector { get; set; }
        [JsonProperty("issFtse4SubSector")]
        public string IssFtse4SubSector { get; set; }
        [JsonProperty("issFtseCode")]
        public string IssFtseCode { get; set; }
        [JsonProperty("legalType")]
        public string LegalType { get; set; }
        [JsonProperty("market")]
        public string Market { get; set; }
        [JsonProperty("marketCode")]
        public string MarketCode { get; set; }
        [JsonProperty("pricingCusip")]
        public string PricingCusip { get; set; }
        [JsonProperty("recordType")]
        public string RecordType { get; set; }
        [JsonProperty("returnOnAssets")]
        public double ReturnOnAssets { get; set; }
        [JsonProperty("riskCusip")]
        public string RiskCusip { get; set; }
        [JsonProperty("score")]
        public double Score { get; set; }
        [JsonProperty("secType")]
        public string SecType { get; set; }
        [JsonProperty("securityGroup")]
        public string SecurityGroup { get; set; }
        [JsonProperty("securityId")]
        public string SecurityId { get; set; }
        [JsonProperty("securityIdType")]
        public string SecurityIdType { get; set; }
        [JsonProperty("securityName")]
        public string SecurityName { get; set; }
        [JsonProperty("securityType")]
        public string SecurityType { get; set; }
        [JsonProperty("sedol")]
        public string Sedol { get; set; }
        [JsonProperty("ticker")]
        public string Ticker { get; set; }
        [JsonProperty("uniqueId")]
        public string UniqueId { get; set; }
        [JsonProperty("updateTimestamp")]
        public object UpdateTimestamp { get; set; }
        [JsonProperty("fundFamilyName")]
        public string FundFamilyName { get; set; }
        [JsonProperty("fundLegalName")]
        public string FundLegalName { get; set; }
        [JsonProperty("inceptionDate")]
        public long? InceptionDate { get; set; }
        [JsonProperty("legalName")]
        public string LegalName { get; set; }
        [JsonProperty("morningstarCategory")]
        public string MorningstarCategory { get; set; }
        [JsonProperty("morningstarCategoryId")]
        public string MorningstarCategoryId { get; set; }
        [JsonProperty("morningstarFundId")]
        public string MorningstarFundId { get; set; }
        [JsonProperty("morningstarSecId")]
        public string MorningstarSecId { get; set; }
        [JsonProperty("oldestShareClassId")]
        public string OldestShareClassId { get; set; }
        [JsonProperty("parentGlobalId")]
        public string ParentGlobalId { get; set; }
        [JsonProperty("portfolioName")]
        public string PortfolioName { get; set; }
        [JsonProperty("stdPerfAsOfDate")]
        public long? StdPerfAsOfDate { get; set; }
        [JsonProperty("stdPerfLoadAdjustedSinceInceptionAnnualized")]
        public double? StdPerfLoadAdjustedSinceInceptionAnnualized { get; set; }
        [JsonProperty("stdPerfSinceInceptionAnnualized")]
        public double? StdPerfSinceInceptionAnnualized { get; set; }
        [JsonProperty("expense")]
        public double? Expense { get; set; }
        [JsonProperty("incomeYield")]
        public double? IncomeYield { get; set; }
        [JsonProperty("prospectusNetExpenseRatio")]
        public double? ProspectusNetExpenseRatio { get; set; }
        [JsonProperty("stdPerfFiveYearAnnualized")]
        public double? StdPerfFiveYearAnnualized { get; set; }
        [JsonProperty("stdPerfLoadAdjustedFiveYearAnnualized")]
        public double? StdPerfLoadAdjustedFiveYearAnnualized { get; set; }
        [JsonProperty("stdPerfLoadAdjustedOneYearAnnualized")]
        public double? StdPerfLoadAdjustedOneYearAnnualized { get; set; }
        [JsonProperty("stdPerfLoadAdjustedThreeYearAnnualized")]
        public double? StdPerfLoadAdjustedThreeYearAnnualized { get; set; }
        [JsonProperty("stdPerfMarketPriceFiveYearAnnualized")]
        public double? StdPerfMarketPriceFiveYearAnnualized { get; set; }
        [JsonProperty("stdPerfMarketPriceOneYearAnnualized")]
        public double? StdPerfMarketPriceOneYearAnnualized { get; set; }
        [JsonProperty("stdPerfMarketPriceThreeYearAnnualized")]
        public double? StdPerfMarketPriceThreeYearAnnualized { get; set; }
        [JsonProperty("stdPerfOneYearAnnualized")]
        public double? StdPerfOneYearAnnualized { get; set; }
        [JsonProperty("stdPerfThreeYearAnnualized")]
        public double? StdPerfThreeYearAnnualized { get; set; }
        [JsonProperty("twelveMonthTrailingYield")]
        public double? TwelveMonthTrailingYield { get; set; }
        [JsonProperty("stdPerfMarketPriceSinceInceptionAnnualized")]
        public double? StdPerfMarketPriceSinceInceptionAnnualized { get; set; }
        [JsonProperty("annualReportNetExpenseRatio")]
        public double? AnnualReportNetExpenseRatio { get; set; }
        [JsonProperty("exchangeBbCompositeId")]
        public string ExchangeBbCompositeId { get; set; }
        [JsonProperty("exchangeType")]
        public string ExchangeType { get; set; }
        [JsonProperty("pbRatio")]
        public double? PbRatio { get; set; }
        [JsonProperty("peRatio")]
        public double? PeRatio { get; set; }
        [JsonProperty("returnOnEquity")]
        public double? ReturnOnEquity { get; set; }
        [JsonProperty("totalMarketCap")]
        public double? TotalMarketCap { get; set; }
        [JsonProperty("yieldToMaturity")]
        public double? YieldToMaturity { get; set; }
        [JsonProperty("stdPerfLoadAdjustedTenYearAnnualized")]
        public double? StdPerfLoadAdjustedTenYearAnnualized { get; set; }
        [JsonProperty("stdPerfTenYearAnnualized")]
        public double? StdPerfTenYearAnnualized { get; set; }
        [JsonProperty("stdPerfMarketPriceTenYearAnnualized")]
        public double? StdPerfMarketPriceTenYearAnnualized { get; set; }
        [JsonProperty("fundId")]
        public int? FundId { get; set; }
        [JsonProperty("portfolioId")]
        public int? PortfolioId { get; set; }
        [JsonProperty("duration")]
        public double? Duration { get; set; }
        [JsonProperty("effectiveDuration")]
        public double? EffectiveDuration { get; set; }
        [JsonProperty("maturity")]
        public double? Maturity { get; set; }
        [JsonProperty("modifiedDuration")]
        public double? ModifiedDuration { get; set; }
        [JsonProperty("oad")]
        public double? Oad { get; set; }
    }
}