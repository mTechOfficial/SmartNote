/*
					  DatabaseManager.cs
						 Muhand Jumah
						  06/17/2017
This class takes care of any database function including registering to the database, checking username,pw, etc...
*/

using SmartNote.Models;
using System.Threading.Tasks;

namespace SmartNote.Controllers
{
    public class DatabaseManager
    {
        //Interface object
        IRestService restService;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="service">An interface object</param>
        public DatabaseManager(IRestService service)
        {
            restService = service;                                  //Initialize interface object
        }

        /// <summary>
        /// Login asynchronously by calling the RestService implementation and return an Enum as a result
        /// </summary>
        /// <param name="user">A user object</param>
        /// <param name="pw">Password to login</param>
        /// <returns>Enum.Login</returns>
        public Task<Enums.Login> Login(User user, string pw)
        {
            return restService.LoginUserAsync(user, pw);
        }

        /// <summary>
        /// Register asynchronously by calling the RestService implementation and return an Enum as a result
        /// </summary>
        /// <param name="user">A new user to register</param>
        /// <returns>Enum.Register</returns>
        public Task<Enums.Register> Register(User user)
        {
            return restService.RegisterUserAsync(user);
        }

    }
}
