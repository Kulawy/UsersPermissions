using DataAccessCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCore.UserRepo
{
    public interface IUserRepository
    {
        void Save();
        void CreateUser(UserR user);
        UserR ReadUser(int userId);
        void UpdateUser(int updatedId, UserR newUser);
        void DeleteUser(UserR user);

        Task SaveAsync();
        Task<UserR> ReadUserAsync(int userId);
        Task<List<UserR>> ReadUsersAsync();
        Task UpdateUserAsync(int updateId, UserR newUser);
    }
}
