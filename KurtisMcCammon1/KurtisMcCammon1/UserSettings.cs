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
        //Hud Color
        public Color HudFontColor { get; set; }

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

        //Seed number
        public int Seed { get; set; }
        public bool Grid { get; set; }
        public bool Neighbor { get; set; }
        public bool HudOn { get; set; }

        //Default settings
        public UserSettings()
        {
            torofinite = false;

            LivingFontColor = Color.Green;
            BirthFontColor = Color.PeachPuff;
            DeadFontColor = Color.Gray;
            DyingFontColor = Color.DarkRed;
            HudFontColor = Color.Purple;

            Background = Color.White;
            CellColor = Color.DarkGray;
            GridLines = Color.Black;

            TickSpeed = 100;
            UniverseWidth = 10;
            UniverseHeight = 10;

            Seed = 69420;
            Grid = true;
            Neighbor = true;
            HudOn = true;
        }

        public UserSettings(bool toro, Color liv, Color Bir, Color Ded, Color Dye, Color Hud, Color Back, Color Cell, Color GridColor, int tic, int Wid, int hi, int see, bool gridState, bool neighborState, bool HudState)
        {
            torofinite = toro;

            LivingFontColor = liv;
            BirthFontColor = Bir;
            DeadFontColor = Ded;
            DyingFontColor = Dye;
            HudFontColor = Hud;

            Background = Back;
            CellColor = Cell;
            GridLines = GridColor;

            TickSpeed = tic;
            UniverseWidth = Wid;
            UniverseHeight = hi;

            Seed = see;
            Grid = gridState;
            Neighbor = neighborState;
            HudOn = HudState;
        }
        public UserSettings Copy()
        {
            return (UserSettings)this.MemberwiseClone();
        }
    }
}
