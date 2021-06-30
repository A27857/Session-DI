using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using SessionDI.Models;

namespace SessionDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        static List<Person> members = new List<Person>
        {
            new Person{
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

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString("SESSION_USER", "Tuan Dat");
            return View();
        }

        public IActionResult Privacy()
        {
            var user = HttpContext.Session.GetString("SESSION_USER");
            return View("Privacy", user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
