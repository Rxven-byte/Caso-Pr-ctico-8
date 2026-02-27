using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public interface IReservaRepository
    {
        List<Reserva> GetAllReservas();
        List<Reserva> GetReservasByIdServicio(int idServicio);
        Reserva GetReservaById(int id);
        void AddReserva(Reserva reserva);
    }
}
