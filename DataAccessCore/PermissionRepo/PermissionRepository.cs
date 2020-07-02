using DataAccessCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccessCore.PermissionRepo
{
    public class PermissionRepository : IPermissionRepository
    {
        //It is prefer to not use AddAsync,
        //Use async only for FindFirstAsyn, ToListAsync, SaveAsync
        //Create, Read, Update, Delete are async with SaveAsync
        //To avoid boilerplate code we create Save and SaveAsync To use in Service layer to achieve synch or asynch tasks

        UserPermissionsContext _ctx;

        public PermissionRepository()
        {
            _ctx = new UserPermissionsContext();
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }

        public Permission CreatePermission(Permission permission)
        {
            var entity = _ctx.Permission.Add(permission);
            Save();
            return entity.Entity;
        }

        public Permission ReadPermission(int permissionId)
        {
            return _ctx.Permission.Find(permissionId);
        }

        public void UpdatePermission(int updatedId, Permission permission)
        {
            var entity = _ctx.Permission.Find(updatedId);
            if (entity != null)
            {
                entity.PermissionName = permission.PermissionName;
                entity.UserPermission = permission.UserPermission;
                entity.RoleName = permission.RoleName;
            }
        }

        public void DeletePermission(Permission permission)
        {
            var entity = _ctx.Permission.Remove(permission);
        }

        //ASYNC
        public async Task SaveAsync()
        {
            await _ctx.SaveChangesAsync();
        }

        public async Task<Permission> CreatePermissionAsync(Permission permission)
        {
            var ifOk = _ctx.Permission.Add(permission);
            await _ctx.SaveChangesAsync();
            return ifOk.Entity;
        }

        public async Task<Permission> ReadPermissionAsync(int permissionId)
        {
            return await _ctx.Permission.FindAsync(permissionId);
        }

        public async Task<List<Permission>> ReadPermissionsAsync()
        {
            return await _ctx.Permission.ToListAsync();
        }

        public async Task UpdatePermissionAsync(int updatedId, Permission permission)
        {
            var entity = await _ctx.Permission.FirstOrDefaultAsync(p => p.Id == updatedId);
            if (entity != null)
            {
                entity = permission;
            }
        }

    }
}
