using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebApp_1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCoreWebApp_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISamochodRepository _samochodRepository;
        // GET: /<controller>/
        public HomeController(ISamochodRepository samochodRepository)
        {
            _samochodRepository = samochodRepository;
        }
        public IActionResult Index()
        {
            ViewBag.tytul = "Przeglad samochodu";
            var samochody = _samochodRepository.PobierzWszystkieSamochody().OrderBy(s => s.Marka);
            return View(samochody);
        }
    }
}
