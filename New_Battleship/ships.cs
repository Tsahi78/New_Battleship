using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Battleship
{
    
    class Ships
    {
       private string name;
       private int size;
       private Boolean sink;
       private Boolean horizontal = false;
       private Point[] point;

      


       public Ships(string name, int size, Boolean sink, Boolean horizontal, Point[] point)
        {
            this.name = name;
            this.size = size;
            this.sink = sink;
            this.horizontal = horizontal;
            this.point = point;
        }

        public Ships()
        {

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

       


        public override string ToString()
        {
            return String.Concat(name, size, sink, horizontal);
        }
    }
}