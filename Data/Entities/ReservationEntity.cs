using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ReservationEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public Adress Adress { get; set; }

        public PokojEntity Pokoj { get; set; }

        public int Pokoj_Id { get; set; }

        [MaxLength(50)]
        public string Wlasciciel { get; set; }

        public decimal Cena { get; set; }

        public ContactEntity Contact { get; set; }
        public int Contact_id { get; set; }
    }
}
