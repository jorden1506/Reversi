using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversi
{
    class ReversiActionClass
    {

        public void ReversiAction(int k, int j)
        {
            int[,] tabel;
            tabel = new int[10, 10];
            int[,] coloring;
            coloring = new int[10, 10];
            tabel[0, 0] = 1;
            tabel[1, 0] = 1;
            tabel[2, 0] = -1;
            tabel[3, 0] = 1;
            tabel[0, 1] = 1;
            tabel[1, 1] = 1;
            tabel[2, 1] = -1;
            tabel[3, 1] = -1;
            tabel[0, 2] = 1;
            tabel[1, 2] = -1;
            tabel[2, 2] = 1;
            tabel[3, 2] = 1;
            tabel[0, 3] = -1;
            tabel[1, 3] = -1;
            tabel[2, 3] = -1;
            tabel[3, 3] = 1;

            for (int t = k - 1; t <= k + 1; t++)
            {
                for (int i = j - 1; i <= j + 1; i++)

                    if (tabel[t, i] != tabel[k, i])
                    {
                        ReversiAction2(t, i, k, j, tabel);
                    }
            }
        }

        public void ReversiAction2(int tgood, int igood, int k, int j, int[,] tabel)
        {
            int xdif = tgood - k;
            int ydif = igood - j;
            int tnew = tgood;
            int inew = igood;
            while (tnew >= 0 && tnew <= 3 && inew >= 0 && inew <= 3)
            {
                if (tabel[tnew, inew] == tabel[k, j])
                {
                    if (k < tgood && j < igood)
                    {
                        while (k < tgood && j < igood)
                        {
                            tabel[tgood, igood] = tabel[k, j];
                            tgood--;
                            igood--;
                        }
                    }

                    if (k > tgood && j < igood)
                    {
                        while (k > tgood && j < igood)
                        {
                            tabel[tgood, igood] = tabel[k, j];
                            tgood++;
                            igood--;
                        }
                    }

                    if (k < tgood && j > igood)
                    {
                        while (k < tgood && j > igood)
                        {
                            tabel[tgood, igood] = tabel[k, j];
                            tgood--;
                            igood++;
                        }
                    }

                    if (k > tgood && j > igood)
                    {
                        while (k > tgood && j > igood)
                        {
                            tabel[tgood, igood] = tabel[k, j];
                            tgood++;
                            igood++;
                        }
                    }

                    break;

                }
                else
                {
                    tnew++;
                    inew++;
                }
            }
        }
    }
}
