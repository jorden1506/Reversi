using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reversi;

namespace Reversi
{
    public partial class ReversiForm : Form
    {
        public Button newGame, help;
        public Panel p;
        public Label blueScore, redScore, gameState;
        int xRedScore = 300;
        int yRedScore = 20;
        int xBlueScore = 880;
        int yBlueScore = 20;
        int yBoxMax = 5;
        int xBoxMax = 5;
        int xPanel = 300;
        int yPanel = 100;
        int xPanelSize = 800;
        int yPanelSize = 400;
        public Rectangle r = new Rectangle();

        //Adding the playing field
        private Field field;

        public Reversi()
        {
            //Creating the buttons
            newGame = new Button();
            help = new Button();
            newGame.Location = new Point(350, 550);
            help.Location = new Point(900, 550);
            newGame.Size = new Size(100, 75);
            help.Size = new Size(100, 75);
            newGame.Text = "New Game";
            help.Text = "Help";

            //Creating the panel in which the game will be played
            p = new Panel();
            p.Location = new Point(xPanel, yPanel);
            p.ClientSize = new Size(xPanelSize, yPanelSize);

            //Creating the labels
            blueScore = new Label();
            redScore = new Label();
            gameState = new Label();
            blueScore.Location = new Point(xBlueScore, yBlueScore);
            redScore.Location = new Point(xRedScore, yRedScore);
            gameState.Location = new Point(580, 20);
            blueScore.Size = new Size(100, 13);
            redScore.Size = new Size(100, 13);
            gameState.Size = new Size(100, 13);
            blueScore.Text = "Blue Score: 0";
            redScore.Text = "Red Score: 0";
            gameState.Text = "State of the game here";

            //Adding all elements to the program
            Controls.Add(newGame);
            Controls.Add(help);
            Controls.Add(p);
            Controls.Add(blueScore);
            Controls.Add(redScore);
            Controls.Add(gameState);

            //Adding the draw function
            p.Paint += pDraw;
            p.MouseClick += pClick;
        }



        public void pDraw(object obj, PaintEventArgs pea)
        {
            int i;
            int j;
            for (i = 0; i < xBoxMax; i++)
            {
                for (j = 0; j < yBoxMax; j++)
                {
                    if (this.Field[i, j] == Color1)
                    {
                        //Draw the ellipse (and rectangle?)
                    }

                    if (this.Field[i, j] == Color2)
                    {
                        //Draw the ellipse (and rectangle?)
                    }
                }
            }

        }

        public void pClick(object obj, MouseEventArgs mea)
        {
            int mouseX = mea.X;
            int mouseY = mea.Y;
            Point mousePos = new Point(mouseX, mouseY);
            int i;
            int j;
            for (i = 0; i < this.Field.Length; i++)
            {
                for (j = 0; j < this.Field.Length; j++)
                {
                    if (this.Field[i, j].Contains(mousePos))
                    {
                        //this.Field[i, j] == Color1; //(also Color2)?
                    }
                }
            }

            static void Main()
            {
                ReversiForm reversiScreen = new ReversiForm();
                reversiScreen.Text = "Reversi";
                reversiScreen.ClientSize = new Size(1400, 700);
                Application.Run(reversiScreen);
            }

        }
    }


//int t;
//for(t = 0; t <= yBoxMax; t++)
//{
//    pea.Graphics.DrawLine(Pens.Black, 0, t * yPanelSize / yBoxMax, xPanelSize, t * yPanelSize / yBoxMax); 
//}

//for (t = 0; t <= xBoxMax; t++)
//{
//    pea.Graphics.DrawLine(Pens.Black, t * xPanelSize / xBoxMax, 0, t * xPanelSize / xBoxMax, yPanelSize);
//}