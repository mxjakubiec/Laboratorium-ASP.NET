using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeData.Entities
{
    public class EmployeeEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }

        [Required]
        [MaxLength(11)]
        [MinLength(11)]
        public string Pesel { get; set; }

        [Required]
        public int Position { get; set; }

        [Required]
        public string Department { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime HireDate { get; set; }

        [Display]
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }
    }
}
