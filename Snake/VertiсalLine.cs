using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VertiсalLine
    {
        public VertiсalLine(int x,int yUp, int yDown, char symbol)
        {
            vertLine = new List<Point>();
            for (int y =yUp; y < yDown; y++)
            {
                Point p = new Point(x, y, symbol);
                vertLine.Add(p);
            }
        }

        List<Point> vertLine;

        public void Draw()
        {
            foreach (var item in vertLine)
            {
                item.Draw();
            }
        }
    }
}
