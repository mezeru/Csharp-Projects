using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingForms
{
    public partial class Form1 : Form
    {
        Label cos1 = null, cos2 = null;
        Random rand = new Random();
        List<string> icons = new List<string>()
        {
            "e","f","g","h","i","j","k","l","e","f","g","h","i","j","k","l"
        };

        public Form1()
        {
            InitializeComponent();
            randassign();
        }

        private void randassign()
        {
            foreach (Control C in tableLayoutPanel1.Controls)
            {
                Label Icon = C as Label;
                if (Icon != null)
                {
                    int a = rand.Next(icons.Count);
                    Icon.Text = icons[a];
                    Icon.ForeColor = Icon.BackColor;
                    icons.RemoveAt(a);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void visi(object sender, EventArgs e)
        {
            Label icon = sender as Label;
            if (icon != null && icon.ForeColor == icon.BackColor && timer1.Enabled == false)
            {

                if (cos1 == null)
                {
                    cos1 = icon;
                    icon.ForeColor = Color.White;
                }
                else if (cos2 == null && cos1 != null)
                {
                    cos2 = icon;
                    icon.ForeColor = Color.White;
                    if (cos1.Text != cos2.Text)
                    {
                        timer1.Start();
                        check();
                    }
                    else
                    {
                        cos1 = null;
                        cos2 = null;
                        check();
                    }
                        

                }
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            
            
                cos1.ForeColor = cos1.BackColor;
                cos2.ForeColor = cos2.BackColor;
            
            cos1 = null;
            cos2 = null;

        }

        private void check()
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                Label icon = c as Label;
                if (icon != null)
                {
                    if (icon.ForeColor == icon.BackColor)
                    {
                        return;
                    }
                }

            }
            
            MessageBox.Show("Congo , You Won !!");
            Close();
                

            
        }
    }
}
