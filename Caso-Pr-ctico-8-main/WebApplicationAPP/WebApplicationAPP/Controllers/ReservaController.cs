using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Bussines;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers
{
    public class ReservaController : Controller
    {
        private readonly ReservaBussiness _reservaBussiness;
        private readonly ServicioBussiness _servicioBussiness;

        public ReservaController(ReservaBussiness reservaBussiness, ServicioBussiness servicioBussiness)
        {
            _reservaBussiness = reservaBussiness;
            _servicioBussiness = servicioBussiness;
        }

        public IActionResult ReservasAdmin(int? idServicio)
        {
            List<Reserva> reservas;

            if (idServicio.HasValue && idServicio.Value > 0)
            {
                reservas = _reservaBussiness.GetReservasByIdServicio(idServicio.Value);
            }
            else
            {
                reservas = _reservaBussiness.GetAllReservas();
            }

            ViewBag.FiltroIdServicio = idServicio;
            return View(reservas);
        }

        public IActionResult BuscarReserva(int? idReserva)
        {
            if (idReserva.HasValue && idReserva.Value > 0)
            {
                var reserva = _reservaBussiness.GetReservaById(idReserva.Value);
                if (reserva != null)
                {
                    return View("DetalleReserva", reserva);
                }
                else
                {
                    ViewBag.Mensaje = "Estimado asociado, no se ha encontrado la reserva, favor realizar una nueva.";
                }
            }

            return View();
        }

        public IActionResult ReservaForm(int idServicio)
        {
            var servicio = _servicioBussiness.GetServicioById(idServicio);
            if (servicio == null)
            {
                return RedirectToAction("ServiciosDisponibles", "Servicio");
            }

            ViewBag.Servicio = servicio;
            return View();
        }

        [HttpPost]
        public IActionResult ReservaForm(Reserva reserva)
        {
            reserva.FechaDeRegistro = DateTime.Now;

            var servicio = _servicioBussiness.GetServicioById(reserva.IdServicio);
            if (servicio != null)
            {
                reserva.MontoTotal = (decimal)(servicio.Monto + (servicio.Monto * servicio.IVA / 100));
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Servicio = servicio;
                return View(reserva);
            }

            _reservaBussiness.AddReserva(reserva);

            return RedirectToAction("DetalleReserva", new { id = reserva.Id });
        }

        public IActionResult DetalleReserva(int id)
        {
            var reserva = _reservaBussiness.GetReservaById(id);
            if (reserva == null)
            {
                return RedirectToAction("BuscarReserva");
            }
            return View(reserva);
        }
    }
}
