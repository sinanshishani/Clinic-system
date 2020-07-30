using System.ComponentModel.DataAnnotations;

namespace EClinic.Domain.Lookups
{
    public class Allergic : AccountLookup
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}