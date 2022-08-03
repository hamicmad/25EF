
namespace _25EF
{
    public class Sale
    {
        public int Id { get; set; }
        public string DrugName { get; set; } = string.Empty;
        public int Amount { get; set; }
        public DateTime DateOfSale { get; set; }
        public int Discount { get; set; } = 0;

        public Drug? Drug { get; set; }
    }
}
