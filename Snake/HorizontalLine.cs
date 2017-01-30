using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figur
    {
        public HorizontalLine(int xRight, int xLeft,int y, char symbol)
        {
            lineList = new List<Point>();
            for (int x = xRight; x <= xLeft; x++)
            {
                Point p = new Point(x, y, symbol);
                lineList.Add(p);
            }
        }
    }
}
