using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IUserPermissionRepository
    {
        void CreateUserPermission(UserR user, Permission permission);
        List<int> ReadUserPermission(int userId);
        void UpdateUserPermission(int updatedId, UserPermission userPermission);
        void DeleteUserPermission(UserR user, Permission permission);
    }
}
