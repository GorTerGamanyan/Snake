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

            HorizontalLine hl1 = new HorizontalLine(0, 119, 1, '*');
            hl1.Draw();
            VertiсalLine vl1 = new VertiсalLine(119, 0, 29, '*');
            vl1.Draw();
            HorizontalLine hl2 = new HorizontalLine(0, 119, 29, '*');
            hl2.Draw();
            VertiсalLine vl2 = new VertiсalLine(0, 0, 29, '*');
            vl2.Draw();

            Point p1 = new Point(5, 4, '+');
            p1.Draw();
            Snake snak = new Snake(new Point(10, 8, '*'), 4, Direction.Right);
            snak.Draw();
            snak.Move();
            Thread.Sleep(300);
            snak.Move();
            Thread.Sleep(300);
            snak.Move();
            Thread.Sleep(300);
            snak.Move();
            Thread.Sleep(300);
            snak.Move();
            Thread.Sleep(300);
            snak.Move();
            Thread.Sleep(300);
            snak.Move();
            Thread.Sleep(300);
            snak.Move();

            Console.ReadKey();


        }
    }
}
