using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGOL
{
    class MyGraphicsPanel : Panel
    {
        //Default Constructor

        public MyGraphicsPanel()
        {
            //Turn on Double Buffering
            this.DoubleBuffered = true;

            //Allow Repainting when the Window is resized.
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
    }
}
