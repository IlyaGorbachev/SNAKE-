using System;


public class Area
{
    public static int Width = 25;
    public static int Height = 25;
    public string[,] Size = new string[Width, Height];
    public string Napoln = "."; 

    //Метод заливки массива данными
    public void Fill(string Stena)
    {
        for(int i = 0; i<Height; i++)
        {
            for(int j = 0; j<Width; j++)
            {
                if (i==0)
                {
                    Size[i, j] = Stena + " ";
                }

                else if (i == (Height-1))
                {
                    Size[i, j] = Stena + " ";
                }
                else if (j == (0) )
                {
                    Size[i, j] = Stena + " ";
                }
                else if (j == Width-1)
                {
                    Size[i, j] = Stena + " ";
                }
                else
                {
                    Size[i, j] = Napoln + " ";
                }

            }
        }

    }

    public void Kadr()
    {
        for(int i=0; i<Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                Console.Write(Size[i,j]);

            }

            Console.WriteLine();
        }
        Console.SetCursorPosition(0, 1);
        
    }
}

