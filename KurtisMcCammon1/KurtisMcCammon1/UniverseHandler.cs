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
        public bool[,] universe { get; private set; }
        public int generations { get; private set; }
        bool[,] scratchPad { get; set; }
        public int[,] neighbourCount { get; private set; }

        public int liveCells { get; private set; }

        public UniverseHandler()
        {
            universe = new bool[10, 10];
            neighbourCount = new int[10, 10];
            generations = 0;
        }
        public void CellCount()
        {
            liveCells = 0;
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    NeighborCheck(x, y);
                }
            }
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
        private void NeighborCheck(int x, int y)
        {
            int posx = x; int posy = y;
            if (universe[posx, posy])
            {
                liveCells++;
            }
            neighbourCount[posx, posy] = 0;
            //top
            //upleft
            if (x - 1 >= 0 && y - 1 >= 0 && universe[x - 1, y - 1])
            {
                neighbourCount[posx, posy]++;
            }
            //up
            if (y - 1 >= 0 && universe[x, y - 1])
            {
                neighbourCount[posx, posy]++;
            }
            //upright
            if (x + 1 < universe.GetLength(0) && y - 1 >= 0 && universe[x + 1, y - 1])
            {
                neighbourCount[posx, posy]++;
            }

            //middle
            //left
            if (x - 1 >= 0 && universe[x - 1, y])
            {
                neighbourCount[posx, posy]++;
            }
            //right
            if (x + 1 < universe.GetLength(0) && universe[x + 1, y])
            {
                neighbourCount[posx, posy]++;
            }

            //bottom
            //downleft
            if (x - 1 >= 0 && y + 1 < universe.GetLength(1) && universe[x - 1, y + 1])
            {
                neighbourCount[posx, posy]++;
            }
            //down
            if (y + 1 < universe.GetLength(1) && universe[x, y + 1])
            {
                neighbourCount[posx, posy]++;
            }
            //downright
            if (x + 1 < universe.GetLength(0) && y + 1 < universe.GetLength(1) && universe[x + 1, y + 1])
            {
                neighbourCount[posx, posy]++;
            }
        }
        public void NextGeneration()
        {
            liveCells = 0;
            bool[,] temp = universe;
            scratchPad = new bool[universe.GetLength(0), universe.GetLength(1)];
            scratchPad = temp;
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    VibeCheck(x, y);
                }
            }
            universe = scratchPad;
            CellCount();
            generations++;
        }
    }
}
