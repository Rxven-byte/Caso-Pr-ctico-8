using WebApplicationAPP.Data;
using WebApplicationAPP.Models;
using WebApplicationAPP.Repositories;


namespace WebApplicationAPP.Bussines
{
    public class ReservaBussiness
    {
        private readonly AppDbContext _context;

        public ReservaBussiness(AppDbContext context)
        {
            _context = context;
        }

        public void CrearReserva(Reserva reserva)
        {
            var servicio = _context.Servicios.Find(reserva.IdServicio);

            if (servicio == null || servicio.Estado == false)
                throw new Exception("Servicio no disponible.");

            var iva = servicio.IVA > 1 ? servicio.IVA / 100 : servicio.IVA;

            reserva.MontoTotal = servicio.Monto + (servicio.Monto * iva);
            reserva.FechaDeRegistro = DateTime.Now;

            _context.Reservas.Add(reserva);
            _context.SaveChanges();
        }
    }
}
