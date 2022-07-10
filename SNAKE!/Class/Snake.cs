using System;
using System.Threading;

public class Snake
{
	public int xCoordinate;
	public int yCoordinate;
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
			case ConsoleKey.UpArrow: Num = 1; break;
			case ConsoleKey.DownArrow: Num = 2; break;
			case ConsoleKey.LeftArrow: Num = 3; break;
			case ConsoleKey.RightArrow: Num = 4; break;
		}

		
	}		


			




	
		
}
