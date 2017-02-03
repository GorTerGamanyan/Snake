using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VertiсalLine : Figur
    {
        public VertiсalLine(int x, int yUp, int yDown, char symbol)
        {
            pList = new List<Point>();
            for (int y = yUp; y < yDown; y++)
            {
                Point p = new Point(x, y, symbol);
                pList.Add(p);
            }
        }
    }
}
