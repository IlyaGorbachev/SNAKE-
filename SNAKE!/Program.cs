using System;
using System.Threading;

namespace SNAKE_
{
    class Program
    {
        static void Main()
        {
            //Меню
            Console.WriteLine("Press any key...");
            ConsoleKey key_ = ConsoleKey.UpArrow;
            
            //Создаем объекты
            Area pole = new Area();
            Snake player = new Snake();

            //Содаем поток SnakeMath(Расчет змеи)
            Thread snake = new Thread(SnakeMath);

            //Начальные координаты змеи
            player.xCoordinate = 2;
            player.yCoordinate = 2;
            
            //Цвет фона
            Console.BackgroundColor = ConsoleColor.Black;

            //Запускаем потоки
            
            snake.Start();

            //Поток расчета положения змеи
            void SnakeMath()
            {
                while (true)
                {

                    key_ = Console.ReadKey(Console.KeyAvailable).Key;
                    player.Movem(key_);
                    Thread.Sleep(400);

                }
            }

            //Основной поток
            while (true)
            {
                
                pole.Kadr();
                pole.Fill("X");
                pole.Size[player.xCoordinate, player.yCoordinate] = player.Skin + " ";
                Thread.Sleep(30);
                
            }
  
        }
    }
}
