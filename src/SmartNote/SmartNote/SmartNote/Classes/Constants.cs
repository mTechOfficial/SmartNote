/*
						 Constants.cs
						 Muhand Jumah
						  06/16/2017
This class will hold all public constants
*/

namespace SmartNote.Classes
{
    class Constants
    {
        //public const string SERVER_URL = "http://www.api.mtechofficial.com/api/";

        /*This is the server's URL (Leave it as 10.0.2.2, its the default IP address android uses 
         * to bridge between localhost and emulator. uncomment the above line and comment 
         * this line if the app will run on the actual device.*/
        public const string SERVER_URL = "http://10.0.2.2/SmartNoteServer/api/";
        //public const string SERVER_URL = "http://192.168.29.1/SmartNoteServer/api/";

        //Extension URL to the login page
        //public const string LOGIN_EXT = "login.php?email={0}&password={1}";
        public const string LOGIN_EXT = "login.php";

        //Extension URL to the register page
        public const string REGISTER_EXT = "register.php";
    }
}
