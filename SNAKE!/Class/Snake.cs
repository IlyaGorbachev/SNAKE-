using System;
using System.Threading;

public class Snake
{
	public int xCoordinate;
	public int yCoordinate;
	public string Skin = "o";
	public int Num = 1;
	//Метод для движения змеи
	public void Movem(ConsoleKey key)
	{
		/*  switch (key)
			{
				case ConsoleKey.UpArrow: xCoordinate--;  break;
				case ConsoleKey.DownArrow: xCoordinate++;  break;
				case ConsoleKey.LeftArrow: yCoordinate--;  break;
				case ConsoleKey.RightArrow: yCoordinate++;  break;
			}
		*/
		
		
		switch (key)
		{
			case ConsoleKey.UpArrow: Num=1; break;
			case ConsoleKey.DownArrow: Num = 2; break;
			case ConsoleKey.LeftArrow: Num = 3; break;
			case ConsoleKey.RightArrow: Num = 4; break;
		}

		switch (Num)
		{
			case 1: xCoordinate--; break;
			case 2: xCoordinate++; break;
			case 3: yCoordinate--; break;
			case 4: yCoordinate++; break;
		}

	}		


			




	
		
}
