using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Reservarion
{
    public class ReservationEntity
    {
            [Key]
            public int Id { get; set; }

            public DateTime Data { get; set; }

            public Adress Adress { get; set; }

            public string Pokoj { get; set; }
            [MaxLength(50)]
            public string Wlasciciel { get; set; }

            public decimal Cena { get; set; }
    }
}
