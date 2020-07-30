using System.ComponentModel.DataAnnotations;

namespace EClinic.Domain.Lookups
{
    public class SystemAllergic : Lookup
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}