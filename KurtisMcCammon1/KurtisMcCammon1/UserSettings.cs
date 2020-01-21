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
    public class UserSettings
    {
        //true for toroidal false for finite
        public bool torofinite { get; set; }

        //font colors
        //Living color
        public Color LivingFontColor { get; set; }
        //Coming to Life
        public Color BirthFontColor { get; set; }
        //Dead
        public Color DeadFontColor { get; set; }
        //Dieing
        public Color DyingFontColor { get; set; }

        //cell colors
        //background
        public Color Background { get; set; }
        //cell
        public Color CellColor { get; set; }
        //grid
        public Color GridLines { get; set; }

        //tick speed
        public int TickSpeed { get; set; }
        //width of universe
        public int UniverseWidth { get; set; }
        //height of universe
        public int UniverseHeight { get; set; }

        //Default settings
        public UserSettings()
        {
            torofinite = false;

            LivingFontColor = Color.Green;
            BirthFontColor = Color.PeachPuff;
            DeadFontColor = Color.Gray;
            DyingFontColor = Color.DarkRed;

            Background = Color.White;
            CellColor = Color.MediumPurple;
            GridLines = Color.Orange;

            TickSpeed = 100;
            UniverseWidth = 10;
            UniverseHeight = 10;
        }

        public UserSettings(bool toro, Color liv, Color Bir, Color Ded, Color Dye, Color Back, Color Cell, Color Grid, int tic, int Wid, int hi)
        {
            torofinite = toro;

            LivingFontColor = liv;
            BirthFontColor = Bir;
            DeadFontColor = Ded;
            DyingFontColor = Dye;

            Background = Back;
            CellColor = Cell;
            GridLines = Grid;

            TickSpeed = tic;
            UniverseWidth = Wid;
            UniverseHeight = hi;
        }
    }
}
