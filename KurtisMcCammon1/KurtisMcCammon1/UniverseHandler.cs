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
            if(universeHeight < 5)
            {
                universeHeight = 5;
            }
            if(universeWidth < 5)
            {
                universeWidth = 5;
            }
            CellVerse = new bool[universeHeight, universeWidth];
            neighbourCount = new int[universeHeight, universeWidth];
            generations = 0;
        }
        public void CellCount(bool toroid)
        {
            liveCells = 0;
            for (int y = 0; y < CellVerse.GetLength(1); y++)
            {
                for (int x = 0; x < CellVerse.GetLength(0); x++)
                {
                    NeighborCheck(x, y, toroid);
                }
            }
        }
        public void NextGeneration(bool toroid)
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
            CellCount(toroid);
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
            if (!Torod)
            {
                int posx = x;
                int posy = y;
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
                int posx = -1;
                int posy = -1;
                if (CellVerse[x, y])
                {
                    liveCells++;
                }
                if (x + 1 >= CellVerse.GetLength(0))
                {
                    posx = 0;
                }
                else if (x - 1 < 0)
                {
                    posx = CellVerse.GetLength(0) - 1;
                }
                if (y + 1 >= CellVerse.GetLength(1))
                {
                    posy = 0;
                }
                else if (y - 1 < 0)
                {
                    posy = CellVerse.GetLength(1) - 1;
                }
                neighbourCount[x, y] = 0;
                //top
                //upleft
                if (x - 1 >= 0 && y - 1 >= 0 && CellVerse[x - 1, y - 1])
                {
                    neighbourCount[x, y]++;
                }
                //overflows both
                else if (posx == CellVerse.GetLength(0) - 1 && posy == CellVerse.GetLength(1) - 1 && CellVerse[posx, posy])
                {
                    neighbourCount[x, y]++;
                }
                //overflows up
                else if (x - 1 >= 0 && posy == CellVerse.GetLength(1) - 1 && CellVerse[x-1, posy])
                {
                    neighbourCount[x, y]++;
                }
                //overflows left
                else if (posx == CellVerse.GetLength(0) - 1 && y - 1 >= 0 && CellVerse[posx, y - 1])
                {
                    neighbourCount[x, y]++;
                }
                //up
                if (y - 1 >= 0 && CellVerse[x, y - 1])
                {
                    neighbourCount[x, y]++;
                }
                //overflows up
                else if (posy == CellVerse.GetLength(1) - 1 && CellVerse[x, posy])
                {
                    neighbourCount[x, y]++;
                }
                //upright
                if (x + 1 < CellVerse.GetLength(0) && y - 1 >= 0 && CellVerse[x + 1, y - 1])
                {
                    neighbourCount[x, y]++;
                }
                //overflows both
                else if (posx == 0 && posy == CellVerse.GetLength(1) - 1 && CellVerse[posx, posy])
                {
                    neighbourCount[x, y]++;
                }
                //overflows up
                else if (x + 1 < CellVerse.GetLength(0) && posy == CellVerse.GetLength(1) - 1 && CellVerse[x + 1, posy])
                {
                    neighbourCount[x, y]++;
                }
                //overflows right
                else if (posx == 0 && y - 1 >= 0 && CellVerse[posx, y - 1])
                {
                    neighbourCount[x, y]++;
                }

                //middle
                //left
                if (x - 1 >= 0 && CellVerse[x - 1, y])
                {
                    neighbourCount[x, y]++;
                }
                else if (posx == CellVerse.GetLength(0) - 1 && CellVerse[posx, y])
                {
                    neighbourCount[x, y]++;
                }
                //right
                if (x + 1 < CellVerse.GetLength(0) && CellVerse[x + 1, y])
                {
                    neighbourCount[x, y]++;
                }
                else if (posx == 0 && CellVerse[posx, y])
                {
                    neighbourCount[x, y]++;
                }
                //bottom
                //downleft
                if (x - 1 >= 0 && y + 1 < CellVerse.GetLength(1) && CellVerse[x - 1, y + 1])
                {
                    neighbourCount[x, y]++;
                }
                //overflows both
                else if (posx == CellVerse.GetLength(0) - 1 && posy == 0 && CellVerse[posx, posy])
                {
                    neighbourCount[x, y]++;
                }
                //overflows down
                else if (x - 1 >= 0 && posy == 0  && CellVerse[x - 1, posy])
                {
                    neighbourCount[x, y]++;
                }
                //overflows left
                else if (posx == CellVerse.GetLength(0) - 1 && y + 1 < CellVerse.GetLength(1) && CellVerse[posx, y + 1])
                {
                    neighbourCount[x, y]++;
                }
                //down
                if (y + 1 < CellVerse.GetLength(1) && CellVerse[x, y + 1])
                {
                    neighbourCount[x, y]++;
                }
                //overflows down
                else if (posy == 0 && CellVerse[x, posy])
                {
                    neighbourCount[x, y]++;
                }
                //downright
                if (x + 1 < CellVerse.GetLength(0) && y + 1 < CellVerse.GetLength(1) && CellVerse[x + 1, y + 1])
                {
                    neighbourCount[x, y]++;
                }
                //overflows both
                else if (posx == 0 && posy == 0 && CellVerse[posx, posy])
                {
                    neighbourCount[x, y]++;
                }
                //overflows down
                else if (x + 1 < CellVerse.GetLength(0) && posy == 0 && CellVerse[x + 1, posy])
                {
                    neighbourCount[x, y]++;
                }
                //overflows right
                else if (posx == 0 && y + 1 < CellVerse.GetLength(1) && CellVerse[posx, y + 1])
                {
                    neighbourCount[x, y]++;
                }
            }
        }
        public void GenerateWorldSeed(int seed, bool toroid)
        {
            generations = 0;
            Random Temp = new Random(seed);
            for (int y = 0; y < CellVerse.GetLength(1); y++)
            {
                for (int x = 0; x < CellVerse.GetLength(0); x++)
                {
                    if ((seed * Temp.Next()) % 3 == 0)
                    {
                        CellVerse[x, y] = true;
                    }
                    else
                    {
                        CellVerse[x, y] = false;
                    }
                }
            }
            CellCount(toroid);
        }
        public UniverseHandler Copy()
        {
            return (UniverseHandler)this.MemberwiseClone();
        }
    }
}
