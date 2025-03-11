namespace WebApplication1.Models
{
    public class Advertisement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } // رابط الصورة للإعلان
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
