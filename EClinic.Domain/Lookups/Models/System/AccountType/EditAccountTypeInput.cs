using EClinic.AppDomain.Lookups.Models;
using System.ComponentModel.DataAnnotations;

namespace EClinic.AppDomain.Lookups
{
    public class EditAccountTypeInput : EditLookupInput
    {
        [StringLength(500)]
        public string Notes { get; set; }
    }
}