namespace MainFinanceAPI.Model_Classes
{
    public class Company
    {
        public string symbol { get; set; }
        public float dividendYielTTM { get; set; }
        public float dividendYielPercentageTTM { get; set; }
        public float peRatioTTM { get; set; }
        public float pegRatioTTM { get; set; }
        public float payoutRatioTTM { get; set; }
        public float currentRatioTTM { get; set; }
        public float quickRatioTTM { get; set; }
        public float cashRatioTTM { get; set; }
        public float daysOfSalesOutstandingTTM { get; set; }
        public float daysOfInventoryOutstandingTTM { get; set; }
        public float operatingCycleTTM { get; set; }
        public float daysOfPayablesOutstandingTTM { get; set; }
        public float cashConversionCycleTTM { get; set; }
        public float grossProfitMarginTTM { get; set; }
        public float operatingProfitMarginTTM { get; set; }
        public float pretaxProfitMarginTTM { get; set; }
        public float netProfitMarginTTM { get; set; }
        public float effectiveTaxRateTTM { get; set; }
        public float returnOnAssetsTTM { get; set; }
        public float returnOnEquityTTM { get; set; }
        public float returnOnCapitalEmployedTTM { get; set; }
        public float netIncomePerEBTTTM { get; set; }
        public float ebtPerEbitTTM { get; set; }
        public float ebitPerRevenueTTM { get; set; }
        public float debtRatioTTM { get; set; }
        public float debtEquityRatioTTM { get; set; }
        public float longTermDebtToCapitalizationTTM { get; set; }
        public float totalDebtToCapitalizationTTM { get; set; }
        public float interestCoverageTTM { get; set; }
        public float cashFlowToDebtRatioTTM { get; set; }
        public float companyEquityMultiplierTTM { get; set; }
        public float receivablesTurnoverTTM { get; set; }
        public float payablesTurnoverTTM { get; set; }
        public float inventoryTurnoverTTM { get; set; }
        public float fixedAssetTurnoverTTM { get; set; }
        public float assetTurnoverTTM { get; set; }
        public float operatingCashFlowPerShareTTM { get; set; }
        public float freeCashFlowPerShareTTM { get; set; }
        public float cashPerShareTTM { get; set; }
        public float operatingCashFlowSalesRatioTTM { get; set; }
        public float freeCashFlowOperatingCashFlowRatioTTM { get; set; }
        public float cashFlowCoverageRatiosTTM { get; set; }
        public float shortTermCoverageRatiosTTM { get; set; }
        public float capitalExpenditureCoverageRatioTTM { get; set; }
        public float dividendPaidAndCapexCoverageRatioTTM { get; set; }
        public float priceBookValueRatioTTM { get; set; }
        public float priceToBookRatioTTM { get; set; }
        public float priceToSalesRatioTTM { get; set; }
        public float priceEarningsRatioTTM { get; set; }
        public float priceToFreeCashFlowsRatioTTM { get; set; }
        public float priceToOperatingCashFlowsRatioTTM { get; set; }
        public float priceCashFlowRatioTTM { get; set; }
        public float priceEarningsToGrowthRatioTTM { get; set; }
        public float priceSalesRatioTTM { get; set; }
        public float dividendYieldTTM { get; set; }
        public float enterpriseValueMultipleTTM { get; set; }
        public float priceFairValueTTM { get; set; }
        public float dividendPerShareTTM { get; set; }
    }
    
        
    public class DCF
    {
        public string symbol { get; set; }
        public string date { get; set; }
        public float dcf { get; set; }
        public float StockPrice { get; set; }
    }



}
