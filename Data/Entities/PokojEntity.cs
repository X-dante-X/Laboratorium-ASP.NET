using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class PokojEntity
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Rozmiar { get; set; }
        public int Pietro { get; set;}
        public ReservationEntity Reservation { get; set; }
        public int Reservation_Id { get; set; }
    }
}
