using DataAccess;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My App");
            var repo = new Repository();
            var user1 = repo.ReadUser(1);
            Console.WriteLine($"{user1.FirstName}");
            Console.ReadKey();
        }
    }
}
