using System;
using System.Collections.Generic;

namespace DataAccessCore.Models
{
    public partial class UserPermission
    {
        public int IdUserPermission { get; set; }
        public int IdUser { get; set; }
        public int IdPermission { get; set; }

        public virtual Permission IdPermissionNavigation { get; set; }
        public virtual UserR IdUserNavigation { get; set; }
    }
}
