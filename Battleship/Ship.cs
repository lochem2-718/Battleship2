using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Ship
    {
        int health;
        char direction;
        int length;
        int x;
        int y;
        public Ship(int x, int y, char direction)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
        }
    }
}
