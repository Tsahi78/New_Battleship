using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Battleship
{
    class ship2:Ships
    {
        private string name = "battel2";
        private int size = 2;

        public ship2(String name = "battel2", int size = 2, Boolean horizontal, Point[] point) : base(name, size,  horizontal,  point) { }
    }
}
