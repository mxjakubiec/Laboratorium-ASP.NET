using Laboratorium_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laboratorium_1.Controllers
{
    public enum Operator
    {
        Unknown, Add, Mul, Sub, Div
    }

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Calculator(Operator op, double? a, double? b)
        {
            if (op == Operator.Unknown || a == null || b == null)
            {
                ViewBag.Error = "Niepoprawne wartości w argumentach";
            }
            else
            {
                ViewBag.Op = op;
                ViewBag.A = a;
                ViewBag.B = b;
                switch (op)
                {
                    case Operator.Unknown:
                        ViewBag.Result = "Błąd";
                        break;
                    case Operator.Add:
                        ViewBag.Result = a + b;
                        break;
                    case Operator.Mul:
                        ViewBag.Result = a * b;
                        break;
                    case Operator.Sub:
                        ViewBag.Result = a - b;
                        break;
                    case Operator.Div:
                        ViewBag.Result = a / b;
                        break;
                }
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}