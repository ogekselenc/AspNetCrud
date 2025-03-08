namespace AspNetCrud.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Initialize to empty string
        public decimal Price { get; set; }
    }
}