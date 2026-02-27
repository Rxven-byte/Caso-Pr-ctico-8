using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public interface IServicioRepository
    {
        List<Servicio> GetAllServicios();
        List<Servicio> GetServiciosActivos();
        Servicio GetServicioById(int id);
    }
}
