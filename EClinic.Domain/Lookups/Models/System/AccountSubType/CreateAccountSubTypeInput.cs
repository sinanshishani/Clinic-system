using EClinic.AppDomain.Lookups.Models;
using System.ComponentModel.DataAnnotations;

namespace EClinic.AppDomain.Lookups
{
    public class CreateAccountSubTypeInput : CreateLookupInput
    {
        [Required]
        public long AccountTypeId { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }
    }
}