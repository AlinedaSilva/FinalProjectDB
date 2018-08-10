using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFinderDB
{
    class Program
    {
        static void Main(string[] args)
        {
            User U1 = new User() { FirstName = "Aline", LastName = "da Silva", Phone = 0896754342, Email = "acarmodasilva@yahoo.com.br" };
            User U2 = new User() { FirstName = "John", LastName = "Doyle", Phone = 089675765, Email = "john@yahoo.com.br" };

            FoodFinderContext UsersContext = new FoodFinderContext();
            UsersContext.Users.Add(U1);
            UsersContext.Users.Add(U2);

        }
    }
}
