﻿using System.ComponentModel.DataAnnotations;

namespace EClinic.Domain.Lookups
{
    public class SystemMedicalVisitProcedure : Lookup
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }
    }
}