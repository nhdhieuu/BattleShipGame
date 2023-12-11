using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace BattleShipGame.Models
{
    internal class Exploding
    {
        public int x, y;
        public int r;
        public bool isShip = false;
        public int indexE = 0;
        public Exploding(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }


    }
}
