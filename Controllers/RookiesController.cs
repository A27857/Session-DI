using System.Runtime.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using C__ASP_.Net_Core_MVC_2.Models;
using System.Text.Json;

namespace C__ASP_.Net_Core_MVC_2.Controllers.Controllers
{
    public class RookiesController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public RookiesController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        static List<Person> members = new List<Person>
        {
            new Person{
                Id = 18,
                FirstName = "Long",
                LastName = "Bao",
                Gender = "Male",
                DateOfBirth = new DateTime(1994,1,16),
                PhoneNumber="",
                BirthPlace = "Bac Ninh",
                IsGraduated  = false,
                Age = 27
            },
            new Person{
                Id = 14,
                FirstName = "Dat",
                LastName = "Dam Tuan",
                Gender = "Male",
                DateOfBirth = new DateTime(1996,7,14),
                PhoneNumber="",
                BirthPlace = "Ha noi",
                IsGraduated  = true,
                Age = 25
            },
            new Person{
                Id = 11,
                FirstName = "Hung",
                LastName = "Ngo Quoc",
                Gender = "Male",
                DateOfBirth = new DateTime(1991,3,7),
                PhoneNumber="",
                BirthPlace = "Hai Phong",
                IsGraduated  = false,
                Age = 30
            },
            new Person{
                Id = 19,
                FirstName = "Van",
                LastName = "Nguyen Cong",
                Gender = "Male",
                DateOfBirth = new DateTime(1998,4,5),
                PhoneNumber="",
                BirthPlace = "Ha Noi",
                IsGraduated  = true,
                Age = 23
            },
            new Person{
                Id = 3,
                FirstName = "Trang",
                LastName = "Nguyen Huyen",
                Gender = "Female",
                DateOfBirth = new DateTime(2002,7,14),
                PhoneNumber="",
                BirthPlace = "Hai Duong",
                IsGraduated  = false,
                Age = 19
            },
            new Person{
                Id = 6,
                FirstName = "Ky",
                LastName = "Nguyen Khac",
                Gender = "Male",
                DateOfBirth = new DateTime(1999,11,12),
                PhoneNumber="",
                BirthPlace = "Ha Noi",
                IsGraduated  = false,
                Age = 22
            },
            new Person{
                Id = 8,
                FirstName = "Phuoc",
                LastName = "Hoang",
                Gender = "Male",
                DateOfBirth = new DateTime(2000,11,25),
                PhoneNumber="",
                BirthPlace = "Hai Phong",
                IsGraduated  = false,
                Age = 21
            },
            new Person{
                Id = 9,
                FirstName = "Hung",
                LastName = "Bui",
                Gender = "Male",
                DateOfBirth = new DateTime(1983,11,13),
                PhoneNumber="",
                BirthPlace = "Ha Noi",
                IsGraduated  = true,
                Age = 38
            }
        };
        public IActionResult Index()
        {
            return View(members);
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Person model)
        {
            //Kiem tra 2 lop, tang tinh an toan, bao mat
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "Invalid Model!";
                return View();
            }
            members.Add(model);
            return RedirectToAction("Index", members);
        }

        public IActionResult Edit(int id)
        {
            var model = members.FirstOrDefault(i => i.Id == id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Person model)
        {
            //Kiem tra 2 lop, tang tinh an toan, bao mat
            if (!ModelState.IsValid)
            {
                ViewBag.Error = JsonSerializer.Serialize(model);
                return View();
            }
            var list = members.Where(p => p.Id != model.Id).ToList();
            list.Insert(0, model);
            members = list;
            return RedirectToAction("Index");
        }

        // public IActionResult Delete(int id)
        // {
        //     var model = members.FirstOrDefault(i => i.Id == id);
        //     return View(model);
        // }

        public IActionResult Delete(Person model)
        {
            var list = members.Where(p => p.Id != model.Id).ToList();
            members = list;
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult GetFullNames()
        {
            var names = members.Select(mb => $"{mb.LastName} {mb.FirstName}").ToList();
            return View("ViewGetFullNamePerson", names);
            // return Json(names);
        }
        public IActionResult GetPersonByGender()
        {
            var student = members.Where(s => s.Gender == "Male").ToList();
            return View("ViewGetPersonByGender", student);
            // var json = JsonSerializer.Serialize(names);
            // return Content(json);
        }
        public IActionResult GetOldestPerson()
        {
            var biggest = members.Max(st => st.Age);
            System.Console.WriteLine(biggest);
            var oldest = members.Where(st => st.Age == biggest).ToList();
            var oldestTemp = oldest.FirstOrDefault();
            return View("ViewGetOldestPerson", oldestTemp);
        }
        public IActionResult GetPersonEqualsYear(int year)
        {
            var equal = members.Where(s => s.DateOfBirth.Year == year).ToList();
            return View("ViewGetPersonEqualsYear", equal);
        }
        public IActionResult GetPersonGreaterThanYear(int year)
        {
            var greater = members.Where(s => s.DateOfBirth.Year > year).ToList();
            return View("ViewGetPersonGreaterThanYear", greater);
        }
        public IActionResult GetPersonLessThanYear(int year)
        {
            var less = members.Where(s => s.DateOfBirth.Year < year).ToList();
            return View("ViewGetPersonLessThanYear", less);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}