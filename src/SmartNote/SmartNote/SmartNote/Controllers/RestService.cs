/*
						 DatabaseManager.cs
						   Muhand Jumah
						    06/15/2017
This interface will include all tasks needed.
*/

using System.Threading.Tasks;

namespace SmartNote.Controllers
{
    public interface RestService
    {
        Task LoginUserAsync(Models.User user);
        Task RegisterUserAsync(Models.User user);
    }
}
