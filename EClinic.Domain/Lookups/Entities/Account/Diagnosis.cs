using System.ComponentModel.DataAnnotations;

namespace EClinic.Domain.Lookups
{
    public class Diagnosis : AccountLookup
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}