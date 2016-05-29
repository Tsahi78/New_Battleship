using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Battleship
{
    
    abstract class Ships
    {
       private string name;
       private int size;
       private Boolean sink;
       private Boolean horizontal;
       private Point[] point;
       private Boolean[] hit_point;

       public Boolean[] Hit_point
       {
           get { return hit_point; }
           set { hit_point = value; }
       }

    
       public Ships(string name, int size,  Boolean horizontal, Point[] point)
        {
            this.name = name;
            this.size = size;
            this.sink = false;
            this.horizontal = horizontal;
            this.point = point;
            hit_point = new Boolean[size];
            Array.Clear(hit_point, 0, hit_point.Length);
        }

       public Ships(string name, int size)
        {
            this.name = name;
            this.size = size;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public Boolean Sink
        {
            get { return sink; }
            set { sink = value; }
        }

        public Boolean Horizontal
        {
            get { return horizontal; }
            set { horizontal = value; }
        }
        public Point[] Point
        {
            get { return point; }
            set { point = value; }
        }

        public abstract Boolean hit_is_sink(Point a);


        public override string ToString()
        {
            return String.Concat(name, size, sink, horizontal);
        }
    }
}