using BED21Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BED21Lab2.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PersonFormModel personFormModel)
        {
            ViewBag.Fname = personFormModel.Fname;
            ViewBag.Age = personFormModel.Age;

            return View(personFormModel);   
        }
    }
}
