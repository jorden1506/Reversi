using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reversi
{
   

    public partial class Reversi : Form

    {
        private Panel tiles;
        private Field field;
        private FieldTiles[,] fieldTiles;
        private Panel fieldPanel;
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

        public Reversi()
        {
            this.SuspendLayout();

            this.Name = "FieldTiles";
            this.Size = new Size(500, 500);
            //this.Load += new EventHandler(this.FieldTiles_Load);
            this.Paint += new PaintEventHandler(this.ReversiForm);
            this.ResumeLayout(false);


            fieldTiles = new FieldTiles[8, 8];
            fieldPanel = new Panel();
            int i, j;
            for (i = 0; i < 8; i++)
                for (j = 0; j < 8; j++)
                {
                    // Create it.
                    this.fieldTiles[i, j] = new FieldTiles(i, j);
                    // Position it.
                    this.fieldTiles[i, j].Left = j * this.fieldTiles[i, j].Width;
                    this.fieldTiles[i, j].Top = i * this.fieldTiles[i, j].Height;
                    // Add it.
                    this.fieldPanel.Controls.Add(this.fieldTiles[i, j]);
                   
                }
        }

        private void FieldTiles_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    fieldTiles[i, j].Size = new Size(32, 32);
                }
            }
            // Painting it the normal color
            Color backColor = FieldTiles.NormalBackColor;


            e.Graphics.Clear(backColor);


            //Draw the border of the field
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Point topLeft = new Point(fieldTiles[i,j].row * p.Width / 8 , fieldTiles[i, j].col * p.Height / 8);
                    Point topRight = new Point(fieldTiles[i, j].row * p.Width / 8 + this.Width, fieldTiles[i, j].col * p.Height / 8);
                    Point bottomLeft = new Point(fieldTiles[i, j].row * p.Width / 8, fieldTiles[i, j].col * p.Height / 8 + this.Height);
                    Point bottomRight = new Point(fieldTiles[i, j].row * p.Width / 8 + this.Width, fieldTiles[i, j].col * p.Height / 8 + this.Height);


    FieldTiles.pen.Width = 1;
            e.Graphics.DrawLine(FieldTiles.pen, bottomLeft, topLeft);
            e.Graphics.DrawLine(FieldTiles.pen, topLeft, topRight);

            e.Graphics.DrawLine(FieldTiles.pen, bottomLeft, bottomRight);
            e.Graphics.DrawLine(FieldTiles.pen, bottomRight, topRight);
                }
            }

        }

        public void ReversiForm(object sender, PaintEventArgs pea)
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
            p.Paint += new PaintEventHandler(FieldTiles_Paint); 

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
            blueScore.Text = "White Score: 0";
            redScore.Text = "Black Score: 0";
            gameState.Text = "State of the game here";
;

            //Adding all elements to the program
            Controls.Add(newGame);
            Controls.Add(help);
            Controls.Add(p);
            Controls.Add(blueScore);
            Controls.Add(redScore);
            Controls.Add(gameState);


        }


        private void Reversi_Load(object sender, EventArgs e)
        {
           
        }

       
    }


}
