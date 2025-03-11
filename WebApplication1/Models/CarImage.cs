namespace WebApplication1.Models
{
    public class CarImage
    {
        public int Id { get; set; } // معرف الصورة (Primary Key)
        public string CarNumber { get; set; } // رقم لوحة السيارة
        public string ImageUrl { get; set; } // رابط الصورة
    }
}
