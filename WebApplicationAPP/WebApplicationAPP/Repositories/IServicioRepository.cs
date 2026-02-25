using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public interface IServicioRepository
    {
        List<Servicio> GetAll();
        List<Servicio> GetActivos();
        Servicio GetById(int id);
        void Add(Servicio servicio);
        void Update(Servicio servicio);
    }
}
