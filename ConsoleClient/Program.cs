using System;
using DataAccess;
using DataAccessCore.UserRepo;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DB first app");
            var repo = new UserRepository();
            var user1 = repo.ReadUser(1);
            Console.WriteLine($"{user1.FirstName}");
            Console.ReadKey();
        }
    }
}
