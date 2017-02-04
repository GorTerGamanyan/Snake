using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreate
    {
        public FoodCreate(int widthMap,int heightMap,char symbol)
        {
            this.widthMap = widthMap;
            this.heightMap = heightMap;
            this.symbol = symbol;
        }
        int widthMap;
        int heightMap;
        char symbol;
        Random rnd;

        public Point CreateFood()
        {
            int x = rnd.Next(2, widthMap - 2);
            int y = rnd.Next(2, heightMap - 2);
            return new Point(x, y, symbol);
        }
    }
}
