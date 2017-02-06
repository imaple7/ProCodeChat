using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MineSweeper
{
    public partial class Form_Main : Form
    {
        const int MAX_WIDTH = 64; //Max width of mine fields
        const int MAX_HEIGHT = 32; //MAX height of mine fields

        public int nWidth; //Numbers of mine fields in Horizontal
        public int nHeight; //Numbers of mine fields in Vertical
        public int nMineCnt; //Total numbers of mine fields

        bool bMark;
        bool bAudio;

        int[,] pMine = new int[MAX_WIDTH, MAX_HEIGHT]; //-1 is mine, 0-8 is nearby mines
        int[,] pState = new int[MAX_WIDTH, MAX_HEIGHT]; //0 is unopened, 1 is opened, 2 is flaged, 3 is marked

        public Form_Main()
        {
            InitializeComponent();

            //Initial game parameters
            nWidth = Properties.Settings.Default.Wdith;
            nHeight = Properties.Settings.Default.Height;
            nMineCnt = Properties.Settings.Default.MineCnt;

            //Initial Mark and Audio Functionality
            bMark = Properties.Settings.Default.Mark;
            bMark = Properties.Settings.Default.Audio;
            markMToolStripMenuItem.Checked = bMark;
            audioAToolStripMenuItem.Checked = bAudio;

            UpdateSize();
            SelectLevel();
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
        /// Draw Form Content
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_Paint(object sender, PaintEventArgs e)
        {
            PaintGame();
        }

        /// <summary>
        /// Draw Mine Game Area
        /// </summary>
        private void PaintGame()
        {
            Graphics g = this.CreateGraphics(); //Create Graphics Handler
            g.FillRectangle(Brushes.White, new Rectangle(0, 0, this.Width, this.Height));

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
            PaintGame();
        }

        /// <summary>
        /// Select difficulty level
        /// </summary>
        private void SelectLevel()
        {
            if (nWidth == 10 && nHeight == 10 && nMineCnt == 10)
            {
                beginnerBToolStripMenuItem.Checked = true;
                intermediateIToolStripMenuItem.Checked = false;
                expertEToolStripMenuItem.Checked = false;
                settingSToolStripMenuItem.Checked = false;
            }
            else if (nWidth == 16 && nHeight == 16 && nMineCnt == 40)
            {
                beginnerBToolStripMenuItem.Checked = false;
                intermediateIToolStripMenuItem.Checked = true;
                expertEToolStripMenuItem.Checked = false;
                settingSToolStripMenuItem.Checked = false;
            }
            else if (nWidth == 30 && nHeight == 16 && nMineCnt == 99)
            {
                beginnerBToolStripMenuItem.Checked = false;
                intermediateIToolStripMenuItem.Checked = false;
                expertEToolStripMenuItem.Checked = true;
                settingSToolStripMenuItem.Checked = false;
            }
            else
            {
                beginnerBToolStripMenuItem.Checked = false;
                intermediateIToolStripMenuItem.Checked = false;
                expertEToolStripMenuItem.Checked = false;
                settingSToolStripMenuItem.Checked = true;
            }
        }

        private void beginnerBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nWidth = 10;
            nHeight = 10;
            nMineCnt = 10;
            SelectLevel();
            UpdateSize();
        }

        private void intermediateIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nWidth = 16;
            nHeight = 16;
            nMineCnt = 40;
            SelectLevel();
            UpdateSize();
        }

        private void expertEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nWidth = 30;
            nHeight = 16;
            nMineCnt = 99;
            SelectLevel();
            UpdateSize();
        }

        private void exitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit the game?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// System About window
        /// </summary>
        /// <param name="hWnd">Handler of window</param>
        /// <param name="szApp">Title</param>
        /// <param name="szOtherStuff">Content</param>
        /// <param name="hIcon">Handler of Icon</param>
        /// <returns></returns>
        [DllImport("shell32.dll")]
        public extern static int ShellAbout(IntPtr hWnd, string szApp, string szOtherStuff, IntPtr hIcon);

        /// <summary>
        /// About Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShellAbout(this.Handle, "Minesweeper", "A minesweeper game using CSharp language.", this.Icon.Handle);
        }

        private void markMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            markMToolStripMenuItem.Checked = bMark = !bMark;
        }

        private void audioAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            audioAToolStripMenuItem.Checked = bAudio = !bAudio;
        }

        private void settingSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Setting Setting = new Form_Setting(this);
            Setting.ShowDialog();
            UpdateSize();
        }

        private void rankRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Rank Rank = new Form_Rank();
            Rank.ShowDialog();
        }

        private void newGameNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sweep two arrays
            Array.Clear(pMine, 0, pMine.Length);
            Array.Clear(pState, 0, pState.Length);

            //Initial mine data
            Random rand = new Random();

        }

    }

}
