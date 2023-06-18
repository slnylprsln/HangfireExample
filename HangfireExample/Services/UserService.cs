using HangfireExample.Models;

namespace HangfireExample.Services
{
    public class UserService
    {
        public IEnumerable<User> Users;

        public UserService() 
        {
            Users = new List<User>()
            {
                new User { Id = 1, NameSurname = "Selenay Alparslan", Email = "test1@gmail.com", Password = "1234Abcd!"},
                new User { Id = 2, NameSurname = "Taylor Swift", Email = "test2@gmail.com", Password = "1234Abcd!"},
                new User { Id = 3, NameSurname = "Louis Tomlinson", Email = "test3@gmail.com", Password = "1234Abcd!"},
            };
        }

        public IEnumerable<User> GetUsers()
        {
            return Users;
        }
    }
}
