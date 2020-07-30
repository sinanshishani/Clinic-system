using EClinic.Enums;

namespace EClinic.AppDomain.Lookups.Models.Bank.Dto
{
    public class LookupDto
    {
        public long Id { get; set; }
        public LookupStatus Status { get; set; }
        public string Name { get; set; }
    }
}
