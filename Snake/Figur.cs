using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figur
    {
        protected List<Point> lineList;

        public void Draw()
        {
            foreach (var item in lineList)
            {
                item.Draw();
            }
        }
    }
}
