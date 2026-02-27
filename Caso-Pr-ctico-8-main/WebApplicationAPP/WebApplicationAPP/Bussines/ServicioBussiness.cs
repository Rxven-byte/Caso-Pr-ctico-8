using WebApplicationAPP.Models;
using WebApplicationAPP.Repositories;

namespace WebApplicationAPP.Bussines
{
    public class ServicioBussiness
    {
        private readonly IServicioRepository _servicioRepository;

        public ServicioBussiness(IServicioRepository servicioRepository)
        {
            _servicioRepository = servicioRepository;
        }

        public List<Servicio> GetAllServicios()
        {
            return _servicioRepository.GetAllServicios();
        }

        public List<Servicio> GetServiciosActivos()
        {
            return _servicioRepository.GetServiciosActivos();
        }

        public Servicio GetServicioById(int id)
        {
            return _servicioRepository.GetServicioById(id);
        }
    }
}
