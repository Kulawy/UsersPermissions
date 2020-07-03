
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessCore.UserRepo
{
    public class UserRepository : IUserRepository
    {
        private UserPermissionsContext _ctx;

        public UserRepository()
        {
            _ctx = new UserPermissionsContext();
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }

        public void CreateUser(UserR user)
        {
            _ctx.UserR.Add(user);
        }
        public UserR ReadUser(int userId)
        {
            return _ctx.UserR.Find(userId);
        }
        public void UpdateUser(int updatedId, UserR user)
        {
            var entity = _ctx.UserR.Find(updatedId);
            if (entity != null)
            {
                entity.FirstName = user.FirstName;
                entity.LastName = user.LastName;
                entity.Name = user.Name;
                entity.UserPermission = user.UserPermission;
            }
        }

        public void DeleteUser(UserR user)
        {
            _ctx.UserR.Remove(user);
        }

        public async Task SaveAsync()
        {
            await _ctx.SaveChangesAsync();
        }

        public async Task<UserR> ReadUserAsync(int userId)
        {
            return await _ctx.UserR.FindAsync(userId);
        }

        public async Task<List<UserR>> ReadUsersAsync()
        {
            return await _ctx.UserR.ToListAsync();
        }

        public async Task UpdateUserAsync(int updateId, UserR newUser)
        {
            var entity = await _ctx.UserR.FirstOrDefaultAsync(u => u.Id == updateId);
            if (entity != null)
            {
                entity.FirstName = newUser.FirstName;
                entity.LastName = newUser.LastName;
                entity.Name = newUser.Name;
                entity.UserPermission = newUser.UserPermission;
            }
        }

        

        
    }
}
