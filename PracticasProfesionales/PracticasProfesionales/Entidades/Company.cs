using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasProfesionales.Entidades
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength (30)]
        public string Name { get; set; }
        [Required]
        [StringLength (30)]
        public string Address { get; set; }
        [Required]
        [StringLength (15)]
        public string PostalCode { get; set; }
        [Required]
        [StringLength (100)]
        public string Website { get; set; }
        [Required]
        [StringLength (50)]
        public string Email { get; set; }
        [StringLength (250)]
        public string Photo { get; set; }
    }
}
