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
        int[,] neighbourCount { get; set; }

        public int liveCells { get; private set; }

        public UniverseHandler()
        {
            universe = new bool[5, 5];
            neighbourCount = new int[5, 5];
            generations = 0;
        }
        public void CellCount()
        {
            liveCells = universe.GetLength(0) * universe.GetLength(1);
            scratchPad = new bool[universe.GetLength(0), universe.GetLength(1)];
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    scratchPad[x, y] = universe[x, y];
                    VibeCheck(x, y);
                }
            }
        }
        private void VibeCheck(int x, int y)
        {
            int posx = x; int posy = y;
            if (universe[posx, posy])
            {
                //top
                //upleft
                if (x - 1 > 0 && y - 1 > 0 && universe[x - 1, y - 1])
                {
                    neighbourCount[posx, posy]++;
                }
                //up
                if (y - 1 > 0 && universe[x, y - 1])
                {
                    neighbourCount[posx, posy]++;
                }
                //upright
                if (x + 1 < universe.GetLength(0) && y - 1 > universe.GetLength(1) && universe[x + 1, y - 1])
                {
                    neighbourCount[posx, posy]++;
                }
                
                //middle
                //left
                if (x - 1 > 0 && universe[x-1,y])
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
                if (x - 1 < universe.GetLength(0) && y + 1 > universe.GetLength(1) && universe[x - 1, y + 1])
                {
                    neighbourCount[posx, posy]++;
                }
                //down
                if (y + 1 > universe.GetLength(1) && universe[x, y + 1])
                {
                    neighbourCount[posx, posy]++;
                }
                //downright
                if (x + 1 < universe.GetLength(0) && y + 1 > universe.GetLength(1) && universe[x + 1, y + 1])
                {
                    neighbourCount[posx, posy]++;
                }
            }
        }
        public void NextGeneration()
        {
            generations++;
        }
    }
}
