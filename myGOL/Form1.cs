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
        //The Universe Array
        bool[,] mUniverse = new bool[10, 10];
        bool[,] mScratchPad = new bool[10, 10];

        //Drawing Colors
        Color mGridColor = Color.Azure;
        Color mCellColor = Color.Gray;

        //The Timer Class
        Timer mTimer = new Timer();

        //Generation Count
        int mGenerations = 0;

        public Form1()
        {
            InitializeComponent();

            //Set Timer
            mTimer.Interval = 20;
            mTimer.Enabled = true;
            mTimer.Tick += MTimer_Tick;
        }

        private void MTimer_Tick(object sender, EventArgs e)
        {
            NextGeneration();

            aGraphicsPanel.Invalidate();
        }

        private int CountNeighbors(bool[,] universe, int x, int y)
        {
            int mNeighborCount = 0;

            //if (universe[x,y] == true && universe[x,y-1] == true && y-1 >= 0)
            //{
            //    mNeighborCount++;
            //}
            //if (universe[x,y] == true && universe[x+1, y-1] == true && x+1 < universe.GetLength(0) && y-1 >= 0)
            //{
            //    mNeighborCount++;
            //}
            //if (universe[x,y] == true && universe[x+1,y] == true && x+1 < universe.GetLength(0))
            //{
            //    mNeighborCount++;
            //}
            //if (universe[x,y] == true && universe[x, y+1] == true && y+1 <universe.GetLength(1))
            //{
            //    mNeighborCount++;
            //}
            //if (universe[x,y] == true && universe[x-1,y-1] == true && x-1 >= 0 && y-1 >= 0)
            //{
            //    mNeighborCount++;
            //}
            //if (universe[x,y] == true && universe[x+1,y+1] == true && x+1 < universe.GetLength(0) && y+1 < universe.GetLength(1))
            //{
            //    mNeighborCount++;
            //}
            //if (universe[x,y] == true && universe[x-1,y] == true && x-1 >= 0)
            //{
            //    mNeighborCount++;
            //}
            //if (universe[x,y] == true && universe[x-1,y+1] == true && x-1 >= 0 && y+1 < universe.GetLength(1))
            //{
            //    mNeighborCount++;
            //}

            //for (int a = -1; a <= 1; y++)
            //{
            //    for (int b = -1; b <= 1; b++)
            //    {
            //        if (universe[x,y] == true && universe[x+b,y+a] == true)
            //        {
            //            mNeighborCount++;
            //        }
            //    }
            //}

            return mNeighborCount;
        }

        private void NextGeneration()
        {
            //Create the Next Generation
            mGenerations++;

            aStripStatusGenerations.Text = "Generations: " + mGenerations.ToString();

            //Iterate Through the Universe in the Y, Top to Bottom
            for (int y = 0; y < mUniverse.GetLength(1); y++)
            {
                //Iterate Through the Universe in the X, Left to Right
                for (int x = 0; x < mUniverse.GetLength(0); x++)
                {

                }
            }
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

            //Iterate Through the Universe in the Y, Top to Bottom
            for(int y = 0; y < mUniverse.GetLength(1); y++)
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

                    //Outline the Cell With a Pen
                    e.Graphics.DrawRectangle(mGridPen, mCellRect.X, mCellRect.Y, mCellRect.Width, mCellRect.Height);
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

            mGenerations = 0;

            aGraphicsPanel.Invalidate();
        }
    }
}
