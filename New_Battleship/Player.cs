using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using System.Collections;
namespace Battleship
{
    class Player 
    {
        private string name;


        List<Ships> ships= new List<Ships>();
        List<Point> new_point = new List<Point>();
        List<Ships> old_ships= new List<Ships>();

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
        public List<Ships> Old_ships
            {
              get { return old_ships; }
              set { old_ships = value; }
            }

        //אתחול של רשימה של נקודות 

        public void set_new_point(int x, int y)
        {
            new_point = new List<Point>();
            for (int i = 0; i < x; i++)
            {

                for (int j = 0; j < y; j++)
                {
                    Point a = new Point(i, j);
    
                    new_point.Add(a);
                   
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
              
                if (new_point.Contains(xy=new Point(x-1,y-1)))
                {
                    new_point.Remove(xy);
             
                }
                if (new_point.Contains(xy = new Point(x ,y-1)))
                {
                    new_point.Remove(xy);
                 
                }
                if (new_point.Contains(xy = new Point(x+1,y- 1 )))
                {
                    new_point.Remove(xy);
                   
                }
                if (new_point.Contains(xy = new Point(x-1 ,y )))
                {
                    new_point.Remove(xy);
                 
                }
                if (new_point.Contains(xy = new Point(x-1,y+1)))
                {
                    new_point.Remove(xy);
                 
                }
                if (new_point.Contains(xy = new Point(x + 1, y)))
                {
                    new_point.Remove(xy);
                 
                }
                if (new_point.Contains(xy = new Point(x+1,y+1)))
                    {
                        new_point.Remove(xy);
                  
                    }
                if (new_point.Contains(xy = new Point(x, y+1)))
                {
                    new_point.Remove(xy);
                   
                }
                

            }
            return true;
        }
        public void get_rendom_point()
        {
            Random a = new Random();
            Ships ship=null;
            do
            {
                Point rendom_point = new_point[a.Next(0, new_point.Count)];
                Boolean rendom_boolean = a.Next(0, 100) > 50 ? true : false;
                 Point[] points  = ship2.get_point(rendom_point.X, rendom_point.Y, rendom_boolean);
                ship= new ship2(rendom_boolean,points);
                
            } while (!this.set_ship(ship));
            this.ships.Add(ship);
             ship = null;
            do
            {
                Point rendom_point = new_point[a.Next(0, new_point.Count)];
                Boolean rendom_boolean = a.Next(0, 100) > 50 ? true : false;
                Point[] points = ship3.get_point(rendom_point.X, rendom_point.Y, rendom_boolean);
                ship = new ship3(rendom_boolean, points);

            } while (!this.set_ship(ship));
            this.ships.Add(ship);
            ship = null;
            do
            {
                Point rendom_point = new_point[a.Next(0, new_point.Count)];
                Boolean rendom_boolean = a.Next(0, 100) > 50 ? true : false;
                Point[] points = ship6.get_point(rendom_point.X, rendom_point.Y, rendom_boolean);
                ship = new ship6(rendom_boolean, points);

            } while (!this.set_ship(ship));
            this.ships.Add(ship);
            ship = null;
            do
            {
                Point rendom_point = new_point[a.Next(0, new_point.Count)];
                Boolean rendom_boolean = a.Next(0, 100) > 50 ? true : false;
                Point[] points = ship4.get_point(rendom_point.X, rendom_point.Y, rendom_boolean);
                ship = new ship4(rendom_boolean, points);

            } while (!this.set_ship(ship));
            this.ships.Add(ship);

        }
    }
    
}
