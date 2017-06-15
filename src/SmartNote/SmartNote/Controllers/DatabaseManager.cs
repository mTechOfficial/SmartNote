/*
						 DatabaseManager.cs
						   Muhand Jumah
						    06/15/2017
This class will control the database by sending POST requests and fetching it.
*/

using SmartNote.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
//using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json;
//using System.Net.

namespace SmartNote.Controllers
{

    public class DatabaseManager : RestService
    {
        //HttpClient
        HttpClient client;

        public Task LoginUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task RegisterUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
