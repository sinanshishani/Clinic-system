using EClinic.AppDomain.Lookups.Models.SurgeryProcedure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EClinic.AppDomain.Lookups.Models.Surgery
{
  public  class SurgeryDto
    {
        public long id { get; set; }
        public string Name { get; set; }
        public ICollection<SurgeryProcedureDto> SurgeriesProcedures { get; set; }

    }
}
