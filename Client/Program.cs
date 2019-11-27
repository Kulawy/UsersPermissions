using DataAccess;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new Repository();

            var user1 = repo.ReadUser(1);

            Console.WriteLine($"{user1.FirstName}");

            Console.ReadKey();
        }
    }
}
