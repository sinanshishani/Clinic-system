using System;
using System.Collections.Generic;
using System.Text;

namespace EClinic.AppDomain.Lookups.Models
{
   public class PagingRequset
    {
        public PagingRequset()
        {
            MaxResultCount = MaxResultCount < 0 ? 10 : MaxResultCount;
        }
        public int SkipCount { get; set; }
        public int MaxResultCount { get; set; }
    }
}
