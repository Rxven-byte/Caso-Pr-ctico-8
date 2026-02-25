using WebApplicationAPP.Data;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public class ServicioRepository : IServicioRepository
    {
        private readonly AppDbContext _context;

        public ServicioRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Servicio> GetAll()
        {
            return _context.Servicios.ToList();
        }

        public List<Servicio> GetActivos()
        {
            return _context.Servicios
                           .Where(s => s.Estado == true)
                           .ToList();
        }

        public Servicio GetById(int id)
        {
            return _context.Servicios.Find(id);
        }

        public void Add(Servicio servicio)
        {
            servicio.FechaDeRegistro = DateTime.Now;
            _context.Servicios.Add(servicio);
            _context.SaveChanges();
        }

        public void Update(Servicio servicio)
        {
            servicio.FechaDeModificacion = DateTime.Now;
            _context.Servicios.Update(servicio);
            _context.SaveChanges();
        }
    }
}
