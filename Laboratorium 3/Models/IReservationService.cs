using Laboratorium_3.Models;

namespace Laboratorium_3.Models
{
    public interface IReservationService
    {
        int Add(Reservation reservation);
        Reservation? FindById(int id);
        List<Reservation> FindAll();
        void DeleteById(int id);
        void Update(Reservation reservation);
    }
}
