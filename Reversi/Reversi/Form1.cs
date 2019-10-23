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
   

    public partial class Form1 : Form

    {
        private Panel tiles;
        private Field field;
        private SquareControl[,] squareControls;
        private Panel fieldPanel;

        public Form1()
        {
            
            InitializeComponent();
            squareControls = new SquareControl[8, 8];
            fieldPanel = new Panel();
            int i, j;
            for (i = 0; i < 8; i++)
                for (j = 0; j < 8; j++)
                {
                    // Create it.
                    this.squareControls[i, j] = new SquareControl(i, j);
                    // Position it.
                    this.squareControls[i, j].Left = j * this.squareControls[i, j].Width;
                    this.squareControls[i, j].Top = i * this.squareControls[i, j].Height;
                    // Add it.
                    this.fieldPanel.Controls.Add(this.squareControls[i, j]);
                   
                }
        }
        private void InitializeComponent()
        {

        }

            private void Form1_Load(object sender, EventArgs e)
        {
           
        }

       
    }
}
