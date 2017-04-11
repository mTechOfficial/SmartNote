using System;


namespace SmartNote.Controllers
{
	class CodeGenerator
	{

		public CodeGenerator() {}
		protected const int SIZE = 6;
		string GenerateCode()
		{   
			Random rand = new Random();
			string Alphabet = "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

			char[] chars = new char[SIZE];
			for (int i = 0; i<SIZE; i++)
			{
				chars[i] = Alphabet[rand.Next(Alphabet.Length)];
			}
			Console.Write(Alphabet);
			return Alphabet;
                }
	}
}
