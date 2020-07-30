using System.ComponentModel.DataAnnotations;

namespace EClinic.Domain.Lookups
{
    public class Complaint : AccountLookup
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}