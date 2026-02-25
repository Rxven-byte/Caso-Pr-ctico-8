using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Bussines;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers
{
    public class ServicioController : Controller
    {
        private readonly ServicioBussiness _bussiness;

        public ServicioController(ServicioBussiness bussiness)
        {
            _bussiness = bussiness;
        }

        public IActionResult Index()
        {
            return View(_bussiness.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Servicio servicio)
        {
            if (!ModelState.IsValid)
                return View(servicio);

            _bussiness.Add(servicio);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            return View(_bussiness.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Servicio servicio)
        {
            _bussiness.Update(servicio);
            return RedirectToAction(nameof(Index));
        }
    }
}
