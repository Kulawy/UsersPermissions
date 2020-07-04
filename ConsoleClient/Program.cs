using System;
using DataAccessCore.Models;
using DataAccessCore.PermissionRepo;
using DataAccessCore.UserRepo;

namespace ConsoleClient
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("DB first app");
            var repoUser = new UserRepository();
            var repoPerm = new PermissionRepository();
            var user1 = repoUser.ReadUser(1);
            var perm = new Permission()
            {
                Id = 0,
                PermissionName = "High",
                RoleName = "Admin"
            };
            repoPerm.CreatePermission(perm);
            repoPerm.Save();
            Console.WriteLine($"{user1.FirstName}");
            Console.WriteLine($"{perm.RoleName}");
            repoPerm.DeletePermission(perm);
            repoPerm.Save();
            Console.ReadKey();
        }
    }
}
