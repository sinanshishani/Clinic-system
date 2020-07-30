using EClinic.Domain.Lookups;
using EClinic.Framework.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Domain
{
    public class PermissionAccountType : DbEntity<User>
    {
        [ForeignKey("Permission")]
        public long PermissionId { get; set; }
        public Permission Permission { get; set; }

        [ForeignKey("AccountType")]
        public long AccountTypeId { get; set; }
        public SystemAccountType AccountType { get; set; }
    }
}