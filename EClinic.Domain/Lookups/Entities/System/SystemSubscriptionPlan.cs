using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EClinic.Domain.Lookups
{
    public class SystemSubscriptionPlan : Lookup
    {
        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        public ICollection<SystemAccountType> AccountTypes { get; set; }
    }
}