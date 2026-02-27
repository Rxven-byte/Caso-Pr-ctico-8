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

        public List<Servicio> GetAllServicios()
        {
            return _context.Servicio.ToList();
        }

        public List<Servicio> GetServiciosActivos()
        {
            return _context.Servicio.Where(s => s.Estado == true).ToList();
        }

        public Servicio GetServicioById(int id)
        {
            return _context.Servicio.Find(id);
        }
    }
}
