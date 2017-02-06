using System;
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
    public partial class Form_Setting : Form
    {
        Form_Main Main;

        public Form_Setting(Form_Main _Main)
        {
            InitializeComponent();

            Main = _Main; //Get parent instance
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close(); //Exit the current window
        }

        private void Botton_OK_Click(object sender, EventArgs e)
        {
            //Update data to the main form
            Main.nWidth = Convert.ToInt32(NumericUpDown_Width.Value);
            Main.nHeight = Convert.ToInt32(NumericUpDown_Height.Value);
            Main.nMineCnt = Convert.ToInt32(NumericUpDown_Mine.Value);

            this.Close(); //Close the current window
        }

        private void Form_Setting_Load(object sender, EventArgs e)
        {
            //Get the current data from main form
            NumericUpDown_Width.Value = Convert.ToDecimal(Main.nWidth);
            NumericUpDown_Height.Value = Convert.ToDecimal(Main.nHeight);
            NumericUpDown_Mine.Value = Convert.ToDecimal(Main.nMineCnt);
        }

    }
}
