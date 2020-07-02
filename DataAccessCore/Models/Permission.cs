using System;
using System.Collections.Generic;

namespace DataAccessCore.Models
{
    public partial class Permission
    {
        public Permission()
        {
            UserPermission = new HashSet<UserPermission>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }
        public string PermissionName { get; set; }

        public virtual ICollection<UserPermission> UserPermission { get; set; }
    }
}
