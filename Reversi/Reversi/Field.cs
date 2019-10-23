using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//class setting the field up
namespace Reversi
{
    public class Field
    {
        private int [,] tiles; // an array of all field tiles
        public static readonly int White = -1;
        public static readonly int Empty = 0;
        public static readonly int Black = 1;

        public Field() //creates empty field all tiles are empty
        {
            tiles = new int [8, 8];

            int i, j;
            for (i = 0; i < 8; i++)
                for (j = 0; j < 8; j++)
                {
                    tiles[i, j] = Empty;
                }

        }

        public void Start() // start game
        {
            // Clear the board.
            int i, j;
            for (i = 0; i < 8; i++)
                for (j = 0; j < 8; j++)
                {
                    tiles[i, j] = Empty;
                    
                }

            // Set the four beginning pieces
            tiles[3, 3] = Black;
            tiles[4, 3] = Black;
            tiles[3, 4] = White;
            tiles[4, 4] = White;
            
        }
        
        public int GetTiles(int row, int col) //returns the value of a tile
        {
            return tiles[row, col];
        }
    }
}
