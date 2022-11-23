using Group2_Sis.Data;
using Group2_Sis.Models;
using Microsoft.AspNetCore.Mvc;

namespace Group2_Sis.Controllers
{
    public class StudentController : Controller
    {
        private readonly Konteksti _konteksti;
        public StudentController(Konteksti kon)
        {
            _konteksti = kon;
        }
        public IActionResult Listo()
        {
           List<Studenti> studentet= _konteksti.Studentet.ToList();
            return View(studentet);
        }
    }
}
