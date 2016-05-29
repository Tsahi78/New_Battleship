using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Battleship
{
    class ship4 : Ships
    {


        public ship4(Boolean horizontal, Point[] point)
            : base("ship4", 4, horizontal, point)
        {

        }
        public ship4()
            : base("ship4", 4)
        {

        }
        public static Point[] get_point(int x, int y, Boolean h)
        {
            Point[] a = new Point[4];
            for (int i = 0; i < 4; i++)
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
            for (int i = 0; i < this.Size; i++)
            {
                if (Point[i].Equals(a))
                {
                    this.Hit_point[i] = true;
                    sum += 1;
                }

            }
            if (sum == this.Size)
            {
                this.Sink = true;
 
            }
            return this.Sink;
        }
    }
}
