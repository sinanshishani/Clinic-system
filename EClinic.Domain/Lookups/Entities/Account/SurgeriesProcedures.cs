using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EClinic.Domain.Lookups
{
    public class SurgeriesProcedures : AccountLookup
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public int Points { get; set; }

        [Required]
        [ForeignKey("SurgeryProcedure")]
        public long SurgeryProcedureId { get; set; }
        public SurgeryProcedure SurgeryProcedure { get; set; }

        [Required]
        [ForeignKey("Surgery")]
        public long SurgeryId { get; set; }
        public Surgery Surgery { get; set; }
    }
}