using System.Threading.Tasks;
using DataAccessCore.Models;
using DataAccessCore.PermissionRepo;
using DataAccessCore.UserRepo;
using Xunit;

namespace DataAccessCore.Tests
{
    public class TestSample
    {
        [Fact]
        public void GetFirstUserTest()
        {
            var repo = new UserRepository();
            var user1 = repo.ReadUser(1);
            Assert.True(user1.Id == 1);
        }

        [Fact]
        public void GetFirstPermissionTest()
        {
            var repo = new PermissionRepository();
            var user1 = repo.ReadPermission(1);
            Assert.True(user1.Id == 1);
        }

        [Fact]
        public async Task AddPermissionTest()
        {
            var permissionNameTest = "TestPerm";
            var repo = new PermissionRepository();
            var perm = new Permission()
            {
                PermissionName = permissionNameTest,
                RoleName = "TestRole"
            };
            repo.CreatePermission(perm);
            await repo.SaveAsync();
            var addedPerm = await repo.ReadPermissionAsync(perm.Id);
            Assert.True(addedPerm.RoleName == permissionNameTest);
        }

    }
}
