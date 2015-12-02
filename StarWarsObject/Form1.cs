using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarsObject
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Explosion(0, 0, 100);
        }
        /// <>
        /// Draws a Explosion at any given x and y cordinate with its gve size in pixels
        /// </summary>
        /// <param name="x"> the x coridinate of the where to draw the explosion </param>
        /// <param name="y"> the y cordinate of the </param>
        /// <param name="pixels"> the size of the explosion in pixels</param>
        public void Explosion(float x, float y, float pixels)
        {
            Pen exPen = new Pen(Color.Red, 10);  //create pen to make lines/shapes
            SolidBrush exbrush = new SolidBrush(Color.Yellow); //make brush to fill ellipse
            float scale = pixels / 100;   //to make a multiplyer for x and y values to change size

            // Draw and Scale Explosion 
            g.FillEllipse(exbrush, 0 * scale + x, 0 * scale + y, 100 * scale, 100 * scale);
            g.DrawLine(exPen, scale * 15 + x, scale * 15 + y, scale * 85 + x, scale * 85 + y);
            g.DrawLine(exPen, scale * 85 + x, scale * 15 + y, scale * 15 + x, scale * 85 + y);
            g.DrawLine(exPen, scale * 50 + x, scale * 0 + y, scale * 50 + x, scale * 100 + y);
            g.DrawLine(exPen, scale * 0 + x, scale * 50 + y, scale * 100 + x, scale * 50 + y);

            //Make explosion flash
            Random randNum = new Random();
            int counter2 = 0;
            while (counter2 <= 11)
            {
                counter2++;
                int rVal = randNum.Next(0, 256);
                int gVal = randNum.Next(0, 256);
                int bVal = randNum.Next(0, 256);

                exPen.Color = Color.FromArgb(rVal, gVal, bVal);

                //make lines using random colours
                g.FillEllipse(exbrush, 0 * scale + x, 0 * scale + y, 100 * scale, 100 * scale);
                g.DrawLine(exPen, scale * 15 + x, scale * 15 + y, scale * 85 + x, scale * 85 + y);
                g.DrawLine(exPen, scale * 85 + x, scale * 15 + y, scale * 15 + x, scale * 85 + y);
                g.DrawLine(exPen, scale * 50 + x, scale * 0 + y, scale * 50 + x, scale * 100 + y);
                g.DrawLine(exPen, scale * 0 + x, scale * 50 + y, scale * 100 + x, scale * 50 + y);

            }
        }
    }
}
