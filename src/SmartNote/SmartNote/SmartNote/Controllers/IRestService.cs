/*
						 DatabaseManager.cs
						   Muhand Jumah
						    06/15/2017
This interface will include all tasks needed.
*/

using System.Threading.Tasks;

namespace SmartNote.Controllers
{
    public interface IRestService
    {
        Task<Enums.Login> LoginUserAsync(Models.User user, string pw);
        Task<Enums.Register> RegisterUserAsync(Models.User user, string pw);
    }
}
