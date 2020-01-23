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
    public partial class SeedSelection : Form
    {
        public int Seed { get; set; }
        public SeedSelection()
        {
            InitializeComponent();
        }

        private void _SeedTime_CheckedChanged(object sender, EventArgs e)
        {
            _UserSeedInput.Enabled = false;
        }

        private void _UserSeed_CheckedChanged(object sender, EventArgs e)
        {
            _UserSeedInput.Enabled = true;
        }

        private void _Apply_Click(object sender, EventArgs e)
        {
            if (_SeedTime.Checked)
            {
                Random TimeRng = new Random((int)DateTime.Now.Ticks);
                Seed = TimeRng.Next();
            }
            if (_UserSeed.Checked)
            {
                Seed = (int)_UserSeedInput.Value;
            }
            DialogResult = DialogResult.OK;
        }

        private void _Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SeedSelection_Shown(object sender, EventArgs e)
        {
            _UserSeedInput.Value = Seed;
            _UserSeedInput.Enabled = false;
        }
    }
}
