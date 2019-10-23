using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Reversi
{

    public class FieldTiles : UserControl
    {
        private System.ComponentModel.Container components = null;

        // Default color values.
        
        public static readonly Color NormalBackColorDefault = Color.Green;

        // Colors used in rendering the control.
        public static Color NormalBackColor = NormalBackColorDefault;

        

        // Used for animation.
        public static readonly int AnimationStart = 6;
        public static readonly int AnimationStop = FieldTiles.AnimationStart;
        public int AnimationCounter = FieldTiles.AnimationStop;

        // These reflect the position of the square on the board.
        public int Row
        {
            get { return this.row; }
        }
        public int Col
        {
            get { return this.col; }
        }

        // These reflect the public row and column properties.
        private int row;
        private int col;

        // Drawing tools.
        private static Pen pen = new Pen(Color.Black);
        

        public FieldTiles(int row, int col)
        {
            
            InitializeComponent();


            this.row = row;
            this.col = col;


            // Set the background color.
            this.BackColor = FieldTiles.NormalBackColor;


        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        
        private void InitializeComponent()
        {
            
            
            Name = "FieldTiles";
            Size = new Size(32, 32);
            Paint += new PaintEventHandler(this.FieldTiles_Paint);
            

        }

       
        private void FieldTiles_Paint(object sender, PaintEventArgs e)
        {
            // Painting it the normal color
            Color backColor = FieldTiles.NormalBackColor;
           

            e.Graphics.Clear(backColor);


            // Draw the border of the field
            Point topLeft = new Point(0, 0);
            Point topRight = new Point(this.Width - 1, 0);
            Point bottomLeft = new Point(0, this.Height - 1);
            Point bottomRight = new Point(this.Width - 1, this.Height - 1);
            FieldTiles.pen.Width = 1;
            e.Graphics.DrawLine(FieldTiles.pen, bottomLeft, topLeft);
            e.Graphics.DrawLine(FieldTiles.pen, topLeft, topRight);
            
            e.Graphics.DrawLine(FieldTiles.pen, bottomLeft, bottomRight);
            e.Graphics.DrawLine(FieldTiles.pen, bottomRight, topRight);

            
        }

        /*private void FieldTiles_Load(object sender, EventArgs e)
        {

        }*/
    }
}
