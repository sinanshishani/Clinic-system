using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EClinic.Domain.Lookups
{
    public class SystemAccountType : Lookup
    {
        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        public ICollection<SystemAccountSubType> SubTypes { get; set; }
    }
}