using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Battleship
{
    class ship3:Ships
    {
       

        public ship3( Boolean horizontal, Point[] point) : base("ship3",3, horizontal,  point) {
           
        }
          public ship3()
            : base("ship3", 3)
        {

        }
        public static Point[] get_point(int x, int y, Boolean h)
        {
            Point[] a = new Point[3];
            for (int i = 0; i < 3; i++)
            {
                a[i] = new Point(x, y);
                if (h)
                    y++;
                else
                    x++;
            }
            return a;
        }
        public override Boolean hit_is_sink(Point a)
        {
            int sum = 0;
            int index = 0;
            for (int i = 0; i < this.Size; i++)
            {
                if (Point[i].Equals(a))
                {
                    index = i;
                    this.Hit_point[i] = true;
                    sum += 1;
                }

            }
            if (sum == this.Size){
                this.Sink=true;
            }
            else if (sum == 1 && index == 1)
            {
                this.hit_is_sink(this.Point[0]);
                this.hit_is_sink(this.Point[2]);
            }
            return this.Sink;
        }
    }
}
