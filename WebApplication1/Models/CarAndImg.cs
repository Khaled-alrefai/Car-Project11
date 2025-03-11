namespace WebApplication1.Models
{
    public class CarAndImg
    {
        public int Id { get; set; }
        public Car MyCar { get; set; }
        public List<CarImage> MyCarImge { get; set; }
    }
}
