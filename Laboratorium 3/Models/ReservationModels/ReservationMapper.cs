using Data.Entities;
using Data.Entities.Reservarion;
using Data.Migrations;
using Data.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Laboratorium_3.Models.ReservationModels
{
    public class ReservationMapper
    {
        public static Reservation FromEntity(ReservationEntity entity)
        {
            return new Reservation()
            {
                Id = entity.Id,
                Data = entity.Data,
                Miasto = entity.Adress.City,
                Adress = $"{entity.Adress.Street} {entity.Adress.PostalCode}",
                Pokoj = entity.Pokoj,
                Wlasciciel = entity.Wlasciciel,
                Cena = entity.Cena
            };
        }

        public static ReservationEntity ToEntity(Reservation model)
        {
            return new ReservationEntity()
            {
                Id = model.Id,
                Data = model.Data,
                Adress = new Adress() 
                { 
                    City = model.Miasto,
                    Street = model.Adress.Split(' ').Length >= 1 ? model.Adress.Split(' ')[0] : model.Adress,
                    PostalCode = model.Adress.Split(' ').Length >= 2 ? model.Adress.Split(' ')[1] : "NULL",
                },
                Pokoj = model.Pokoj,
                Wlasciciel = model.Wlasciciel,
                Cena = model.Cena
            };
        }
    }
}
