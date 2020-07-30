using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EClinic.Domain.Lookups
{
    public class SurgeryProcedure : AccountLookup
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public int Points { get; set; }

        public ICollection<SurgeriesProcedures> SurgeriesProcedures { get; set; }
    }
}