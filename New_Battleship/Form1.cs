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


        private void InitialPictureBox()
        {
            p = new PictureBox[10, 10];
            c = new PictureBox[10, 10];
             for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <colls; j++)
                {
                    //Initial player's ships mat
                    p[i, j] = new PictureBox();
                    c[i, j] = new PictureBox();

                    c[i, j].Width=c[i, j].Height = p[i, j].Width = p[i, j].Height = (this.ClientRectangle.Width / 3 ) / rows;

                    p[i, j].Top = p[i, j].Height * j + 150;
                    p[i, j].Left = p[i, j].Width * i + 60;

                    p[i, j].Visible = true;
                    p[i, j].BorderStyle = BorderStyle.Fixed3D;
                    p[i, j].BackColor = Color.Transparent;

                    c[i, j].Top = p[i, j].Height * j + 150;
                    c[i, j].Left = p[i, j].Width * i + 220+p[i,j].Width*rows;
                    c[i, j].Visible = false;
                    c[i, j].BorderStyle = BorderStyle.Fixed3D;
                    c[i, j].BackColor = Color.Transparent;
                 //   c[i, j].MouseClick += player_mouseclick;
                    c[i, j].Cursor = Cursors.Cross;
                    
                
                    this.Controls.Add(p[i, j]);
                    this.Controls.Add(c[i, j]);
                    

                }
            }
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
            Horizontal.Visible = false;
            SelectShip.Visible = false;
            AutoButton.Visible = true;
            Normalbutton.Visible = true;
            StartButton.Visible = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            InitialPictureBox();
        }

        private void Normalbutton_Click(object sender, EventArgs e)
        {
            InitialPictureBox();
            Horizontal.Visible = true;
            SelectShip.Visible = true;

            SelectShip.DisplayMember = "Text";
            SelectShip.ValueMember = "Value";

            var items = new[] { 
    new { Text = "ship2", Value = "1" }, 
    new { Text = "ship3", Value = "2" }, 
  
       };

            SelectShip.DataSource = items;
        }
    }
}
