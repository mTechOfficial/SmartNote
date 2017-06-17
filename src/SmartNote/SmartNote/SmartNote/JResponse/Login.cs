/*
					       Login.cs
						 Muhand Jumah
						  06/17/2017
This is a JSON template, when recieving request from the server, it will send a 
JSON response and that response must include all fields this template have (no more and no less).
Every field from the response will be mapped to its corresponding field name in this template; therefore,
all field's names must match the json fields.
*/

namespace SmartNote.JResponse
{
    public class Login
    {
        public int error { set; get; }
        public int success { set; get; }
        public string email { set; get; }
        public string message { set; get; }
    }
}
