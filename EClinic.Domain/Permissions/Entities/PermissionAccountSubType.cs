using EClinic.Domain.Lookups;
using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class PermissionAccountSubType : DbEntity<User>
    {
        [ForeignKey("Permission")]
        public long PermissionId { get; set; }
        public Permission Permission { get; set; }

        [ForeignKey("AccountSubType")]
        public long AccountSubTypeId { get; set; }
        public SystemAccountSubType AccountSubType { get; set; }
    }
}