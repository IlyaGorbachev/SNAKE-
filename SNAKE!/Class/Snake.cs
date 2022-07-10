using System;
using System.Threading;

public class Snake
{
	public int xCoordinate;
	public int yCoordinate;
	public int size = 3;
	public int score = 0;
	public string Skin = "o";
	//Метод для движения змеи
	public void Movem(ConsoleKey key, ref int Num)
	{
		/*
		switch (key)
		{
			case ConsoleKey.UpArrow: xCoordinate--;  break;
			case ConsoleKey.DownArrow: xCoordinate++;  break;
			case ConsoleKey.LeftArrow: yCoordinate--;  break;
			case ConsoleKey.RightArrow: yCoordinate++;  break;
		}
		*/
		switch (key)
		{
			case ConsoleKey.UpArrow : if (Num != 2) { Num = 1; }; break;
			case ConsoleKey.DownArrow: if (Num != 1) { Num = 2; }; break;
			case ConsoleKey.LeftArrow: if (Num != 4) { Num = 3; }; break;
			case ConsoleKey.RightArrow: if (Num != 3) { Num = 4; }; break;
		}

		
	}		


			




	
		
}
