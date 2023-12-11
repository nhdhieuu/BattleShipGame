using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame.Models
{
    internal class Enemy
    {
        public Point p;
        public Image eImage;
        public int width, height;
        public int speed;
        public Enemy(int px, int py)
        {
            this.p.X = px;
            this.p.Y = py;

        }
    }
}
