using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public Point()
        {

        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symbol = p.symbol;
        }

        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        public int x;
        public int y;
        public char symbol;

        public void Move(int offset,Direction direct)
        {
            if (direct == Direction.Right)
            {
                x += offset;
            }
            else if (direct == Direction.Left)
            {
                x -= offset;
            }
            else if (direct == Direction.Up)
            {
                y -= offset;
            }
            else if (direct == Direction.Down)
            {
                y += offset;
            }

        }

        internal void Clear()
        {
            symbol = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }


        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
