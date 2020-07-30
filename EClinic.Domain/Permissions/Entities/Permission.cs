using EClinic.Framework.Data;

namespace EClinic.Domain
{
    public class Permission : DbEntity<User>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAutoPermission { get; set; }
    }
}