using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3.Models
{
    public class Reservation
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole Data jest wymagane.")]
        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        public DateTime? Data { get; set; }

        [Required(ErrorMessage = "Pole Miasto jest wymagane.")]
        [Display(Name = "Miasto")]
        public string Miasto { get; set; }

        [Required(ErrorMessage = "Pole Adres jest wymagane.")]
        [Display(Name = "Adres")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Pole Pokój jest wymagane.")]
        [Display(Name = "Pokój")]
        public string Pokoj { get; set; }

        [Required(ErrorMessage = "Pole Właściciel jest wymagane.")]
        [Display(Name = "Właściciel")]
        public string Wlasciciel { get; set; }

        [Required(ErrorMessage = "Pole Cena jest wymagane.")]
        [Range(0, double.MaxValue, ErrorMessage = "Cena musi być liczbą nieujemną.")]
        [Display(Name = "Cena")]
        public decimal Cena { get; set; }
    }
}
