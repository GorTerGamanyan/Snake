using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figur
    {
        public Snake(Point tail,int length,Direction direct)
        {
            this.direct = direct;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direct);
                pList.Add(p);
            }
        }
        Direction direct;   

        public void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
            
        }

        internal bool IsHitTall()
        {
            Point head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                {
                    return true;
                }
            }
                return false;
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direct);
            return nextPoint;
        }

        public void HandalKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direct = Direction.Left;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direct = Direction.Right;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direct = Direction.Up;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direct = Direction.Down;
            }
        }
        public bool IsEat(Point food)
        {
            Point head = GetNextPoint();
            Point secondHead = pList[pList.Count - 2];
            if (head.IsHit(food))
            {
                food.symbol = head.symbol;
                pList.Add(food);
                return true;
            }
            else if (secondHead.IsHit(food))
            {
                food = GetNextPoint();
                food.symbol = secondHead.symbol;
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
