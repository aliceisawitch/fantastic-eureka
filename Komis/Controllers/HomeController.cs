using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Komis.Models;
using Komis.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Komis.Controllers
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
            var samochody = _samochodRepository.PobierzWszystkieSamochody().OrderBy(s => s.Marka);
            var homeVM = new HomeVM()
            {
                Tytul = "Przeglad Samochodow",
                Samochody = samochody.ToList()
            };
            return View(homeVM);
        }
    }
}
