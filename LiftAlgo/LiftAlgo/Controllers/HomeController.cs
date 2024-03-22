using LiftAlgo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LiftAlgo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static int DefaultFloor = 1;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            LiftViewModel lifeViewModel = new LiftViewModel();
            return View(lifeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public void UpperCall(string floorNumber)
        {
            int floor = Convert.ToInt16(floorNumber);
            //Task.Delay(2000);
        }

        [HttpPost]
        public void LowerCall(string floorNumber)
        {
            int floor = Convert.ToInt16(floorNumber);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}