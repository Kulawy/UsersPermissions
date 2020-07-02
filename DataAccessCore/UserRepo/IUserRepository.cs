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
        UserR CreateUser(UserR user);
        UserR ReadUser(int userId);
        UserR UpdateUser(int updatedId, UserR user);
        UserR DeleteUser(UserR user);
    }
}
