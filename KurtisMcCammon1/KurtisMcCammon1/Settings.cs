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
    public partial class Settings : Form
    {
        UserSettings Real;
        UserSettings Temp;
        public Settings(ref UserSettings userinfo)
        {
            Real = userinfo;
            Temp = userinfo;
            InitializeComponent();
            LivingCell_pre.BackColor = Real.CellColor;
            DeadCell_pre.BackColor = Real.Background;
            LivingCell_txtpre.BackColor = Real.LivingFontColor;
            BirthCell_txtpre.BackColor = Real.BirthFontColor;
            DyeCell_txtpre.BackColor = Real.DyingFontColor;
        }

        private void LivingCellColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Temp.CellColor;
            dlg.ShowDialog();
            Temp.CellColor = dlg.Color;
            LivingCell_pre.BackColor = dlg.Color;

        }
    }
}
