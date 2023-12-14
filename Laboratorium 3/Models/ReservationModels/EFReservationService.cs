using Data;
using Data.Entities;
using Data.Entities.Reservarion;

namespace Laboratorium_3.Models.ReservationModels
{
    public class EFReservationService : IReservationService
    {
        private readonly AppDbContext _context;

        public EFReservationService(AppDbContext context)
        {
            _context = context;
        }
        public int Add(Reservation reservation)
        {
            var e = _context.Reservations.Add(ReservationMapper.ToEntity(reservation));
            _context.SaveChanges();
            return e.Entity.Id;
        }

        public Reservation? FindById(int id)
        {
            var entity = _context.Reservations.Find(id);
            if (entity != null)
            {
                return ReservationMapper.FromEntity(entity);
            }
            return null;
        }

        public List<Reservation> FindAll()
        {
            return _context.Reservations.Select(e => ReservationMapper.FromEntity(e)).ToList();
        }

        public void DeleteById(int id)
        {
            ReservationEntity? find = _context.Reservations.Find(id);
            if (find != null)
            {
                _context.Reservations.Remove(find);
                _context.SaveChanges();
            }
        }

        public void Update(Reservation reservation)
        {
            _context.Reservations.Update(ReservationMapper.ToEntity(reservation));
            _context.SaveChanges();

        }

        public PagingList<Reservation> FindPage(int page, int size)
        {
            return PagingList<Reservation>.Create(
            (p, s) => _context.Reservations.OrderBy(c => c.Wlasciciel)
                .Skip((p - 1) * s)
                .Take(s)
                .Select(ReservationMapper.FromEntity)
                .ToList(),
                page,
                size,
                _context.Reservations.Count()
            );  
        }

        public Task<int> AddAsync(Reservation reservation)
        {
            return Task.Run(() =>
            {
                return Add(reservation);
            });
        }

        public Task<Reservation?> FindByIdAsync(int id)
        {
            return Task.Run(() =>
            {
                return FindById(id);
            });
        }

        public Task<List<Reservation>> FindAllAsync()
        {
            return Task.Run(() =>
            {
                return FindAll();
            });
        }

        public Task DeleteByIdAsync(int id)
        {
            return Task.Run(() =>
            {
                DeleteById(id);
            });
        }

        public Task UpdateAsync(Reservation reservation)
        {
            return Task.Run(() =>
            {
                Update(reservation);
            });
        }

        public Task<PagingList<Reservation>> FindPageAsync(int page, int size)
        {
            return Task.Run(() =>
            {
                return FindPage(page, size);
            });
        }

    }
}
