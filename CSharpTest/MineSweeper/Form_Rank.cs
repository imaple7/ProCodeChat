﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form_Rank : Form
    {
        public Form_Rank()
        {
            InitializeComponent();
        }

        private void Form_Rank_Load(object sender, EventArgs e)
        {
            //Load Data
            int nBeginner = Properties.Settings.Default.Beginner;
            int nIntermediate = Properties.Settings.Default.Intermediate;
            int nExpert = Properties.Settings.Default.Expert;

            //Show Data
            Label_Beginner.Text = String.Format("Beginner:         {0}", nBeginner);
            Label_Intermediate.Text = String.Format("Intermediate:     {0}", nIntermediate);
            Label_Expert.Text = String.Format("Expert:           {0}", nExpert);
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            this.Close(); //Exit the current window
        }

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Beginner = 999;
            Properties.Settings.Default.Intermediate = 999;
            Properties.Settings.Default.Expert = 999;
            Properties.Settings.Default.Save(); //Save the changes
        }
    }
}
