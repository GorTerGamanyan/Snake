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
            //Console.SetWindowSize(120, 30);

            Wall wall = new Wall(width,height);
            
            
            Snake snak = new Snake(new Point(10, 8, '*'), 4, Direction.Right);
            snak.Draw();
            FoodCreate fc = new FoodCreate(120, 30, '+');
            Point food = fc.CreateFood();
            food.Draw();
            while (true)
            {
                if (snak.IsEat(food))
                {
                    food = fc.CreateFood();
                    food.Draw();
                }
                else
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        snak.HandalKey(key.Key);
                    }
                    Thread.Sleep(100);
                    snak.Move();
                }



            }




        }
    }
}
