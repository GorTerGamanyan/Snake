using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall : Figur
    {
        public override void Draw()
        {
            HorizontalLine hl1 = new HorizontalLine(0, 119, 1, '*');
            hl1.Draw();
            VertiсalLine vl1 = new VertiсalLine(119, 0, 29, '*');
            vl1.Draw();
            HorizontalLine hl2 = new HorizontalLine(0, 119, 29, '*');
            hl2.Draw();
            VertiсalLine vl2 = new VertiсalLine(0, 0, 29, '*');
            vl2.Draw();
        }
    }
}
