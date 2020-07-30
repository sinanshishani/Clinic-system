using System.ComponentModel.DataAnnotations;

namespace EClinic.Domain.Lookups
{
    public class SystemDisease : Lookup
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}