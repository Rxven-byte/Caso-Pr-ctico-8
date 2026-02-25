using WebApplicationAPP.Models;
using WebApplicationAPP.Repositories;

namespace WebApplicationAPP.Bussines
{
    public class ServicioBussiness
    {
        private readonly IServicioRepository _repository;

        public ServicioBussiness(IServicioRepository repository)
        {
            _repository = repository;
        }

        public List<Servicio> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Servicio> GetActivos()
        {
            return _repository.GetActivos();
        }

        public Servicio GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Add(Servicio servicio)
        {
            _repository.Add(servicio);
        }

        public void Update(Servicio servicio)
        {
            _repository.Update(servicio);
        }
    }
}
