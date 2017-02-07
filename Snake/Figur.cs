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

        internal bool IsHit(Figur figur)
        {
            foreach (var p in pList)
            {
                if (figur.IsHit(p))
                {
                    return true;
                }
            }
            return false;

        }

        bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (point.IsHit(p))
                {
                    return true;
                }
            }
            return false;

        }
    }
}
