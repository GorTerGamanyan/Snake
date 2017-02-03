using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figur
    {
        protected List<Point> pList;

        public virtual void Draw()
        {
            foreach (var item in pList)
            {
                item.Draw();
            }
        }
    }
}
