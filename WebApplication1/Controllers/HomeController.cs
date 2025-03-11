using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Models;
using System.Linq;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CarController _carController;

        public HomeController(ILogger<HomeController> logger , ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
            _carController = new CarController(dbContext);
        }

        private readonly ApplicationDbContext _dbContext;


        public IActionResult Index(string Filter = null)
        {
            switch (Filter)
            {
                case "NewArrive":
                case null:
                    {
                        var NewArrive = _carController.NewArrive();
                        return View(NewArrive);
                    }

                case "Recommended":
                    {
                        var Recommended = _carController.Recommended();
                        return View(Recommended);
                    }

                case "Economical":
                    {
                        var Economical = _carController.Economical();
                        return View(Economical);
                    }

                case "ForFamilies":
                    {
                        var ForFamilies = _carController.ForFamilies();
                        return View(ForFamilies);
                    }


                case "Featured":
                    {
                        var Featured = _carController.Featured();
                        return View(Featured);
                    }

                case "Cheap":
                    {
                        var Cheap = _carController.Cheap();
                        return View(Cheap);
                    }

                default:
                    {
                        var NewArrive = _carController.NewArrive();
                        return View(NewArrive);
                    }

            }

        }

        [HttpPost]
        public IActionResult Index(string Option, int price){
            if (Option != null){
                var car = _dbContext.Cars.Where(c => c.Company == Option && c.Price <= price).ToList();
                return View(car);
            }
            else{

                var NewArrive = _carController.NewArrive();
                return View(NewArrive);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
