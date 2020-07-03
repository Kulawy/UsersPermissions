using DataAccessCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessCore.PermissionRepo
{
    public interface IPermissionRepository
    {
        void Save();
        void CreatePermission(Permission permission);
        Permission ReadPermission(int permissionId);
        void UpdatePermission(int updatedId, Permission permission);
        void DeletePermission(Permission permission);

        Task SaveAsync();
        Task<Permission> ReadPermissionAsync(int permissionId);
        Task<List<Permission>> ReadPermissionsAsync();
        Task UpdatePermissionAsync(int updatedId, Permission permission);

    }
}
