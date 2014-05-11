using FakeItTillYouMakeIt.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeItTillYouMakeIt
{
   public class Vortex
    {
        public int X { get; set; }
        public int Y { get; set; }       
        public Image vortexImg{get;set;}
        public int alive { get; set; }
        public static Rectangle Bounds;

        public Vortex(int x, int y)
        {
            vortexImg = Resources.PSvortex;
            X = x;
            Y = y;
            alive = 0;         
        }

        public void DrawImage(Graphics g, int width, int height)
        {
            if (X <= width - vortexImg.Width-122 && Y <= height - vortexImg.Height-30)
            {
                vortexImg = Resources.PSvortex;
                g.DrawImage(vortexImg, X, Y);
            }
        }
    }
}
