using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainCore.Models;

namespace ServicesInterfaces
{
    internal interface IUser
    {
        User GetByUserName(string userName);
        string GetUserNameByEmail(string email);
        bool EditBasicUserData(User user);
        User GetUserByID(int id);
        bool DeleteUser(int id);
        IQueryable<User> ListUsers();
        bool ChangePassword(string userName, string newPassword);
        bool SendPasswordReminder(string userName);
        bool RegisterNewUser(RegisterNewUserModel model);
    }
}
