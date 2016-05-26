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
       

        public ship2( Boolean horizontal, Point[] point) : base("ship2",2, horizontal,  point) {
            
        }
    }
}
