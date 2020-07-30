using EClinic.Enums;
using EClinic.Framework.Data;

namespace EClinic.Domain.Lookups
{
    public abstract class Lookup : DbEntity<User>
    {
        public LookupStatus Status { get; set; } = LookupStatus.Active;
    }
}