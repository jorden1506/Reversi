using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversi
{
    public class Field
    {
        private int [,] field;
        public static readonly int Black = -1;
        public static readonly int Empty = 0;
        public static readonly int White = 1;

        public Field()
        {
           
            this.field = new int [8, 8];

        }

        public void Start()
        {
            // Clear the board.
            int i, j;
            for (i = 0; i < 8; i++)
                for (j = 0; j < 8; j++)
                {
                    this.field[i, j] = Field.Empty;
                    
                }

            // Set the pieces at the start.
            //this.field[3, 3] = Black;
            //this.field[4, 3] = Black;
            //this.field[3, 4] = White;
            //this.field[4, 4] = White;
            
        }
        
    }
}
