using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EClinic.AppDomain.Lookups.Models
{
  public  class EditLookupInput
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}
