using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Bussines;

namespace WebApplicationAPP.Controllers
{
    public class ServicioController : Controller
    {
        private readonly ServicioBussiness _servicioBussiness;

        public ServicioController(ServicioBussiness servicioBussiness)
        {
            _servicioBussiness = servicioBussiness;
        }

        public IActionResult ServiciosDisponibles()
        {
            var servicios = _servicioBussiness.GetServiciosActivos();
            return View(servicios);
        }
    }
}
