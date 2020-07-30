using EClinic.AppDomain.Lookups.Models;
using System.ComponentModel.DataAnnotations;

namespace EClinic.AppDomain.Lookups
{
    public class CreateDiseaseInput : CreateLookupInput
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}