using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KurtisMcCammon1
{
    public partial class Settings : Form
    {
        public UserSettings Real { get; set; }
        public UserSettings Temp { get; set; }
        public Settings()
        {
            InitializeComponent();
        }

        private void LivingCellColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Real.CellColor;
            if(DialogResult.OK == dlg.ShowDialog())
            {
                Temp.CellColor = dlg.Color;
                LivingCell_pre.BackColor = dlg.Color;
            }
        }

        private void BorderColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Real.GridLines;
            if (DialogResult.OK == dlg.ShowDialog())
            {
                Temp.GridLines = dlg.Color;
                BorderColor_pre.BackColor = dlg.Color;
            }
        }

        private void DeadCellColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Real.Background;
            if (DialogResult.OK == dlg.ShowDialog())
            {
                Temp.Background = dlg.Color;
                DeadCell_pre.BackColor = dlg.Color;
            }
        }

        private void LivingFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Real.LivingFontColor;
            if (DialogResult.OK == dlg.ShowDialog())
            {
                Temp.CellColor = dlg.Color;
                LivingCell_txtpre.BackColor = dlg.Color;
            }
        }

        private void BirthFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Real.BirthFontColor;
            if (DialogResult.OK == dlg.ShowDialog())
            {
                Temp.BirthFontColor = dlg.Color;
                BirthCell_txtpre.BackColor = dlg.Color;
            }
        }

        private void DyingFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Real.DyingFontColor;
            if (DialogResult.OK == dlg.ShowDialog())
            {
                Temp.DyingFontColor = dlg.Color;
                DyeCell_txtpre.BackColor = dlg.Color;
            }
        }
        private void DeadFont_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Real.DeadFontColor;
            if (DialogResult.OK == dlg.ShowDialog())
            {
                Temp.DeadFontColor = dlg.Color;
                DeadFont_pre.BackColor = dlg.Color;
            }
        }

        private void _SetUniverse(object sender, EventArgs e)
        {
            Temp.UniverseWidth = (int)_UWidth.Value;
            Temp.UniverseHeight = (int)_UHeight.Value;
        }
        private void _SetTickSpeed_Click(object sender, EventArgs e)
        {
            Temp.TickSpeed = (int)_Speed.Value;
        }

        private void Settings_Shown(object sender, EventArgs e)
        {

            LivingCell_pre.BackColor = Real.CellColor;
            BorderColor_pre.BackColor = Real.GridLines;
            DeadCell_pre.BackColor = Real.Background;
            LivingCell_txtpre.BackColor = Real.LivingFontColor;
            BirthCell_txtpre.BackColor = Real.BirthFontColor;
            DyeCell_txtpre.BackColor = Real.DyingFontColor;
            DeadFont_pre.BackColor = Real.DeadFontColor;

            _UWidth.Value = Real.UniverseWidth;
            _UHeight.Value = Real.UniverseHeight;
            _Speed.Value = Real.TickSpeed;

            _GridOn.Checked = Real.gridon;
            Temp = Real.Copy();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void Apply_Click(object sender, EventArgs e)
        {
            Temp.gridon = _GridOn.Checked;
            this.DialogResult = DialogResult.OK;
        }
    }
}
