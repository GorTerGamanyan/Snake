using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall : Figur
    {
        List<Figur> wallList;

        public Wall(int widthMap,int heightMap)
        {
            wallList = new List<Figur>();

            HorizontalLine hl1 = new HorizontalLine(0, widthMap-2, 0, '*');
            VertiсalLine vl1 = new VertiсalLine(widthMap - 2, 0, heightMap - 2, '*');
            HorizontalLine hl2 = new HorizontalLine(0, widthMap - 2, heightMap - 2, '*');
            VertiсalLine vl2 = new VertiсalLine(0, 0, heightMap - 2, '*');

            wallList.Add(hl1);
            wallList.Add(vl1);
            wallList.Add(hl2);
            wallList.Add(vl2);

            foreach (var item in wallList)
            {
                item.Draw();
            }
        }

        public bool IsHit(Figur figur)
        {
            foreach (var wall in collection)
            {

            }   
        }
        
    }
}
