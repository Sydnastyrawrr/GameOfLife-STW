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
    public partial class RandomizeBySeed : Form
    {
        public RandomizeBySeed()
        {
            InitializeComponent();
        }

        private void aButtonRandomize_Click(object sender, EventArgs e)
        {
            Random seed = new Random();

            aUpDownSeedNum.Value = seed.Next(100000000, 1000000000);
        }

        public int RandomizeSeed
        {
            get
            {
                return (int)aUpDownSeedNum.Value;
            }
            
            set
            {
                aUpDownSeedNum.Value = value;
            }
        }
    }
}
