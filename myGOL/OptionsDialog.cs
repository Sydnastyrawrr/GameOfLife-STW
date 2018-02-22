using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGOL
{
    public partial class OptionsDialog : Form
    {
        public OptionsDialog()
        {
            InitializeComponent();
        }

        private void aButtonGridColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = aButtonGridColor.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                aButtonGridColor.BackColor = dlg.Color;
            }
        }

        private void aButtonBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = aButtonBackgroundColor.BackColor;

            if(DialogResult.OK == dlg.ShowDialog())
            {
                aButtonBackgroundColor.BackColor = dlg.Color;
            }
        }

        private void aButtonLiveCellColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = aButtonLiveCellColor.BackColor;

            if(DialogResult.OK == dlg.ShowDialog())
            {
                aButtonLiveCellColor.BackColor = dlg.Color;
            }
        }

        private void aButtonReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();

            //Read Settings
            aButtonBackgroundColor.BackColor = Properties.Settings.Default.PanelColor; 
            aButtonGridColor.BackColor = Properties.Settings.Default.GridColor;
            aButtonLiveCellColor.BackColor = Properties.Settings.Default.CellColor;
        }

        public int TimeInterval
        {
            get
            {
                return (int)aUpDownTime.Value;
            }

            set
            {
                aUpDownTime.Value = value;
            }
        }

        public int GridWidth
        {
            get
            {
                return (int)aUpDownWidth.Value;
            }

            set
            {
                aUpDownWidth.Value = value;
            }
        }

        public int GridHeight
        {
            get
            {
                return (int)aUpDownHeight.Value;
            }

            set
            {
                aUpDownHeight.Value = value;
            }
        }
        public Color GridColor
        {
            get
            {
                return aButtonGridColor.BackColor;
            }

            set
            {
                aButtonGridColor.BackColor = value;
            }
        }

        public Color BackgroundColor
        {
            get
            {
                return aButtonBackgroundColor.BackColor;
            }

            set
            {
                aButtonBackgroundColor.BackColor = value;
            }
        }

        public Color LiveCellColor
        {
            get
            {
                return aButtonLiveCellColor.BackColor;
            }

            set
            {
                aButtonLiveCellColor.BackColor = value;
            }
        }

        public int BoundaryType
        {
            get
            {
                if (aRadioButtonFinite.Checked) return 1;
                if (aRadioButtonToroidal.Checked) return 0;
                else return 1;
            }

            set
            {
                if (value == 0) aRadioButtonToroidal.Checked = true;
                if (value == 1) aRadioButtonFinite.Checked = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
