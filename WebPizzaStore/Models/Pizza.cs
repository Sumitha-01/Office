namespace WebPizzaStore.Models
{
    public class Pizza
    {
        public int id { get; set; }
        public string?  name { get; set; }
        public string? type { get; set; }
        public float price { get; set; }
        public int quantity { get; set; }
    }
}
