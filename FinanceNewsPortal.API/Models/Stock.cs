namespace FinanceNewsPortal.API.Models
{
    public class Stock
    {
        public List<StockValue> StockValues { get; set; }
    }

    public class StockValue
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public double Percentage { get; set; }
    }
}
