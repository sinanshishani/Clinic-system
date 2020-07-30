using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Framework.Data
{
    public abstract class CreationAuditedDbEntity<TUser> : Entity<long>, ICreationAudited<TUser>, IMayHaveTenant, IAggregatableEntity where TUser : IEntity<long>
    {
        public int? TenantId { get; set; }

        public TUser CreatorUser { get; set; }
        public long? CreatorUserId { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime CreationTime { get; set; }

        public TUser DeleterUser { get; set; }
        public long? DeleterUserId { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}