using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        public HorizontalLine(int xRight, int xLeft,int y, char symbol)
        {
            horList = new List<Point>();
            for (int x = xRight; x <= xLeft; x++)
            {
                Point p = new Point(x, y, symbol);
                horList.Add(p);
            }
        }

        List<Point> horList;

        public void Draw()
        {
            foreach (var item in horList)
            {
                item.Draw();
            }
        }
    }
}
