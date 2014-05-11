using FakeItTillYouMakeIt.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeItTillYouMakeIt
{
    public class Robot
    {
        public enum DIRECTION
        {
            RIGHT,
            LEFT,
            DOWN,
            UP
        }

        public DIRECTION Direction { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Image robotImg { get; set; }
      //  public Image robotImgLeft { get; set; }
     //  public Image robotImgRight { get; set; }
        public int poeni { get; set; }
        public Plane plane { get; set; }

        public Robot(int x, int y)
        {
            X = x;
            Y = y;
            Direction = DIRECTION.UP;
            robotImg = Resources.PSgreenrobotFinal;
           // robotImgLeft = Resources.PSgreenrobotLeft;

        }

        public void DrawRobot(Graphics g)
        {            
          //  MemoryStream ms = new MemoryStream(File.ReadAllBytes(robotImg));
            //Image img = Image.FromStream(ms);
            if (Direction == DIRECTION.LEFT)
            {
                robotImg = Resources.GR;
            }
            else if (Direction == DIRECTION.RIGHT)
            {
                robotImg = Resources.GL;
            }
            else
            robotImg = Resources.PSgreenrobotFinal;

            g.DrawImage(robotImg, X, Y);
        }

        public void ChangeDirection(DIRECTION direction)
        {
            Direction = direction;

          /*  if (Direction == DIRECTION.LEFT)
            {
                robotImg = Resources.PSgrL;

            }
            else
            {
                robotImg = Resources.PSgrL;

            }*/
        }

        public void MoveRobot(int width, int height)
        {
            if (Direction == DIRECTION.RIGHT)
            {
                X += 10;
                if (X >= width-90)
                {
                    X = width - 90;
                }
            }
            if (Direction == DIRECTION.LEFT)
            {               
                X -= 8;
                if (X < 0)
                {
                    X = 0;
                }
            }
            if (Direction == DIRECTION.UP)
            {
                Y -= 8;
                if (Y < 0)
                {
                    Y = 0;
                }
            }
            if (Direction == DIRECTION.DOWN)
            {
                Y += 10;
                if (Y >= height - height / 3 - 30)
                {
                    Y = height - height / 3 - 30; ;
                }
            }
        }

        public void planeRobotCrash()
        {
          //  if(plane.X+100>=X && plane.Y+100>=Y)
        }

        
    }
}
