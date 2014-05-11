using FakeItTillYouMakeIt.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeItTillYouMakeIt
{
    public class Weapon
    {
        public Image weaponImg { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int imgWeaponWidth { get; set; }
        public int imgWeaponHeight { get; set; }

        public Weapon(int x, int y)
        {
            X = x;
            Y = y;
            weaponImg = Resources.PSvortex2;
            imgWeaponWidth = weaponImg.Width;
            imgWeaponHeight = weaponImg.Height;
        }

        public void DrawWeapon(Graphics g)
        {
            weaponImg = Resources.PSvortex2;
            g.DrawImage(weaponImg, X-imgWeaponWidth/2, Y-imgWeaponHeight/2);            
        }

        public void Move()
        {
            X -= 5;
        }
    }
}
