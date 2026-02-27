using WebApplicationAPP.Models;
using WebApplicationAPP.Repositories;

namespace WebApplicationAPP.Bussines
{
    public class ReservaBussiness
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservaBussiness(IReservaRepository reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }

        public List<Reserva> GetAllReservas()
        {
            return _reservaRepository.GetAllReservas();
        }

        public List<Reserva> GetReservasByIdServicio(int idServicio)
        {
            return _reservaRepository.GetReservasByIdServicio(idServicio);
        }

        public Reserva GetReservaById(int id)
        {
            return _reservaRepository.GetReservaById(id);
        }

        public void AddReserva(Reserva reserva)
        {
            _reservaRepository.AddReserva(reserva);
        }
    }
}
