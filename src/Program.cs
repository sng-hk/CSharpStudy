using System;

namespace CSharpStudy
	
{
	
	class Program{
		enum Choice
		{
			a,
			b,
			c
		}
		static void Main(string[] args) 
		{
			int choice = 0;
			switch (choice)
			{
				case (int)Choice.a:
					Console.WriteLine("choice equals a");
					break;
				default:
					Console.WriteLine("xx");
					break;
			}
		}
	}
}