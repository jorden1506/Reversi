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
        //private Panel tiles;
        //private Field field;
        private FieldTiles[,] fieldTiles;
        private Panel fieldPanel;
        private Panel tilesPanel;   

        public Reversi()
        {

            InitializeComponent();
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

        private void InitializeComponent()
        {
            tilesPanel = new Panel();


            this.tilesPanel.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));

            tilesPanel.Location = new Point(16, 16);
            tilesPanel.Name = "fieldPanel";
            tilesPanel.Size = new Size(256, 256);
            this.fieldPanel.Paint += new PaintEventHandler(this.FieldPanel_Paint);

            this.fieldPanel.Controls.Add(this.tilesPanel);
        }
        private void FieldPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reversi_Load(object sender, EventArgs e)
        {
           
        }

       
    }
}
