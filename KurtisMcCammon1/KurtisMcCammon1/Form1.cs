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
    public partial class Form1 : Form
    {
        UniverseHandler universe = new UniverseHandler();
        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Gray;

        // The Timer class
        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();

            // Setup the timer
            timer.Interval = 100; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = true; // start timer running
        }

        // Calculate the next generation of cells

        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            universe.NextGeneration();
            toolStripStatusLabelGenerations.Text = "Generations = " + universe.generations.ToString();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            //FLOATS casting also use lines
            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            float cellWidth = (float)graphicsPanel1.ClientSize.Width / universe.universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            float cellHeight = (float)graphicsPanel1.ClientSize.Height / universe.universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    RectangleF cellRect = Rectangle.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    // Fill the cell with a brush if alive
                    if (universe.universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                    }

                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                }
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the width and height of each cell in pixels
                int cellWidth = graphicsPanel1.ClientSize.Width / universe.universe.GetLength(0);
                int cellHeight = graphicsPanel1.ClientSize.Height / universe.universe.GetLength(1);

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                int x = e.X / cellWidth;
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = e.Y / cellHeight;

                // Toggle the cell's state
                universe.universe[x, y] = !universe.universe[x, y];

                //count
                universe.CellCount();
                CellCount.Text = "Count = " + universe.liveCells.ToString();
                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }
        private void _NewFileButton_Click(object sender, EventArgs e)
        {
            universe = new UniverseHandler();
            toolStripStatusLabelGenerations.Text = "Generations = " + universe.generations.ToString();
            graphicsPanel1.Invalidate();
        }

        private void _Play_Click(object sender, EventArgs e)
        {
            timer.Start();
            toolStripStatusLabelGenerations.Text = "Generations = " + universe.generations.ToString();
        }

        private void _Pause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            toolStripStatusLabelGenerations.Text = "Generations = " + universe.generations.ToString();
        }

        private void _Next_Click(object sender, EventArgs e)
        {
            universe.NextGeneration();
            toolStripStatusLabelGenerations.Text = "Generations = " + universe.generations.ToString();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
