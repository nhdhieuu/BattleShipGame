using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame.Models
{
    internal class Ship
    {
        public Point p;
        public int height, width;
        public Ship(int x, int y, int he, int wi)
        {
            p.X = x; p.Y = y;
            this.height = he;
            this.width = wi;
        }
        public void SetShip(int x, int y, int he, int wi)
        {
            p.X = x; p.Y = y;
            this.height = he;
            this.width = wi;
        }

        public void Move(int x, int y)
        {
            this.p.X += x;
            this.p.Y += y;
        }
    }
}
