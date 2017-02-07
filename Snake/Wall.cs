using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall : Figur
    {
        List<Figur> fList;

        public Wall(int widthMap,int heightMap)
        {
            fList = new List<Figur>();

            HorizontalLine hl1 = new HorizontalLine(0, widthMap-2, 0, '*');
            VertiсalLine vl1 = new VertiсalLine(widthMap - 2, 0, heightMap - 2, '*');
            HorizontalLine hl2 = new HorizontalLine(0, widthMap - 2, heightMap - 2, '*');
            VertiсalLine vl2 = new VertiсalLine(0, 0, heightMap - 2, '*');

            fList.Add(hl1);
            fList.Add(vl1);
            fList.Add(hl2);
            fList.Add(vl2);

            foreach (var item in fList)
            {
                item.Draw();
            }
        }


        
    }
}
