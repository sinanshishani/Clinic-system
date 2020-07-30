using System;
using System.Collections.Generic;
using System.Text;

namespace EClinic.AppDomain.Lookups.Models
{
  public  class GetLookupsInput : PagingRequset
    {
        public bool DeletedOnly { get; set; }
    }
}
