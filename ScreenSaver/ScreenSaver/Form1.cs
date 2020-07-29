using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSaver
{
    public partial class Form1 : Form
    {
        List<Image> pics = new List<Image>();
        List<posi> posipics = new List<posi>();
        Random rand = new Random();
     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] images = System.IO.Directory.GetFiles("pics");

            foreach (string image in images)
            {
                pics.Add(new Bitmap(image));
            }
            for (int i = 0; i < 10; i++)
            {
                posi po = new posi();
                po.picno = i % pics.Count;
                po.posX = rand.Next(0,Width);
                po.posY = rand.Next(0,Height);

                posipics.Add(po);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach  (posi pos in posipics)
            {
                e.Graphics.DrawImage(pics[pos.picno],0, 0);
                pos.posX += 2;
      
            }
        }
    }
}
