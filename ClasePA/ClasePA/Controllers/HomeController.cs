using ClasePA.Data;
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
        private AplicationDBContext bd;

        public HomeController(ILogger<HomeController> logger, IEnrrollements enrrollements, AplicationDBContext _bd)
        {
            _enrrollements = enrrollements;
            _logger = logger;
            bd = _bd;

        }

        public IActionResult Index()
        {

            //var  getInnerJoin= _enrrollements.GetInnerJoin().ToList();

            //  _=getInnerJoin;

            //Linq cosulta 
            var getInnerJoin = from Curso in bd.Courses
                               from Estudiante in bd.Students
                               from relacion in bd.Enrrollements

                               select new
                               {

                                   CusoNombre = Curso.Title,
                                   NombreSt = Estudiante.FirsName,
                                   RelaCuso = relacion.CourseID,
                                   RelacionSTC = relacion.StudentID
                               };

            ViewBag.inner = getInnerJoin;



            return View();
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