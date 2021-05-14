﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasProfesionales.Entidades
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength (30)]
        public string Firstname { get; set; }
        [Required]
        [StringLength (40)]
        public string LastName { get; set; }
        [Required]
        [StringLength (15)]
        public string PhoneNumber { get; set; }
        [StringLength (15)]
        public string CellPhone { get; set; }
        [StringLength (250)]
        public string Photo { get; set; }
        [Required]
        [StringLength (50)]
        public string Email { get; set; }
        [StringLength (50)]
        public string Departament { get; set; }
    }
}
