using System;

namespace CSharpStudy
	
{
	/* 
	주석
	*/
	class Program{
		static void Main(string[] args) 
		{
			Random rand = new Random();
			int aiChoice = rand.Next(0,3); // 0~2 사이의 랜덤 값		
			int choice = Convert.ToInt32(Console.ReadLine());
			
			bool win;
			
			switch (choice)
			{
				case 0:
					Console.WriteLine("당신: 가위");
					break;
				case 1:
				Console.WriteLine("당신: 바위");
				break;
				case 2:
				Console.WriteLine("당신: 보");
				break;
			}
			
			switch (aiChoice)
			{
				case 0:
					Console.WriteLine("나: 가위");
					break;
				case 1:
					Console.WriteLine("나: 바위");
					break;
				case 2:
					Console.WriteLine("나: 보");
					break;
			}
			
			if (choice == aiChoice)
			{
				Console.WriteLine("무승부입니다.");
			}
			else 
			{
				if (choice == 0 && aiChoice == 2 || choice == 1 && aiChoice == 0 || choice == 2 && aiChoice == 1)
				{
					Console.WriteLine("승리입니다.");
				}
				else
				{
					Console.WriteLine("패배입니다.");
				}
			}
		}
	}
}