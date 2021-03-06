﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Battleship
{
    class ship2 : Ships
    {


        public ship2(Boolean horizontal, Point[] point)
            : base("ship2", 2, horizontal, point)
        {

        }
        public ship2()
            : base("ship2", 2)
        {

        }
        public static Point[] get_point(int x, int y, Boolean h)
        {
            Point[] a = new Point[2];
            for (int i = 0; i < 2; i++)
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
