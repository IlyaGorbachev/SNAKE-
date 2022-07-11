using SNAKE_.Class;
using System;
using System.Threading;

namespace SNAKE_
{
    class Program
    {
        static void Main(string[] args)
        {
            int mon = 1;
            int time = 400;
            //Меню
            Console.WriteLine("Press any key...");
            
            //Создаем объекты
            Area pole = new Area();
            Snake player = new Snake();
            Food food = new Food();

            //Содаем поток SnakeMath(Расчет змеи)
            Thread snake = new Thread(SnakeMath);
            Thread move = new Thread(MoveSnake);
            //Начальные координаты змеи
            player.xCoordinate = 6;
            player.yCoordinate = 6;
            
            //Цвет фона
            Console.BackgroundColor = ConsoleColor.Black;
            
            //Запускаем потоки
            move.Start();
            snake.Start();

            


            void SnakeMath()
            {
                
                while (true)
                {
                    
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
                    Thread.Sleep(time);

                    
                }
            }

            while (true)
            {
                if (player.xCoordinate == 0 || player.xCoordinate == Area.Width - 1 || player.yCoordinate == 0 || player.yCoordinate == Area.Height - 1)
                {
                    move.Join();
                    move.Interrupt();
                    snake.Join();
                    snake.Interrupt();
                    
                    break;

                }
                pole.Kadr();
                pole.Fill("X");
                Console.WriteLine("Score: " + player.score.ToString());
                pole.Size[food.xCoordinate, food.yCoordinate] = food.skin + " ";
                pole.Size[player.xCoordinate, player.yCoordinate] = player.Skin + " ";
                if (pole.Size[food.xCoordinate, food.yCoordinate] != food.skin + " ")
                {
                    food.Generation(Area.Width, Area.Height);
                    pole.Size[food.xCoordinate, food.yCoordinate] = food.skin + " ";
                    player.score++;
                    time = time - 4;
                }
                Thread.Sleep(20);
                
                
            }
            Console.Clear();
            Console.WriteLine("You die! " + player.score.ToString());
            Console.ReadLine();
  
        }
    }
}
