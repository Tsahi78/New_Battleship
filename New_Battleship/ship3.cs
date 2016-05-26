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
        private string name = "battel3";
        private int size = 3;

        public ship3(String name = "battel3", int size = 3, Boolean horizontal, Point[] point) : base(name, size,  horizontal,  point) { }
    
    }
}
