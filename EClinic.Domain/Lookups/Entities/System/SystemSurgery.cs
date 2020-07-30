using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EClinic.Domain.Lookups
{
    public class SystemSurgery : Lookup
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public ICollection<SystemSurgeriesProcedures> SurgeriesProcedures { get; set; }
    }
}