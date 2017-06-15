/*
						 CodeGenerator.cs
						  Irteza Syed
						 04/11/2017
                         Edited By: Zhi Qiu
                         Changes: Made GenerateCode method public static and removed Console.Write debugging line
                         04/12/2017
 Enumeration for visibility type of groups.
*/
using System;

namespace SmartNote.Controllers
{
    class CodeGenerator
    {
        public CodeGenerator() { }
        protected const int SIZE = 6;
        public static string GenerateCode()
        {
            Random rand = new Random();
            string Alphabet = "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            char[] chars = new char[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                chars[i] = Alphabet[rand.Next(Alphabet.Length)];
            }
            return Alphabet;
        }
    }
}
