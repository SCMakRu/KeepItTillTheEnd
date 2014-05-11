using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeItTillYouMakeIt
{
    [Serializable]
    public class StarDoc
    {
        public List<Star> stars;
     
        public StarDoc()
        {
            stars = new List<Star>();
        }

        public void DrawStars(Graphics g)
        {
            foreach(Star s in stars)
            {
                s.DrawStarImage(g);
            }
        }

     

        public void AddStar(int x, int y, int num)
        {
            Star s = new Star(x, y, num);
            stars.Add(s);
        }
    }
}
