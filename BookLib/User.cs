using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log;

namespace BookLib
{
    /// <summary>
    /// Enum for user types
    /// Admin: can use all app functions
    /// Employee: can only sell items
    /// </summary>
    public enum eUserType
    {
        admin,
        employee
    }

    /// <summary>
    /// Class for person of type user contain fields that only user have
    /// </summary>
    public class User : Person
    {
        private string email;
        private string password;       
        private eUserType type;
        private LogWriter log = new LogWriter();

        /// <summary>
        /// constructor that initializes the User data member 
        /// </summary>
        public User(string name, string email, string password, eUserType userType) : base(name)
        {
            Email = email;
            Password = password;
            UserType = userType;
        }
        
        /// <summary>
        /// get and set for email
        /// </summary>
        public string Email
        {
            get { return email; }
            set
            {
                try
                {                   
                    email = value;                    
                }
                catch (Exception ex)
                {
                    log.LogWrite("Assigning user email error: " + ex.Message);
                    throw new Exception("Assigning email error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// get and set for password
        /// </summary>
        public string Password
        {
            get { return password; }
            set
            {
                try
                {
                    password = value;
                }
                catch (Exception ex)
                {
                    log.LogWrite("Assigning password error");
                    throw new Exception("Assigning password error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// get and set for password
        /// </summary>
        public eUserType UserType
        {
            get { return type; }
            set
            {
                try
                {
                    type = value;
                }
                catch (Exception ex)
                {
                    log.LogWrite("Assigning user type error");
                    throw new Exception("Assigning user type error: " + ex.Message);
                }
            }
        }
    }
}
