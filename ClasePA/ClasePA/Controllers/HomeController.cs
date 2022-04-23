using ClasePA.Models;
using ClasePA.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClasePA.Controllers
{

   
    public class HomeController : Controller
    {


        private IEnrrollements _enrrollements;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IEnrrollements enrrollements)
        {
            _enrrollements = enrrollements;
            _logger = logger;
        }

        public IActionResult Index()
        {

          var  getInnerJoin= _enrrollements.GetInnerJoin().ToList();

            _=getInnerJoin;

            return View(getInnerJoin);
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