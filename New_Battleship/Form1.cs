using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class Form1 : Form
       {
           PictureBox[,] p;
           PictureBox[,] c;
           private int colls=10;
           private int rows=10;
           Player player;
           Player comp;
           int flag=0;

        private void InitialPictureBox()
        {
            p = new PictureBox[rows, colls];
            c = new PictureBox[rows, colls];
             for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <colls; j++)
                {
                    //Initial player's ships mat
                    p[i, j] = new PictureBox();
                    c[i, j] = new PictureBox();

                    c[i, j].Width=c[i, j].Height = p[i, j].Width = p[i, j].Height = (this.ClientRectangle.Width / 3 ) / rows;
                    p[i, j].Tag = c[i, j].Tag = "" + i +','+ j;
                    p[i, j].Top = p[i, j].Height * j + 150;
                    p[i, j].Left = p[i, j].Width * i + 60;

                    p[i, j].Visible = true;
                    p[i, j].BorderStyle = BorderStyle.Fixed3D;
                    p[i, j].BackColor = Color.Green;


                    c[i, j].Top = p[i, j].Height * j + 150;
                    c[i, j].Left = p[i, j].Width * i + 220+p[i,j].Width*rows;
                    c[i, j].Visible = false;
                    c[i, j].BorderStyle = BorderStyle.Fixed3D;
                    c[i, j].BackColor = Color.Green;
                    p[i, j].MouseClick += player_mouseclick;
                    p[i, j].Cursor = Cursors.Cross;
                    c[i, j].Cursor = Cursors.Cross;
                    c[i, j].MouseClick += auto_mouseclick;
                    
                    this.Controls.Add(p[i, j]);
                    this.Controls.Add(c[i, j]);
                    

                }
            }
        }

        private void auto_mouseclick(object sender, MouseEventArgs e)
        {  
             string[] separators = { ",", ".", "!", "?", ";", ":", " " };
                PictureBox pb = (PictureBox)sender;
            int x = int.Parse(((string)pb.Tag).Split(separators, StringSplitOptions.RemoveEmptyEntries)[0]);
            int y = int.Parse(((string)pb.Tag).Split(separators, StringSplitOptions.RemoveEmptyEntries)[1]);
            click_mod_Change(false,c);
           
              play_game(new Point(x,y),comp);
        }

        private void click_mod_Change(bool p,PictureBox[,] a)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {    if(p)
                    a[i, j].MouseClick += auto_mouseclick;
                else a[i, j].MouseClick -= auto_mouseclick;

                }
            }
        }

        private void play_game(Point point, Player pla)
        {
            color_ship_game(pla);
            if (pla.New_point.Contains(point))
            {
                Boolean hit_flag = false;
                
                for (int i = 0; i < pla.Ships.Count; i++)
                {
                    if (pla.Ships[i].hit_is_sink(point))
                    {
                       pla.Old_ships.Add(pla.Ships[i]);

                            for (int k = 0; k < pla.Ships[i].Size; k++)
                            {
                                if (pla.New_point.Contains(pla.Ships[i].Point[k]))
                                    pla.New_point.Remove(pla.Ships[i].Point[k]);
                                pla.Ships[i].Hit_point[k] = true;
                            }
                        
                    }
                    
                    for (int j = 0; j < pla.Ships[i].Size; j++)
                    {
                        if (pla.Ships[i].Point[j].Equals(point))
                            hit_flag = true;
                  
                    }


                }
                Console.WriteLine(pla.Old_ships.Count);
                if (pla.Old_ships.Count>= 4)
                {
                    string name = pla.Name == comp.Name ? player.Name : comp.Name;
                    click_mod_Change(false, c);
                    label1.Text = name + "         is winner";
                    System.Threading.Thread.Sleep(10000);
                    new_game();
                }
               
                if (!hit_flag)
                {
                    pla.New_point.Remove(point);
                    if (pla.Name == comp.Name)
                    {
                        Random a = new Random();
                        label1.Text = "התור של המחשב";
                        color_ship_game(pla);
                        play_game(player.New_point[a.Next(0, player.New_point.Count)], player);
                    }
                    else
                    {
                        label1.Text = "תורך עכשיו "+ "           החמצה";
                        click_mod_Change(true, c);
                        refresh_picture(c);

                    }
                }

                else
                {
                    
                    if (pla.Name == comp.Name)
                    {
                        label1.Text = "תורך עכשיו ";
                        click_mod_Change(true, c);
                    }
                    else
                    {
                        Random a = new Random();
                        label1.Text = "התור של המחשב";
                      
                        color_ship_game(pla);
                        play_game(player.New_point[a.Next(0, player.New_point.Count)], player);

                    }

                }
            }
            else
            {
                label1.Text = "בחר משבצת אחרת";
                click_mod_Change(true, c);
            }
            color_ship_game(pla);
        }

        private void color_ship_game(Player a)
        {

            PictureBox[,] j ;
            if (player.Name == a.Name)
                j = p;
            else
                j = c;
            
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10; k++)
                {   
                    if (a.New_point.Contains(new Point(i, k)))
                        j[i, k].BackColor = Color.Green;
                   
                    else j[i, k].BackColor = Color.Snow;
                }
            }
           for (int i = 0; i < a.Ships.Count; i++)
            {
  
                    for (int k = 0; k < a.Ships[i].Size; k++)
                    {
                        if (a.Ships[i].Hit_point[k])
                        j[a.Ships[i].Point[k].X, a.Ships[i].Point[k].Y].BackColor = Color.Red;
                    }
            }
           refresh_picture(j);
                    
        }

        private void refresh_picture(PictureBox[,] picture)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    picture[i,j].Refresh();
                }
            }
        }

        private void player_mouseclick(object sender, MouseEventArgs e)
        {
            if (flag == 1)
            {
                string[] separators = { ",", ".", "!", "?", ";", ":", " " };
                PictureBox pb = (PictureBox)sender;
                int x = int.Parse(((string)pb.Tag).Split(separators, StringSplitOptions.RemoveEmptyEntries)[0]);
                int y = int.Parse(((string)pb.Tag).Split(separators, StringSplitOptions.RemoveEmptyEntries)[1]);
                Boolean b=Horizontal.SelectedIndex ==1 ? true : false;
                Horizontal.Refresh();
                Point[] a;
               
                Ships ship=null;
                
                switch (SelectShip.Text)
                {

                    case "ship2":

                        a = ship2.get_point(x, y, b);
                        ship = new ship2(b, a);
                        Console.WriteLine(ship.Name);
                        break;
                    case "ship3":
                        a = ship3.get_point(x, y, b);
                        ship = new ship3(b, a);
                        break;
                    case "ship4":
                        a = ship4.get_point(x, y, b);
                        ship = new ship4(b, a);
                        
                        break;
                    case "ship6":
                        a = ship6.get_point(x, y, b);
                        ship = new ship6(b, a);
                        break;

                }
             
                if (player.set_ship(ship))
                {
                    player.Ships.Add(ship);
                  
                    SelectShip.Items.RemoveAt(SelectShip.SelectedIndex);
                    SelectShip.SelectedIndex=0;
                    SelectShip.Refresh();
                    if (SelectShip.Items.Count == 1)
                    {
                        StartButton.Visible = true;
                        SelectShip.Visible = false;
                        Horizontal.Visible = false;

                    }
                }
               

                pic_color_ship(player);
            }
            
        }
        private void pic_color_ship(Player a)
        {

            if (a.Name.Equals(player.Name))
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (!a.New_point.Contains(new Point(i, j)))
                        {
                            p[i, j].BackColor = Color.Transparent;
                        }
                    }
                }

                for (int i = 0; i < a.Ships.Count; i++)
                {
                    for (int j = 0; j < a.Ships[i].Size; j++)
                    {   
                        int x = a.Ships[i].Point[j].X;
                        int y = a.Ships[i].Point[j].Y;
                        p[x, y].BackColor = Color.Purple;

                    }
                }
                refresh_picture(p);
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (!a.New_point.Contains(new Point(i, j)))
                        {
                            Console.WriteLine(i + "    " + j);
                            c[i, j].BackColor = Color.Transparent;
                        }
                    }
                }

                for (int i = 0; i < a.Ships.Count; i++)
                {
                    for (int j = 0; j < a.Ships[i].Size; j++)
                    {
                        int x = a.Ships[i].Point[j].X;
                        int y = a.Ships[i].Point[j].Y;
                        c[x, y].BackColor = Color.Purple;

                    }
                }

            }
            refresh_picture(c);
           
        }
   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new_game();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            new_game();
        }
        private void new_game(){
            label1.Visible = false;
            this.Refresh();
            SelectShip.Items.Clear();
           
            if(p!=null)
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    p[i, j].Dispose();
                    
                }
            }
           
            Horizontal.Visible = false;
            SelectShip.Visible = false;
            AutoButton.Visible = true;
            Normalbutton.Visible = true;
            StartButton.Visible = false;
            player = new Player("player");
            comp = new Player("computer");

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            InitialPictureBox();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    p[i, j].MouseClick -= player_mouseclick;
                    p[i, j].Enabled=false;
                    refresh_picture(p);
                    c[i, j].Visible = true;

                }
            }
            label1.Visible = true;
            label1.Text = "תורך עכשיו";
            comp.set_new_point(rows, colls);
            comp.get_rendom_point();
            comp.set_new_point(rows,colls);
            player.set_new_point(rows, colls);
            click_mod_Change(false, p);
            click_mod_Change(true, c);
        }

        private void Normalbutton_Click(object sender, EventArgs e)
        {
            Normalbutton.Visible = false;
            AutoButton.Visible = false;
            InitialPictureBox();
            Horizontal.Items.Clear();
            SelectShip.Items.Clear();
            Horizontal.Visible = true;
            SelectShip.Visible = true;
            Horizontal.DisplayMember = "Text";
            SelectShip.DisplayMember = "Text";
            SelectShip.ValueMember = "Value";
            Horizontal.ValueMember = "Value";
            var items = new[] {  new{ Text = "בחר סירה", Value = "0"} ,
    new { Text = "ship2", Value = "1" }, 
    new { Text = "ship3", Value = "2" }, 
    new { Text = "ship4", Value = "3" }, 
    new { Text = "ship6", Value = "4" }, 
  
       };
            for (int i = 0; i < items.Length; i++)
			{
			  SelectShip.Items.Add(items[i]);
			}
            SelectShip.SelectedIndex = 0;
             items = new[] { new { Text = "אופקי", Value = "1" }, 
    new { Text = "אנכי", Value = "2" }, 
  
       };
            for (int i = 0; i < items.Length; i++)
            {
                Horizontal.Items.Add(items[i]);
            }
            Horizontal.SelectedIndex = 1;
           
            
        }

        private void SelectShip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectShip.SelectedIndex != 0 && Horizontal.SelectedItem != null)
                flag = 1;
            else
                flag = 0;
        }

        private void Horizontal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectShip.SelectedIndex != 0 && Horizontal.SelectedItem != null)
                flag = 1;
            else
                flag = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }

}

