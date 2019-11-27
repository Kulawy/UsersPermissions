namespace DataAccess
{
    internal interface IPermissionsRepository
    {
        void CreatePermission(Permission permission);
        Permission ReadPermission(int permissionId);
        void UpdatePermission(int updatedId, Permission permission);
        void DeletePermission(Permission permission);
    }
}