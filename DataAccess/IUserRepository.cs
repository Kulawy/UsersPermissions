namespace DataAccess
{
    public interface IUserRepository
    {
        void CreateUser(UserR user);
        UserR ReadUser(int userId);
        void UpdateUser(int updatedId, UserR user);
        void DeleteUser(UserR user);
    }
}