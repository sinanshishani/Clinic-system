using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EClinic.AppDomain.Lookups.Models
{
  public  class CreateLookupInput
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}
