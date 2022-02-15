using DomainCore.Models;

namespace ServicesInterfaces
{
    public interface IOrder
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