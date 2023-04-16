using System.Text.Json.Serialization;

namespace FinanceNewsPortal.Web.Models
{
    public class Stock
    {
        [JsonPropertyName("queryCount")]
        public int QueryCount { get; set; }

        [JsonPropertyName("resultsCount")]
        public int ResultsCount { get; set; }

        [JsonPropertyName("adjusted")]
        public bool Adjusted { get; set; }

        [JsonPropertyName("results")]
        public IEnumerable<StockValue> Results { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        public string LastUpdateDateString { get; set; }
    }

    public class StockValue
    {
        [JsonPropertyName("T")]
        public string TradedUnderSymbol { get; set; }

        [JsonPropertyName("v")]
        public double Volume { get; set; }

        [JsonPropertyName("vw")]
        public double VolumeWeighted { get; set; }

        [JsonPropertyName("o")]
        public double OpenPrice { get; set; }

        [JsonPropertyName("c")]
        public double ClosePrice { get; set; }

        [JsonPropertyName("h")]
        public double HighestPrice { get; set; }

        [JsonPropertyName("l")]
        public double LowestPrice { get; set; }

        [JsonPropertyName("t")]
        public object UnixMsecTimestamp { get; set; }

        [JsonPropertyName("n")]
        public int NumberOfTransactions { get; set; }
    }
}
