
using System.Collections.Generic;
using System.Data.Entity;

namespace DataAccess
{
    public class Repository : IUserRepository, IPermissionsRepository, IUserPermissionRepository
    {
        UsersPermissionsDBEntities _db;

        public Repository()
        {
            _db = new UsersPermissionsDBEntities();
        }

        public void CreateUser(UserR user)
        {
            _db.UserR.Add(user);
            _db.SaveChanges();
            
        }

        public UserR ReadUser(int userId)
        {
            return _db.UserR.Find(userId);
        }

        public void UpdateUser(int idUserToUpdate, UserR user)
        {
            var oldUser = _db.UserR.Find(idUserToUpdate);
            oldUser.FirstName = user.FirstName;
            oldUser.LastName = user.LastName;
            _db.Entry(user).State = EntityState.Modified;
            _db.SaveChanges();

        }

        public void DeleteUser(UserR user)
        {
            _db.UserR.Remove(user);
            _db.SaveChanges();
        }

        public void CreatePermission(Permission permission)
        {
            _db.Permission.Add(permission);
            _db.SaveChanges();
        }

        public Permission ReadPermission(int permissionId)
        {
            return _db.Permission.Find(permissionId);
        }

        public void UpdatePermission(int idPermissionToUpdate, Permission permission)
        {
            var oldPermission = _db.Permission.Find(idPermissionToUpdate);
            oldPermission.PermissionName = permission.PermissionName;
            oldPermission.RoleName = permission.RoleName;
            _db.Entry(permission).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void DeletePermission(Permission permission)
        {
            _db.Permission.Remove(permission);
            _db.SaveChanges();
        }

        public void CreateUserPermission(UserR user, Permission permission)
        {
            var userPerm = new UserPermission()
            {
                Id_User = user.Id,
                Id_Permission = permission.Id
            };
            _db.UserPermission.Add(userPerm);
            _db.SaveChanges();
        }

        public List<int> ReadUserPermission(int userId)
        {
            var listOfpermissions = new List<int>();

            _db.UserPermission.ForEachAsync(userPermission => {
                if ( userPermission.Id_User == userId)
                {
                    listOfpermissions.Add(userPermission.Id_Permission);
                }
            });

            return listOfpermissions;
        }

        public void UpdateUserPermission(int updatedId, UserPermission userPermission)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteUserPermission(UserR user, Permission permission)
        {
            var listToRemove = new List<UserPermission>();

            _db.UserPermission.ForEachAsync(userPermission => {
                if (userPermission.Id_User == user.Id && userPermission.Id_Permission == permission.Id)
                {
                    listToRemove.Add(userPermission);
                }
            });

            if ( listToRemove.Count > 0)
            {
                listToRemove.ForEach(x => _db.UserPermission.Remove(x));
            }

        }
    }
}