﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PSSC.Models
{
    public class Rezervare
    {
        public Guid IdUnic { get; set; }
        [Required]
        public string Nume { get; set; }
        [Required]
        public string Prenume { get; set; }
        [Required]

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-ddThh:mm:ss}")]
        [Display(Name = "Data+ora")]
        public DateTime data { get; set; }
        [Required]
        public stareMasina murdarie { get; set; }

        public optiuni optiune1 { get; set; }
        public optiuni optiune2 { get; set; }
        public optiuni optiune3 { get; set; }
        public optiuni optiune4 { get; set; }
        public double total { get; set; }
    }
    public enum stareMasina
    {
        relativ_curata,//15
        murdara,//20
        foarte_murdara//30
    }
    public enum optiuni
    {
        neselectat,//0
        interior,//10
        exterior,//10
        portbagaj,//10
        ceara//5
    }
}
