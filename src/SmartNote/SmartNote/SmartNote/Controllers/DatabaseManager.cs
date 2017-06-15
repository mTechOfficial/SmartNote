using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace SmartNote.Controllers
{
    class DatabaseManager : RestService
    {
        HttpClient client;
        public Task LoginUserAsync(Models.User user)
        {
            throw new NotImplementedException();
        }

        public Task RegisterUserAsync(Models.User user)
        {
            throw new NotImplementedException();
        }
    }
}
