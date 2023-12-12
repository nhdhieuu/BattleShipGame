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
        public Enemy(int px, int py,int _width,int _height)
        {
            this.p.X = px;
            this.p.Y = py;
            this.width = _width;
            this.height = _height;
            this.speed = 10;
        }
    }
}
