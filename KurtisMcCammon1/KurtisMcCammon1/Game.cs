using System;
using System.Drawing;
using System.Windows.Forms;

namespace KurtisMcCammon1
{
    public partial class Game : Form
    {
        UniverseHandler Universe;
        UserSettings Settings = new UserSettings(Properties.Settings.Default.torofinite, Properties.Settings.Default.LivingFontColor, Properties.Settings.Default.BirthFontColor, Properties.Settings.Default.DeadFontColor, Properties.Settings.Default.DyingFontColor, Properties.Settings.Default.Background, Properties.Settings.Default.CellColor, Properties.Settings.Default.GridLines, Properties.Settings.Default.TickSpeed, Properties.Settings.Default.UniverseWidth, Properties.Settings.Default.UniverseHeight, Properties.Settings.Default.Seed);
        // Drawing colors

        // The Timer class
        Timer timer = new Timer();

        public Game()
        {
            InitializeComponent();

            //Set all the settings if old settings are found
            Universe = new UniverseHandler(Settings.UniverseHeight, Settings.UniverseWidth);
            // Setup the timer
            timer.Interval = Settings.TickSpeed; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // stop timer running
        }

        // Calculate the next generation of cells

        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            Universe.NextGeneration();
            GenCount.Text = "Generations = " + Universe.generations.ToString();
            graphicsPanel1.Invalidate();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            //FLOATS casting also use lines
            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            float cellWidth = (float)graphicsPanel1.ClientSize.Width / Universe.CellVerse.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            float cellHeight = (float)graphicsPanel1.ClientSize.Height / Universe.CellVerse.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(Settings.GridLines, 1);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(Settings.CellColor);


            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < Universe.CellVerse.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < Universe.CellVerse.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    RectangleF cellRect = Rectangle.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    Font font = new Font("Arial", (cellHeight * 3 / 4));
                    Brush TextColor = new SolidBrush(Settings.LivingFontColor);

                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    // Fill the cell with a brush if alive
                    if (Universe.CellVerse[x, y])
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                        if (Universe.neighbourCount[x, y] > 3 || Universe.neighbourCount[x, y] < 2)
                        {
                            TextColor = new SolidBrush(Settings.DyingFontColor);
                        }
                        e.Graphics.DrawString(Universe.neighbourCount[x, y].ToString(), font, TextColor, cellRect, stringFormat);
                    }

                    else if (Universe.neighbourCount[x, y] != 0 && !(Universe.CellVerse[x, y]))
                    {
                        TextColor = new SolidBrush(Settings.DeadFontColor);
                        if (Universe.neighbourCount[x, y] == 3)
                        {
                            TextColor = new SolidBrush(Settings.BirthFontColor);
                        }
                        e.Graphics.DrawString(Universe.neighbourCount[x, y].ToString(), font, TextColor, cellRect, stringFormat);
                    }

                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                }
            }
            _CellCount.Text = "Count = " + Universe.liveCells.ToString();

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
                float cellWidth = (float)graphicsPanel1.ClientSize.Width / Universe.CellVerse.GetLength(0);
                float cellHeight = (float)graphicsPanel1.ClientSize.Height / Universe.CellVerse.GetLength(1);

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                float xt = e.X / cellWidth;
                // CELL Y = MOUSE Y / CELL HEIGHT
                float yt = e.Y / cellHeight;
                int x = (int)xt;
                int y = (int)yt;
                // Toggle the cell's state
                Universe.CellVerse[(int)x, (int)y] = !Universe.CellVerse[(int)x, (int)y];

                //count
                Universe.CellCount();
                _CellCount.Text = "Count = " + Universe.liveCells.ToString();
                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }

        private void _PlayTime(object sender, EventArgs e)
        {
            timer.Start();
            GenCount.Text = "Generations = " + Universe.generations.ToString();
            _CellCount.Text = "Count = " + Universe.liveCells.ToString();
            graphicsPanel1.Invalidate();
        }

        private void _PauseTime(object sender, EventArgs e)
        {
            timer.Stop();
            GenCount.Text = "Generations = " + Universe.generations.ToString();
            _CellCount.Text = "Count = " + Universe.liveCells.ToString();
            graphicsPanel1.Invalidate();
        }

        private void _NextGen(object sender, EventArgs e)
        {
            Universe.NextGeneration();
            GenCount.Text = "Generations = " + Universe.generations.ToString();
            _CellCount.Text = "Count = " + Universe.liveCells.ToString();
            graphicsPanel1.Invalidate();
        }

        private void _NewFile(object sender, EventArgs e)
        {
            Universe = new UniverseHandler();
            GenCount.Text = "Generations = " + Universe.generations.ToString();
            _CellCount.Text = "Count = " + Universe.liveCells.ToString();
            timer.Stop();
            graphicsPanel1.Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void theGoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings dlg = new Settings();
            dlg.Real = Settings;
            if (DialogResult.OK == dlg.ShowDialog())
            {
                Settings = dlg.Temp;
            }
            Universe = new UniverseHandler(Settings.UniverseHeight, Settings.UniverseWidth);
            timer.Interval = Settings.TickSpeed;
            graphicsPanel1.Invalidate();
        }
    }
}
