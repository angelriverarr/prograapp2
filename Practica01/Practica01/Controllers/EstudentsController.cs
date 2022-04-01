using Microsoft.AspNetCore.Mvc;
using Practica01.Models;
using Practica01.Services;

namespace Practica01.Controllers
{
    public class EstudentsController : Controller
    {

        private IEstudents Estudents;

        public EstudentsController(IEstudents estudents)
        {
            Estudents = estudents;
        }

        public IActionResult Index()
        {
            Estudiantes es= new Estudiantes();
            es.id = 1;
            es.name = "Angell";
            es.lastName = "Gabriel2";
            //Estudents.AddStudent(es); //para agregar
            //Estudents.DeleteStudent(es);//eliminar
            //Estudents.UpdateStudent(es); //actualizar ya ingresado
            Estudents.GetAll();
            return View();
        }
    }
}
