using InternetShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InternetShop.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private static readonly List<Employee> _Employees = new()
        {
            new Employee { Id = 1, LastName = "Иванов", FirstName = "Иван", Paronymic = "Иванович", Age = 37 },
            new Employee { Id = 2, LastName = "Сидоров", FirstName = "Сидор", Paronymic = "Сидорович", Age = 30 },
            new Employee { Id = 3, LastName = "Петров", FirstName = "Петров", Paronymic = "Петрович", Age = 25 },

        };

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Employees()
        {
            return View(_Employees);
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
