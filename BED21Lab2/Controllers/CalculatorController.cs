using BED21Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BED21Lab2.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(CalculatorModel calculator, string myButton)
        {

            switch (myButton)
            {
                case "Add":
                    ViewBag.result = calculator.ValueA + calculator.ValueB;
                    break;
                case "Subtract":
                    ViewBag.result = calculator.ValueA - calculator.ValueB;
                    break;
                case "Multiply":
                    ViewBag.result = calculator.ValueA * calculator.ValueB;
                    break;
                case "Divide":
                    ViewBag.result = calculator.ValueA / calculator.ValueB;
                    break;
                default:
                    throw new InvalidOperationException();
            }
            return View(calculator);

        }

      
    }
}
