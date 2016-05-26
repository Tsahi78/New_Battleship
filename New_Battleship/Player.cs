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


        List<Ships> ships;
        List<Point> new_point;
        List<Point> old_point;

        internal List<Ships> Ships
        {
            get { return ships; }
            set { ships = value; }
        }

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
        public Boolean set_ship(Ships ship)
        {
            bool flag = true;
            Point xy;
            for (int i = 0; i < ship.Size && flag; i++)  // בדיקה שכל המיקומים של הספינה נמצאים ברשימה
            {
                if (!new_point.Contains(ship.Point[i]))
                {
                    flag = false;

                }

            }
            if (!flag)
            {
                return false;
            }
            for (int i = 0; i < ship.Size; i++)  // מוציא את המיקומים של הספינה מתוך הרשימה//
            {
                new_point.Remove(ship.Point[i]);
            }
            for (int i = 0; i < ship.Size; i++)  // הוצאת הנקודות מסביב לספינה מרשימת הנקודות//
            {
                int x = ship.Point[i].X;
                int y = ship.Point[i].Y;
                if (new_point.Contains(xy=new Point(y-1,x-1)))
                {
                    new_point.Remove(xy);
                }
                if (new_point.Contains(xy = new Point(y-1 ,x)))
                {
                    new_point.Remove(xy);
                }
                if (new_point.Contains(xy = new Point(y - 1,x + 1 )))
                {
                    new_point.Remove(xy);
                }
                if (new_point.Contains(xy = new Point(y ,x - 1 )))
                {
                    new_point.Remove(xy);
                }
                if (new_point.Contains(xy = new Point(y+1, x - 1)))
                {
                    new_point.Remove(xy);
                }
                if (new_point.Contains(xy = new Point(y , x + 1)))
                {
                    new_point.Remove(xy);

                if (new_point.Contains(xy = new Point(y+1,x)))
                    {
                        new_point.Remove(xy);
                    }
                }

            }
            return true;
        }
    }
    
}
