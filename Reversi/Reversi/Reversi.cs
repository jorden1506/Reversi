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

        //field
        private Panel fieldPanel, tilesPanel;
         

        public Reversi()
        {

            InitializeComponent();
            field = new Field();
            fieldTiles = new FieldTiles[8, 8];
            tiles = new Panel();
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
                    this.tiles.Controls.Add(this.fieldTiles[i, j]);
                   
                }
        }

        private void InitializeComponent()
        {
            fieldPanel = new Panel();
            tilesPanel = new Panel();


            this.tilesPanel.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            tilesPanel.Location = new Point(16, 16);
            tilesPanel.Name = "fieldPanel";
            tilesPanel.Size = new Size(256, 256);
            tilesPanel.TabIndex = 1;
            this.fieldPanel.Paint += new PaintEventHandler(this.TilesPanel_Paint);

            this.fieldPanel.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.fieldPanel.BackColor = SystemColors.Control;
            //this.fieldPanel.Controls.Add(this.cornerLabel);
            this.fieldPanel.Controls.Add(this.tilesPanel);
            this.fieldPanel.Location = new Point(8, 32);
            this.fieldPanel.Name = "boardPanel";
            this.fieldPanel.Size = new Size(272, 272);
            this.fieldPanel.TabIndex = 2;

        }

        private void TilesPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FieldPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reversi_Load(object sender, EventArgs e)
        {
           
        }

       
    }
}
