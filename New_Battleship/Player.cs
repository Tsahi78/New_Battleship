using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Battleship
{
    class Player 
    {
        private string name;


        Ships[] ships;


        List<Point> new_point;
        List<Point> old_point;



        public Player(string name)
        {
            this.name = name;
            set_new_point(10,10);
        }

        public string Name
            {
              get { return name; }
              set { name = value; }
            }

        public Ships[] Ship
            {
              get { return ships; }
              set { ships = value; }
            }
        public List<Point> New_point
            {
              get { return new_point; }
              set { new_point = value; }
            }
        public List<Point> Old_point
            {
              get { return old_point; }
              set { old_point = value; }
            }

        //אתחול של רשימה של נקודות 

        public void set_new_point(int x, int y)
        {
            for (int i = 0; i < y; i++)
            {

                for (int j = 0; j < x; j++)
                {
                    new_point.Add(new Point(j, i));
                }
            }
        }
        public Boolean set_ship(string ship_name,Point)
    }
    
}
