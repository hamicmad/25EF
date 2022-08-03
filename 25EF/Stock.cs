
namespace _25EF
{
    public class Stock
    {
        public string DrugName { get; set; } = string.Empty;
        public DateTime ExpirationDate { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public Drug? Drug { get; set; }
    }
}
