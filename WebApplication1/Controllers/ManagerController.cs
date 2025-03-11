using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ManagerController : Controller
    {

        private readonly ApplicationDbContext _dbContext;

        public ManagerController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Manager()
        {
            return View();
        }
        // إضافة سيارة جديدة
        [HttpPost]
        public IActionResult AddNewCar(Car car)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Cars.Add(car);
                _dbContext.SaveChanges();

               return View("Manager", car); // توجيه المستخدم بعد الإضافة
            }


            return View("Manager");
        }


        // عرض بيانات السيارة
        [HttpGet]
        public IActionResult GetCarDetails(string carnum)
        {
            var car = _dbContext.Cars.FirstOrDefault(c => c.CarNumber == carnum);
            if (car == null)
            {
                return NotFound("السيارة غير موجودة.");
            }

            return View("Manager",car); // عرض تفاصيل السيارة
        }

        // حذف السيارة
        [HttpPost]
        public IActionResult DeleteCar(string carnum)
        {
            var carToDelete = _dbContext.Cars.FirstOrDefault(c => c.CarNumber == carnum);
            if (carToDelete == null)
            {
                return NotFound("السيارة غير موجودة.");
            }

            _dbContext.Cars.Remove(carToDelete);

            //var carImages = _dbContext.CarImages.Where(i => i.CarNumber == carnum);
            //if (carImages.Any())
            //{
            //    _dbContext.CarImages.RemoveRange(carImages);
            //}

            _dbContext.SaveChanges();

            return View("Manager"); // إعادة توجيه المستخدم بعد الحذف
        }



    }
}
