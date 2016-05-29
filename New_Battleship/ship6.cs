using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Battleship
{
    class ship6 : Ships
    {


        public ship6(Boolean horizontal, Point[] point)
            : base("ship6", 6, horizontal, point)
        {

        }
        public ship6()
            : base("ship6", 6)
        {

        }

        public static Point[] get_point(int x, int y, Boolean h)
        {
            Point[] a = new Point[6];
            for (int i = 0; i < 6; i++)
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
        {   List<int> index=new List<int>();
            int sum = 0;
            for (int i = 0; i < this.Size; i++)
            {
                if (Point[i].Equals(a))
                {
                    this.Hit_point[i] = true;
                    sum += 1;
                    index.Add(i);
                }

            }
            if (sum == 2)
            {
                this.Sink = true;
            }
            else if (sum == 1 && index.Contains(0) || index.Contains(5))
            {
                this.Sink = true;  
            }
            return this.Sink;
        }
    }
}
