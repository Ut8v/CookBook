using CookBook.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.services
{
    public interface IUserInfo
    {
        Task<bool> UserExists(string email, string password);
        Task AddUser(UserDB user);
    }
}
