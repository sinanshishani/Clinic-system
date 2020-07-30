using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EClinic.Framework.Data
{
    public abstract class DbEntity<TUser> : Entity<long>, /*IFullAudited<>,*/ IMayHaveTenant, IAggregatableEntity where TUser : IEntity<long>
    {
        public int? TenantId { get; set; }

        public virtual TUser CreatorUser { get; set; }
        [ForeignKey("CreatorUser")]
        public long? CreatorUserId { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime CreationTime { get; set; }

        public virtual TUser LastModifierUser { get; set; }
        [ForeignKey("LastModifierUser")]
        public long? LastModifierUserId { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? LastModificationTime { get; set; }

        public virtual TUser DeleterUser { get; set; }
        [ForeignKey("DeleterUser")]
        public long? DeleterUserId { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}