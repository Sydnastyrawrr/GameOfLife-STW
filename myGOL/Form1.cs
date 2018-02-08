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
    public partial class Form1 : Form
    {
        //Universe Size
         int mWidth = 20;
         int mHeight = 20;

        //The Universe Array
        bool[,] mUniverse;

        //Drawing Colors
        Color mGridColor = Color.Azure;
        Color mCellColor = Color.Gray;

        //The Timer Class
        Timer mTimer = new Timer();

        //Generation Count
        int mGenerations = 0;

        //Cell Count
        int mCellCount = 0;

        //Boundary Type
        string mBoundaryType;

        //To Draw Neighbors
        bool mDrawNeighbors = true;

        //To Draw Grid Lines
        bool mDrawGridLines = true;

        public Form1()
        {
            InitializeComponent();

            mUniverse = new bool[mWidth, mHeight];

            //Set Timer
            mTimer.Interval = 200;
            //mTimer.Enabled = true;
            mTimer.Tick += MTimer_Tick;

            this.Text = Properties.Resources.AppTitle;

            StatusandLabel();
        }

        private void MTimer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
            aGraphicsPanel.Invalidate();
        }

        private int CountNeighbors(bool[,] universe, int x, int y)
        {
            int mNeighborCount = 0;

            if (y - 1 >=0 && universe[x, y - 1] == true)
            {
                mNeighborCount++;
            }
            if (x + 1 < universe.GetLength(0) && y - 1 >= 0 && universe[x + 1, y - 1] == true)
            {
                mNeighborCount++;
            }
            if (x + 1 < universe.GetLength(0) && universe[x + 1, y] == true)
            {
                mNeighborCount++;
            }
            if (y + 1 < universe.GetLength(1) && universe[x, y + 1] == true)
            {
                mNeighborCount++;
            }
            if (x - 1 >= 0 && y - 1 >= 0 && universe[x - 1, y - 1] == true)
            {
                mNeighborCount++;
            }
            if (x + 1 < universe.GetLength(0) && y + 1 < universe.GetLength(1) && universe[x + 1, y + 1] == true)
            {
                mNeighborCount++;
            }
            if (x - 1 >= 0 && universe[x - 1, y] == true)
            {
                mNeighborCount++;
            }
            if (x - 1 >= 0 && y + 1 < universe.GetLength(1) && universe[x - 1, y + 1] == true)
            {
                mNeighborCount++;
            }


            return mNeighborCount;
        }

        private void NextGeneration()
        {
            bool[,] mScratchPad = new bool[mWidth, mHeight];

            //Create the Next Generation
            //Iterate Through the Universe in the Y, Top to Bottom
            for (int y = 0; y < mUniverse.GetLength(1); y++)
            {
                //Iterate Through the Universe in the X, Left to Right
                for (int x = 0; x < mUniverse.GetLength(0); x++)
                {
                    if (mUniverse[x,y] == true)
                    {
                        if (CountNeighbors(mUniverse,x,y) < 2)
                        {
                            mScratchPad[x, y] = false;
                        }
                        else if (CountNeighbors(mUniverse, x, y) > 3)
                        {
                            mScratchPad[x, y] = false;
                        }
                        else if (CountNeighbors(mUniverse, x, y) == 2 || CountNeighbors(mUniverse, x, y) == 3)
                        {
                            mScratchPad[x, y] = true;
                        }                      
                    }

                    if (mUniverse[x,y] == false)
                    {
                        if (CountNeighbors(mUniverse, x, y) == 3)
                        {
                            mScratchPad[x, y] = true;
                        }
                    }
                }
            }


            //bool[,] temp = mUniverse;
            mUniverse = mScratchPad;
            //mScratchPad = temp;
            mGenerations++;
            StatusandLabel();

            aGraphicsPanel.Invalidate();
        }

        private void aGraphicsPanel_Paint(object sender, PaintEventArgs e)
        {
            
            //The Width and Height of Each Cell in Pixels
            float mCellWidth = (float)aGraphicsPanel.ClientSize.Width / mUniverse.GetLength(0);
            float mCellHeight = (float)aGraphicsPanel.ClientSize.Height / mUniverse.GetLength(1);

            //A Pen for Drawing the Grid Lines (Color, Width)
            Pen mGridPen = new Pen(mGridColor, 1);

            //Cell Brush
            Brush mCellBrush = new SolidBrush(mCellColor);

            //Center Text Inside a Rectangle
            Font font = new Font("Georgia", 20f);

            StringFormat mStringFormat = new StringFormat();
            mStringFormat.Alignment = StringAlignment.Center;
            mStringFormat.LineAlignment = StringAlignment.Center;

            //Iterate Through the Universe in the Y, Top to Bottom
            for (int y = 0; y < mUniverse.GetLength(1); y++)
            {
                //Iterate Thought the Universe in the X, Left to Right
                for (int x = 0; x < mUniverse.GetLength(0); x++)
                {
                    //A Rectangle to Represent Each Cell in Pixels
                    RectangleF mCellRect = RectangleF.Empty;
                    mCellRect.X = x * mCellWidth;
                    mCellRect.Y = y * mCellHeight;
                    mCellRect.Width = mCellWidth;
                    mCellRect.Height = mCellHeight;

                    //Fill the Cell With a Brush
                    if (mUniverse[x,y] == true)
                    {
                        e.Graphics.FillRectangle(mCellBrush, mCellRect);
                    }

                    if (mDrawGridLines == true)
                    {
                        //Outline the Cell With a Pen
                        e.Graphics.DrawRectangle(mGridPen, mCellRect.X, mCellRect.Y, mCellRect.Width, mCellRect.Height);
                    }


                    //Draw Neighbors
                    if (mDrawNeighbors == true)
                    {
                        //Check Neighbors
                        int mNeighborCount = CountNeighbors(mUniverse, x, y);
                        if (mNeighborCount == 1)
                        {
                            e.Graphics.DrawString(CountNeighbors(mUniverse, x, y).ToString(), font, Brushes.Black, mCellRect, mStringFormat);
                            //aGraphicsPanel.Invalidate();
                        }
                        if (mNeighborCount > 1)
                        {
                            e.Graphics.DrawString(CountNeighbors(mUniverse, x, y).ToString(), font, Brushes.CornflowerBlue, mCellRect, mStringFormat);
                        }
                    }

                }
            }
            

            //Cleaning Up Pens and Brushes
            mGridPen.Dispose();
            mCellBrush.Dispose();
        }

        private void aGraphicsPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //The Width and Height of Each Cell in Pixels
                float mCellWidth = (float)aGraphicsPanel.ClientSize.Width / mUniverse.GetLength(0);
                float mCellHeight = (float)aGraphicsPanel.ClientSize.Height / mUniverse.GetLength(1);

                int x = e.X / (int)mCellWidth;
                int y = e.Y / (int)mCellHeight;

                mUniverse[x, y] = !mUniverse[x, y];

                aGraphicsPanel.Invalidate();
                StatusandLabel();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Iterate Through the Universe in the Y, Top to Bottom
            for (int y = 0; y < mUniverse.GetLength(1); y++)
            {
                //Iterate Thought the Universe in the X, Left to Right
                for (int x = 0; x < mUniverse.GetLength(0); x++)
                {
                    mUniverse[x, y] = false;
                }
            }

            mTimer.Stop();
            mGenerations = 0;
            mCellCount = 0;
            StatusandLabel();
            aGraphicsPanel.Invalidate();
        }

        private void StatusandLabel()
        {
            mCellCount = 0;
            mWidth = mUniverse.GetLength(0);
            mHeight = mUniverse.GetLength(1);
            for (int y = 0; y < mUniverse.GetLength(1); y++)
            {
                for (int x = 0; x < mUniverse.GetLength(0); x++)
                {
                    if (mUniverse[x, y] == true)
                        mCellCount++;
                }
            }

            //Strip Status
            aStripStatusGenerations.Text = "Generations: " + mGenerations.ToString();
            aStripStatusCellCount.Text = "Cells: " + mCellCount.ToString();
            aStripStatusBoundaryType.Text = "Boundary: " + mBoundaryType;

            //Labels
            aLabelGenerations.Text = "Generations: " + mGenerations.ToString();
            aLabelCellCount.Text = "Cell Count: " + mCellCount.ToString();
            aLabelBoundaryType.Text = "Boundary Type: " + mBoundaryType;
            aLabelUniverseSize.Text = "Universe Size: {Width = " + mWidth.ToString() + ", Height = " + mHeight.ToString() + "}";

        }

        private void aStripButtonPause_Click(object sender, EventArgs e)
        {
            mTimer.Stop();
            aStripButtonPause.Enabled = false;
            aContextMenuPause.Enabled = false;
        }

        private void aStripButtonNext_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void aStripButtonPlay_Click(object sender, EventArgs e)
        {
            mTimer.Start();
            aStripButtonPause.Enabled = true;
            aContextMenuPause.Enabled = true;
        }

        private void aContextMenuStripItemHUDVisible_Click(object sender, EventArgs e)
        {
            if (aContextMenuStripItemHUDVisible.Checked == false)
            {
                aToolStripHUD.Checked = false;
                aLabelBoundaryType.Visible = false;
                aLabelCellCount.Visible = false;
                aLabelGenerations.Visible = false;
                aLabelUniverseSize.Visible = false;
            }

            else if (aContextMenuStripItemHUDVisible.Checked == true)
            {
                aToolStripHUD.Checked = true;
                aContextMenuStripItemHUDVisible.Checked = true;
                aLabelUniverseSize.Visible = true;
                aLabelGenerations.Visible = true;
                aLabelCellCount.Visible = true;
                aLabelBoundaryType.Visible = true;
            }
        }

        private void aContextMenuStripItemNeighborCount_Click(object sender, EventArgs e)
        {
            if (aContextMenuStripItemNeighborCount.Checked == false)
            {
                aToolStripNeighborCount.Checked = false;
                mDrawNeighbors = false;
                aGraphicsPanel.Refresh();
            }

            else if (aContextMenuStripItemNeighborCount.Checked == true)
            {
                aToolStripNeighborCount.Checked = true;
                mDrawNeighbors = true;
                aGraphicsPanel.Refresh();
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
        }

        private void aToolStripHUD_Click(object sender, EventArgs e)
        {
            if (aToolStripHUD.Checked == false)
            {
                aContextMenuStripItemHUDVisible.Checked = false;
                aLabelBoundaryType.Visible = false;
                aLabelCellCount.Visible = false;
                aLabelGenerations.Visible = false;
                aLabelUniverseSize.Visible = false;
            }

            else if (aToolStripHUD.Checked == true)
            {
                aContextMenuStripItemHUDVisible.Checked = true;
                aLabelUniverseSize.Visible = true;
                aLabelGenerations.Visible = true;
                aLabelCellCount.Visible = true;
                aLabelBoundaryType.Visible = true;
            }
        }

        private void aToolStripNeighborCount_Click(object sender, EventArgs e)
        {
            if (aToolStripNeighborCount.Checked == false)
            {
                aContextMenuStripItemNeighborCount.Checked = false;
                mDrawNeighbors = false;
                aGraphicsPanel.Refresh();
            }

            else if (aToolStripNeighborCount.Checked == true)
            {
                aContextMenuStripItemNeighborCount.Checked = true;
                mDrawNeighbors = true;
                aGraphicsPanel.Refresh();
            }
        }

        private void aToolStripGrid_Click(object sender, EventArgs e)
        {
            if (aToolStripGrid.Checked == false)
            {
                aContextMenuStripItemGrid.Checked = false;
                mDrawGridLines = false;
                aGraphicsPanel.Refresh();
            }

            else if (aToolStripGrid.Checked == true)
            {
                aContextMenuStripItemGrid.Checked = true;
                mDrawGridLines = true;
                aGraphicsPanel.Refresh();
            }
        }

        private void aContextMenuStripItemGrid_Click(object sender, EventArgs e)
        {
            if (aContextMenuStripItemGrid.Checked == false)
            {
                aToolStripGrid.Checked = false;
                mDrawGridLines = false;
                aGraphicsPanel.Refresh();
            }
            else if (aContextMenuStripItemGrid.Checked == true)
            {
                aToolStripGrid.Checked = true;
                mDrawGridLines = true;
                aGraphicsPanel.Refresh();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsDialog dlg = new OptionsDialog();

            dlg.BackgroundColor = aGraphicsPanel.BackColor;
            dlg.GridColor = mGridColor;
            dlg.LiveCellColor = mCellColor;
            dlg.GridWidth = mWidth;
            dlg.GridHeight = mHeight;
            dlg.TimeInterval = mTimer.Interval;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                mGridColor = dlg.GridColor;
                mCellColor = dlg.LiveCellColor;
                aGraphicsPanel.BackColor = dlg.BackgroundColor;
                mWidth = dlg.GridWidth;
                mHeight = dlg.GridHeight;
                mUniverse = new bool[mWidth, mHeight];
                mTimer.Interval = dlg.TimeInterval;
            }

            aGraphicsPanel.Refresh();
        }

        private void fromNewSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rando = new Random();

            int mRandomSeed = rando.Next(100000000, 1000000000);

            RandomizeBySeed dlg = new RandomizeBySeed();

            dlg.RandomizeSeed = mRandomSeed;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                mRandomSeed = dlg.RandomizeSeed;

                mUniverse = new bool[mWidth, mHeight];
                for (int y = 0; y < mUniverse.GetLength(1); y++)
                {
                    for (int x = 0; x < mUniverse.GetLength(0); x++)
                    {
                        if (mRandomSeed % 3 == 0)
                        {
                            mUniverse[x, y] = true;
                        }
                    }
                }
            }

            aGraphicsPanel.Refresh();
        }

        private void fromCurrentSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fromTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
