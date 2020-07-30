using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EClinic.Domain.Lookups
{
    public class Surgery : AccountLookup
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public ICollection<SurgeriesProcedures> SurgeriesProcedures { get; set; }
    }
}