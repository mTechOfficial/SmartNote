﻿/*
					    RestService.cs
						 Muhand Jumah
						  06/17/2017
This class implements the RestService interface
*/
using System;
using System.Text;
using System.Threading.Tasks;
using SmartNote.Enums;
using SmartNote.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Diagnostics;
using SmartNote.Classes;

namespace SmartNote.Controllers
{
    class RestService : IRestService
    {
        //Needed to connect to the server
        HttpClient client;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public RestService()
        {
            var authData = string.Format("{0}:{1}", "", "");                                            //Server Authentication
            var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));             //Setup authentication
     
            client = new HttpClient();                                                                  //Initialize new object of the client
            client.MaxResponseContentBufferSize = 256000;                                               //Max a buffer
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);   //Authentication
        }

        /// <summary>
        /// Implement the login function by sending a POST request to the server and recieve a JSON file
        /// </summary>
        /// <param name="user">A user object</param>
        /// <param name="pw">Password to login</param>
        /// <returns>Login Enum</returns>
        public async Task<Enums.Login> LoginUserAsync(User user, string pw)
        {
            JResponse.Login temp = new JResponse.Login();                               //Create a temporary json template
            Enums.Login res = Login.UnknownError;                                       //Create a result enum object

            //Create the URL
            var uri = new Uri(string.Format(Constants.SERVER_URL + Constants.LOGIN_EXT, user.Email, pw));

            //Try to get results back
            try
            {
                var response = await client.GetAsync(uri);                              //Try to send the request

                //Check if request sent back success code
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();           //Read the content from the response
                    
                    temp = JsonConvert.DeserializeObject<JResponse.Login>(content);     //Fill the temporary template

                    //Check if logged in was successful
                    if (temp.error == 0 && temp.success == 1)
                        res = Login.Success;                                            //Set res to be success

                }
            }
            catch (Exception ex)
            {
                //In case of an error then debug it
                //TODO:Remove this line when publishing
                Debug.WriteLine("ERROR {0}", ex.Message);
            }

            return res;
        }

        /// <summary>
        /// Implement the register function by sending a POST request to the server
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<Enums.Register> RegisterUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
