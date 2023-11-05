using System.Reflection;

namespace Laboratorium_3.Models
{
    public class MemoryReservationService : IReservationService
    {
        private Dictionary<int, Reservation> _reservations = new Dictionary<int, Reservation>();

        private int id = 1;

        public int Add(Reservation reservation)
        {
            reservation.Id = id++;
            _reservations[reservation.Id] = reservation;
            return reservation.Id;

        }

        public void DeleteById(int id)
        {
            _reservations.Remove(id);
        }

        public List<Reservation> FindAll()
        {
            return _reservations.Values.ToList();
        }

        public Reservation? FindById(int id)
        {
            return _reservations[id];
        }

        public void Update(Reservation reservation)
        {
            if (_reservations.ContainsKey(reservation.Id))
            {
                _reservations[reservation.Id] = reservation;
            }
        }
    }
}
