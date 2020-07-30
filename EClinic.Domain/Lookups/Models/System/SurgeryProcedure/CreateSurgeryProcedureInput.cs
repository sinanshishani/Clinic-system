using EClinic.AppDomain.Lookups.Models;
using System.ComponentModel.DataAnnotations;

namespace EClinic.AppDomain.Lookups
{
    public class CreateSurgeryProcedureInput : CreateLookupInput
    {
        [Required]
        public int Points { get; set; }
        public string Number { get; set; }
    }
}