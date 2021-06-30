using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using SessionDI.Models;
using Microsoft.AspNetCore.Http;

namespace SessionDI.Controllers
{
    public class RookiesController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonServices _person;

        public RookiesController(ILogger<HomeController> logger, IPersonServices person)
        {
            _logger = logger;
            _person = person;
        }
        public IActionResult Index()
        {
            var person = _person.GetAll();
            return View(person);
        }

        public IActionResult Detail(int id)
        {
            var model = _person.GetOne(id);
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            //Kiem tra 2 lop, tang tinh an toan, bao mat
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "Invalid Model!";
                return View();
            }
            _person.Create(person);
            return RedirectToAction("Index", _person);
        }

        public IActionResult Edit(Person person)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Error = JsonSerializer.Serialize(person);
                return View();
            }
            _person.Update(person);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var personTemp = _person.GetOne(id);
            return View(personTemp);
        }

        public IActionResult Result()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            var personTemp = _person.GetOne(id);
            if (personTemp == null)
            {
                return BadRequest();
            }
            // save info of person to session on brower. after, delete action is running
            HttpContext.Session.SetString("DELETE_NAME_TEMP", personTemp.FullNames);
            _person.Delete(id);
            return RedirectToAction("Result");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}