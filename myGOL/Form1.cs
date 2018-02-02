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
        bool[,] mUniverse = new bool[20, 20];

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
            mTimer.Interval = 200;
            //mTimer.Enabled = true;
            mTimer.Tick += MTimer_Tick;

            this.Text = Properties.Resources.AppTitle;
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
            bool[,] mScratchPad = new bool[20, 20];

            //Create the Next Generation
            GenerationStatus();
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

                    //Outline the Cell With a Pen
                    e.Graphics.DrawRectangle(mGridPen, mCellRect.X, mCellRect.Y, mCellRect.Width, mCellRect.Height);

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

            mTimer.Stop();
            mGenerations = 0;
            GenerationStatus();
            aGraphicsPanel.Invalidate();
        }

        private void GenerationStatus()
        {
            aStripStatusGenerations.Text = "Generations: " + mGenerations.ToString();

        }

        private void aStripButtonPause_Click(object sender, EventArgs e)
        {
            mTimer.Stop();
        }

        private void aStripButtonNext_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void aStripButtonPlay_Click(object sender, EventArgs e)
        {
            mTimer.Start();
        }


    }
}
