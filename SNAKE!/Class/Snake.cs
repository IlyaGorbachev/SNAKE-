using System;
using System.Threading;

public class Snake
{
	public int xCoordinate;
	public int yCoordinate;
	public string Skin = "o";
	//Метод для движения змеи
	public void Movem(ConsoleKey key)
	{
		switch (key)
		{
			case ConsoleKey.UpArrow: xCoordinate--;  break;
			case ConsoleKey.DownArrow: xCoordinate++;  break;
			case ConsoleKey.LeftArrow: yCoordinate--;  break;
			case ConsoleKey.RightArrow: yCoordinate++;  break;
		}

	}		


			




	
		
}
