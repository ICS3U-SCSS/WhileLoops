using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WhileLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void starButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            int counter, numStars;

            g.Clear(Color.Black);
            numStars = Convert.ToInt16(starInput.Text);

            //initialize
            counter = 1;

            //test
            while (counter <= numStars)
            {
                //act
                g.FillEllipse(drawBrush, 20 * counter, 50, 20, 20);

                //change
                counter = counter + 1;
            }
        }

        private void moveButton_Click(object sender, EventArgs e)
        {          
            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            //initialize
            int x = 0;
            int y = 150; 		    
            
            //test
            while (x < this.Width-20)	
            {
                //act
                g.Clear(Color.Black);
                g.FillRectangle(drawBrush, x, y, 10, 10);
                Thread.Sleep(5);
                
                //change
                x++;
            }
        }

        private void growButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            //initialize
            int pixels = 1;
          	    
            //test
            while (pixels < 50)	
            {
                //act
                g.Clear(Color.Black);
                g.FillRectangle(drawBrush, 50, 150, 50 + pixels, 50 + pixels);
            
                Thread.Sleep(5);

                //change
                pixels++;	
            }
        }

        private void fadeButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            //initialize
            int rgbVal = 1;

            //test
            while (rgbVal < 256)
            {
                //act
                drawBrush.Color = Color.FromArgb(0 , 0 , 0 + rgbVal);

                g.Clear(Color.Black);
                g.FillRectangle(drawBrush, 50, 150, 50, 50);

                Thread.Sleep(10);

                //change
                rgbVal++;
            }
        }
    }
}
