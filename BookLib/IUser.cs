using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLib
{
    /// <summary>
    /// Interface for the users
    /// </summary>
    interface IUser
    {
        /// <summary>
        /// adds new user to the UserTable table in the database
        /// </summary>
        /// <param name="user"></param>
        void AddUser(User user);

        /// <summary>
        /// delete user from db
        /// </summary>
        /// <param name="userId"></param>
        void DeleteUser(int userId);

        /// <summary>
        /// gets the user type to know the permissions of the user (admin user can use all function of the app)
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        eUserType GetUserType(string email);

        /// <summary>
        /// checks if user exits in database by email and password
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool IsUserExists(string email, string password);
    }
}
