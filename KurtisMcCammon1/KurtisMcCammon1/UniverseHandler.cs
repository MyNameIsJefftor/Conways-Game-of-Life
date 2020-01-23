using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KurtisMcCammon1
{
    public class UniverseHandler
    {
        public bool[,] CellVerse { get; private set; }
        public int generations { get; private set; }
        bool[,] scratchPad { get; set; }
        public int[,] neighbourCount { get; private set; }

        public int liveCells { get; private set; }

        public UniverseHandler()
        {
            CellVerse = new bool[10, 10];
            neighbourCount = new int[10, 10];
            generations = 0;
        }

        public UniverseHandler(int universeHeight, int universeWidth)
        {
            CellVerse = new bool[universeHeight, universeWidth];
            neighbourCount = new int[universeHeight, universeWidth];
            generations = 0;
        }

        public void CellCount()
        {
            liveCells = 0;
            for (int y = 0; y < CellVerse.GetLength(1); y++)
            {
                for (int x = 0; x < CellVerse.GetLength(0); x++)
                {
                    NeighborCheck(x, y, false);
                }
            }
        }
        public void NextGeneration()
        {
            liveCells = 0;
            bool[,] temp = CellVerse;
            scratchPad = new bool[CellVerse.GetLength(0), CellVerse.GetLength(1)];
            scratchPad = temp;
            for (int y = 0; y < CellVerse.GetLength(1); y++)
            {
                for (int x = 0; x < CellVerse.GetLength(0); x++)
                {
                    VibeCheck(x, y);
                }
            }
            CellVerse = scratchPad;
            CellCount();
            generations++;
        }
        //checks the rules and determines if the cell is alive or dead.
        private void VibeCheck(int x, int y)
        {
            if (scratchPad[x, y])
            {
                if (neighbourCount[x, y] < 2 || neighbourCount[x, y] > 3)
                {
                    scratchPad[x, y] = false;
                }
                else
                {
                    scratchPad[x, y] = true;
                }
            }
            else
            {
                if (neighbourCount[x, y] == 3)
                {
                    scratchPad[x, y] = true;
                }
            }
        }
        //counts the neighbors that are alive.
        private void NeighborCheck(int x, int y, bool Torod)
        {
            int posx = x; int posy = y;
            if (!Torod)
            {
                if (CellVerse[posx, posy])
                {
                    liveCells++;
                }
                neighbourCount[posx, posy] = 0;
                //top
                //upleft
                if (x - 1 >= 0 && y - 1 >= 0 && CellVerse[x - 1, y - 1])
                {
                    neighbourCount[posx, posy]++;
                }
                //up
                if (y - 1 >= 0 && CellVerse[x, y - 1])
                {
                    neighbourCount[posx, posy]++;
                }
                //upright
                if (x + 1 < CellVerse.GetLength(0) && y - 1 >= 0 && CellVerse[x + 1, y - 1])
                {
                    neighbourCount[posx, posy]++;
                }

                //middle
                //left
                if (x - 1 >= 0 && CellVerse[x - 1, y])
                {
                    neighbourCount[posx, posy]++;
                }
                //right
                if (x + 1 < CellVerse.GetLength(0) && CellVerse[x + 1, y])
                {
                    neighbourCount[posx, posy]++;
                }

                //bottom
                //downleft
                if (x - 1 >= 0 && y + 1 < CellVerse.GetLength(1) && CellVerse[x - 1, y + 1])
                {
                    neighbourCount[posx, posy]++;
                }
                //down
                if (y + 1 < CellVerse.GetLength(1) && CellVerse[x, y + 1])
                {
                    neighbourCount[posx, posy]++;
                }
                //downright
                if (x + 1 < CellVerse.GetLength(0) && y + 1 < CellVerse.GetLength(1) && CellVerse[x + 1, y + 1])
                {
                    neighbourCount[posx, posy]++;
                }
            }
            else
            {
                if (CellVerse[posx, posy])
                {
                    liveCells++;
                }
                neighbourCount[posx, posy] = 0;
                //top
                //upleft
                if (x - 1 >= 0 && y - 1 >= 0 && CellVerse[x - 1, y - 1])
                {
                    neighbourCount[posx, posy]++;
                }
                //up
                if (y - 1 >= 0 && CellVerse[x, y - 1])
                {
                    neighbourCount[posx, posy]++;
                }
                //upright
                if (x + 1 < CellVerse.GetLength(0) && y - 1 >= 0 && CellVerse[x + 1, y - 1])
                {
                    neighbourCount[posx, posy]++;
                }

                //middle
                //left
                if (x - 1 >= 0 && CellVerse[x - 1, y])
                {
                    neighbourCount[posx, posy]++;
                }
                //right
                if (x + 1 < CellVerse.GetLength(0) && CellVerse[x + 1, y])
                {
                    neighbourCount[posx, posy]++;
                }

                //bottom
                //downleft
                if (x - 1 >= 0 && y + 1 < CellVerse.GetLength(1) && CellVerse[x - 1, y + 1])
                {
                    neighbourCount[posx, posy]++;
                }
                //down
                if (y + 1 < CellVerse.GetLength(1) && CellVerse[x, y + 1])
                {
                    neighbourCount[posx, posy]++;
                }
                //downright
                if (x + 1 < CellVerse.GetLength(0) && y + 1 < CellVerse.GetLength(1) && CellVerse[x + 1, y + 1])
                {
                    neighbourCount[posx, posy]++;
                }
            }
        }

        public void GenerateWorldSeed(int seed)
        {
            Random Temp = new Random(seed);
            for (int y = 0; y < CellVerse.GetLength(1); y++)
            {
                for (int x = 0; x < CellVerse.GetLength(0); x++)
                {
                    if ((seed * Temp.Next()) % 5 == 0)
                    {
                        CellVerse[x, y] = true;
                    }
                    else
                    {
                        CellVerse[x, y] = false;
                    }
                }
            }
            CellCount();
        }
    }
}
