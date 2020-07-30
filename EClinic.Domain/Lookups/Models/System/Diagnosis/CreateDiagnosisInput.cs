using EClinic.AppDomain.Lookups.Models;
using System.ComponentModel.DataAnnotations;

namespace EClinic.AppDomain.Lookups
{
    public class CreateDiagnosisInput : CreateLookupInput
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}