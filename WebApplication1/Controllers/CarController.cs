using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CarController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CarController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        // إعادة السيارات المضافة حديثا فقط
        public List<Car> NewArrive()
        {
            DateOnly datetimenow = DateOnly.FromDateTime(DateTime.Now);
            var newarrive = _dbContext.Cars.Where(c => c.ArrivalTime > datetimenow.AddDays(-10)).OrderBy(c => Guid.NewGuid()).ToList();

            return newarrive;
        }

        // إعادة السيارات الموصى بها
        public List<Car> Recommended()
        {
            var recommended = _dbContext.Cars.Where(c => c.Recommended == true).OrderBy(c => Guid.NewGuid()).ToList();
            return recommended;
        }

        // إعادة السيارات الاقتصادية
        public List<Car> Economical()
        {
            var economical = _dbContext.Cars.Where(c => c.Economical == true).OrderBy(c => Guid.NewGuid()).ToList();
            return economical;
        }

        // إعادة السيارات المخصصة للعائلات
        public List<Car> ForFamilies()
        {
            var forfamilies = _dbContext.Cars.Where(c => c.ForFamilies == true).OrderBy(c => Guid.NewGuid()).ToList();
            return forfamilies;
        }

        // إعادة السيارات المميزة
        public List<Car> Featured()
        {
            var featured = _dbContext.Cars.Where(c => c.Featured == true).OrderBy(c => Guid.NewGuid()).ToList();
            return featured;
        }

        // رخيصة نسبياَ
        public List<Car> Cheap()
        {
            var cheap = _dbContext.Cars.Where(c => c.Price <= 8000).OrderBy(c => Guid.NewGuid()).ToList();
            return cheap;
        }


        // إعادة سيارة برقم محدد
        public IActionResult ViewCar(string number)
        {
            var car = _dbContext.Cars.FirstOrDefault(c => c.CarNumber == number);
            if (car == null)
            {
                return NotFound(); // يمكن إعادة صفحة خطأ إذا لم يتم العثور على السيارة
            }

            var carimg = _dbContext.CarImages.Where(i => i.CarNumber == number).Take(5).ToList();

            var willsendmodel = new CarAndImg
            {
                MyCar = car,
                MyCarImge = carimg
            };


            return View(willsendmodel); // التأكد من عرض البيانات في الـ View
        }

    }
}
