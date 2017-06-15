/*
						 MySQLController.cs
						   Zhi Qiu
						 06/12/2017
 All controller codes for accessing mysql databases
*/

using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace SmartNote.Controllers
{
    public class MySQLController
    {
        private static readonly string Server = "www.muhandjumah.com";
        private static readonly string Uid = "muhand5_zhi";
        private static readonly string Pwd = "n8A[t*UqtiH7";
        private static readonly string Database = "muhand5_smartnote_development";

        // Method for creating account and takes email and password as parameters
        public static bool CreateAccount(string email, string password)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection($"server={Server};uid={Uid};pwd={Pwd};database={Database};");
                conn.Open();
                new MySqlCommand($"INSERT INTO Users (Email, Password) VALUES ('{email}', '{password}')", conn).ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                System.Diagnostics.Debug.WriteLine($"Message: {ex.Message}");
                return false;
            }

            return true;
        }
    }
}
