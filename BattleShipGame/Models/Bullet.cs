using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame.Models
{
    internal class Bullet
    {
        public Image bImage;
        public Point p;
        public int height, width;
        public int speed;
        public Bullet(int px, int py)
        {
            this.p.X = px;
            this.p.Y = py;
            this.width = 20;
            this.height = 20;
            this.speed = 20;

        }
        public void move()
        {
            this.p.Y += speed;
        }
    }
}
