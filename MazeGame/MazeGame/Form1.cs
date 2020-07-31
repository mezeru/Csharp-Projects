using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {  private int a = 0;
        public Form1()
        {
            InitializeComponent();
            s();
        }

      

        private void label34_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Win !! \nYou did it on your "+ a +" try" );
            Close();
        }

        private void s()
        {
            Point stpt = panel1.Location;
            stpt.Offset(10,10);
            Cursor.Position = PointToScreen(stpt);
            Tries.Text = a++.ToString();
        }

        private void s(object sender, EventArgs e)
        {
            s();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }
    }
}
