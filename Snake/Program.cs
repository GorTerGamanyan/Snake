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
            Console.SetBufferSize(120, 30);

            Wall wall = new Wall();
            wall.Draw();

            Point p1 = new Point(5, 4, '+');
            p1.Draw();
            ////Snake snak = new Snake(new Point(10, 8, '*'), 4, Direction.Right);
            ////snak.Draw();
            ////snak.Move();
            //Thread.Sleep(300);
            //snak.Move();
            //Thread.Sleep(300);
            //snak.Move();
            //Thread.Sleep(300);
            //snak.Move();
            //Thread.Sleep(300);
            //snak.Move();
            //Thread.Sleep(300);
            //snak.Move();
            //Thread.Sleep(300);
            //snak.Move();
            //Thread.Sleep(300);
            //snak.Move
            Snake snak = new Snake(new Point(10, 8, '*'), 4, Direction.Right);
            snak.Draw();

            while (true)
            {
                
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snak.HandalKey(key.Key);
                }
                Thread.Sleep(100);
                snak.Move();

            }

            Console.ReadKey();


        }
    }
}
