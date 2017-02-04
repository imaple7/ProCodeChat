using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form_Main : Form
    {
        int nWidth; //Numbers of mine fields in Horizontal
        int nHeight; //Numbers of mine fields in Vertical
        int nMineCnt; //Total numbers of mine fields

        public Form_Main()
        {
            InitializeComponent();

            //Initial game parameters
            nWidth = Properties.Settings.Default.Wdith;
            nHeight = Properties.Settings.Default.Height;
            nMineCnt = Properties.Settings.Default.MineCnt;
            UpdateSize();
        }

        /// <summary>
        /// Set up the basic parameters of the game
        /// </summary>
        /// <param name="Width">Numbers of mine fields in Horizontal</param>
        /// <param name="Height">Numbers of mine fields in Vertical</param>
        /// <param name="MineCnt">Total numbers of mine field</param>
        private void SetGame(int Width, int Height, int MineCnt)
        {
            nWidth = Width;
            nHeight = Height;
            nMineCnt = MineCnt;

            UpdateSize(); //Update window's size based on the numbers of width
        }

        /// <summary>
        /// Set the difficulty to beginner
        /// </summary>
        private void SetGameBeginner()
        {
            SetGame(10, 10, 10);
        }

        /// <summary>
        /// Set the difficulty to intermediate
        /// </summary>
        private void SetGameIntermediate()
        {
            SetGame(16, 16, 40);
        }

        /// <summary>
        /// Set the difficulty to expert
        /// </summary>
        private void SetGameExpert()
        {
            SetGame(30, 16, 99);
        }

        /// <summary>
        /// Draw Mine field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics(); //Create Graphics Handler

            //We need 6px around minefield to make that looks perfect
            int nOffsetX = 6; //Offset of x
            int nOffsetY = 6 + MenuStrip_Main.Height; //OffSet of Y

            //Draw Rows
            for (int i = 1; i <= nWidth; i++)
            {
                //Draw Column
                for (int j = 1; j <= nHeight; j++)
                {
                    g.FillRectangle(Brushes.SandyBrown, new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                }
            }
        }

        /// <summary>
        /// Automatically update windows size
        /// </summary>
        private void UpdateSize()
        {
            int nOffsetX = this.Width - this.ClientSize.Width; //Include width title and top and bottom edge
            int nOffsetY = this.Height - this.ClientSize.Height; //Include width of left and right edge
            int nAdditionY = MenuStrip_Main.Height + TableLayoutPanel_Main.Height; //Include height of Menu strip and Information lable
            this.Width = 12 + 34 * nWidth + nOffsetX; //Set width of window
            this.Height = 12 + 34 * nHeight + nAdditionY + nOffsetY; //Set height of window
        }

    }
}
