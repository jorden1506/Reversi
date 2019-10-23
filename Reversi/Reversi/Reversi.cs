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

        public Reversi()
        {
            
            
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
        

            private void Reversi_Load(object sender, EventArgs e)
        {
           
        }

       
    }
}
