using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3.Models
{
    public class Employee
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podać imię!")]
        [Display(Name="Imie")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podać nazwisko!")]
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }

        [RegularExpression("\\d{11}", ErrorMessage = "Pesel powinien składać się z 11 cyfr")]
        [Required(ErrorMessage = "Proszę podać pesel!")]
        [Display(Name = "Pesel")]
        public string Pesel { get; set; }

        [Required(ErrorMessage = "Proszę podać stanowisko!")]
        [Display(Name = "Stanowisko")]
        public Position Position { get; set; }

        [Required(ErrorMessage = "Proszę podać oddział!")]
        [Display(Name = "Oddział")]
        public string Department { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Niepoprawna data")]
        [Required(ErrorMessage = "Podaj date zatrudnienia")]
        [Display(Name = "Data zatrudnienia")]
        public DateTime HireDate { get; set; }

        [Display(Name = "Data zwolnienia")]
        public DateTime? ReleaseDate { get; set; }
    }
}
