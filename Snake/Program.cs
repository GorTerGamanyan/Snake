using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 120;
            int height = 30;
            Console.SetBufferSize(width, height);

            Wall wall = new Wall(width,height);
            
            
            Snake snake = new Snake(new Point(10, 8, '*'), 4, Direction.Right);
            snake.Draw();
            FoodCreate fc = new FoodCreate(120, 30, '+');
            Point food = fc.CreateFood();
            food.Draw();
            while (true)
            {
                if (wall.IsHit(snake) || snake.IsHitTall())
                {
                    break;
                }
                if (snake.IsEat(food))
                {
                    food = fc.CreateFood();
                    food.Draw();
                }
                else
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        snake.HandalKey(key.Key);
                    }
                    Thread.Sleep(100);
                    snake.Move();
                }
            }




        }
    }
}
