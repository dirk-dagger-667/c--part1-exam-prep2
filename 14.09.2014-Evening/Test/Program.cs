using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        public static void MovingThePlayer(bool right, bool left, bool up, bool down, int x, int y, int z, int limitX, int limitY, int limitZ)
        {
            if (right == true)
            {
                if (z == 0 && y >= 0 && y < limitY - 1)
                {
                     y++;
                }
                else if (y == limitY - 1 && z >= 0 && z < limitZ - 1)
                {
                    z++;
                }
                else if (z == limitZ - 1 && y >= 0 && y < limitY - 1)
                {
                    y--;
                }
                else if (y == 0 && z >= 0 && z < limitZ - 1)
                {
                    z--;
                }
            }
            else if (left == true)
            {
                if (z == 0 && y >= 0 && y < limitY - 1)
                {
                    y--;
                }
                else if (y == limitY - 1 && z >= 0 && z < limitZ - 1)
                {
                    z--;
                }
                else if (z == limitZ - 1 && y >= 0 && y < limitY - 1)
                {
                    y++;
                }
                else if (y == 0 && z >= 0 && z < limitZ - 1)
                {
                    z++;
                }
            }
            else if (up == true)
            {
                x--;
            }
            else if (down == true)
            {
                x++;
            }
        }

        static void Main(string[] args)
        {
            int x = 100;
            int y = 100;
            int z = 0;
            int limitX = 1000;
            int limitY = 1000;
            int limitZ = 1000;

            MovingThePlayer(true, false, false, false, x, y, z, limitX, limitY, limitZ);
        }
    }
}
