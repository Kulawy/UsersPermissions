using System;
using System.Collections.Generic;

namespace DataAccessCore.Models
{
    public partial class UserR
    {
        public UserR()
        {
            UserPermission = new HashSet<UserPermission>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<UserPermission> UserPermission { get; set; }
    }
}
