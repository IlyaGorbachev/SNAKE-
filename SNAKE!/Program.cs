using System;
using System.Threading;

namespace SNAKE_
{
    class Program
    {
        static void Main(string[] args)
        {
            int mon = 1;
            //Меню
            Console.WriteLine("Press any key...");
            ConsoleKey key_ = ConsoleKey.UpArrow;
            
            //Создаем объекты
            Area pole = new Area();
            Snake player = new Snake();

            //Содаем поток SnakeMath(Расчет змеи)
            Thread snake = new Thread(SnakeMath);
            Thread move = new Thread(MoveSnake);
            //Начальные координаты змеи
            player.xCoordinate = 2;
            player.yCoordinate = 2;
            
            //Цвет фона
            Console.BackgroundColor = ConsoleColor.Black;
            
            //Запускаем потоки
            move.Start();
            snake.Start();

            
            
            void SnakeMath()
            {
                
                while (true)
                {

                    //    key_ = Console.ReadKey(Console.KeyAvailable).Key;
                    if(Console.KeyAvailable == true)
                    {
                       player.Movem(Console.ReadKey(Console.KeyAvailable).Key, ref mon);
                    }
                    
                }
            }

            void MoveSnake()
            {
            
                while (true)
                {
                    switch (mon)
                    {
                        case 1: player.xCoordinate--; break;
                        case 2: player.xCoordinate++; break;
                        case 3: player.yCoordinate--; break;
                        case 4: player.yCoordinate++; break;
                    }
                    Thread.Sleep(400);
                }
            }

            while (true)
            {
                pole.Kadr();     
                pole.Fill("X");
                pole.Size[player.xCoordinate, player.yCoordinate] = player.Skin + " ";
                Thread.Sleep(50);
                
            }
  
        }
    }
}
