using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Laboratorium_3.Models
{
    public enum Position
    {
        [Display(Name = "Junior")] Junior = 1,
        [Display(Name = "Senior")] Senior = 2,
        [Display(Name = "Lider")] Leader = 3,
        [Display(Name = "Kierownik")] Manager = 4,
        [Display(Name = "Dyrektor")] Director = 5
    }
}
