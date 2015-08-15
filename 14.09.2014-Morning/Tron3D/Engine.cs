using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron3D
{
    class Engine
    {
        public static void PrintingResults(bool redLoss, bool blueLoss, int cycle )
        {
            if (redLoss == true && blueLoss == false)
            {
                Console.WriteLine("BLUE");
                Console.WriteLine("{0}", cycle);
                return;
            }
            else if (redLoss == false && blueLoss == true)
            {
                Console.WriteLine("BLUE");
                Console.WriteLine("{0}", cycle);
                return;
            }
            else if (redLoss == true && blueLoss == true)
            {
                Console.WriteLine("DRAW");
                Console.WriteLine("{0}", cycle);
                return;
            }
        }

        public static int[,,] CreatingGrid(int x, int y, int z)
        {
            return new int[x, y, z];
        }

        static void Main(string[] args)
        {
            string inputDimensions = "8 4 6";
            string inputRedMovement = "MMLMMMMRMRMMLMMRMMRMLMMRMMRMLMMLMMMLMMM";
            string inputBlueMovement = "LMMMMRMRMMMLMMRMMMMLMLMMMMRMLMMRMMMMRMM";
            string[] arrayOfDimensions = inputDimensions.Split(new char[] {' '});
            int X = int.Parse(arrayOfDimensions[0]) + 1;
            int Y = int.Parse(arrayOfDimensions[1]) + 1;
            int Z = int.Parse(arrayOfDimensions[2]) + 1;
            int[, ,] grid = CreatingGrid(X, Y, Z);

            bool redRight = true;
            bool redLeft = false;
            bool redUp = false;
            bool redDown = false;
            bool redLoss = false;
            bool blueLoss = false;
            bool blueRight = false;
            bool blueLeft = true;
            bool blueUp = false;
            bool blueDown = false;

            int redX = X / 2;
            int redY = Y / 2;
            int redZ = 0;
            int blueX = X / 2;
            int blueY = Y / 2;
            int blueZ = Z - 1;



            for (int movingCycles = 0; movingCycles < inputDimensions.Length; movingCycles++)
            {
                if (inputRedMovement[movingCycles] == 'M')
                {
                    if (redRight == true)
                    {
                        if (redZ == 0 && redY >= 0 && redY < Y - 1 )
                        {
                            redY++;
                        }
                        else if (redY == Y - 1 && redZ >= 0 && redZ < Z - 1)
                        {
                            redZ++;
                        }
                        else if (redZ == Z - 1 && redY >= 0 && redY < Y - 1)
                        {
                            redY--;
                        }
                        else if (redY == 0 && redZ >= 0 && redZ < Z - 1)
                        {
                            redZ--;
                        }
                    }
                    else if (redLeft == true)
                    {
                        if (redZ == 0 && redY >= 0 && redY < Y - 1)
                        {
                            redY--;
                        }
                        else if (redY == Y - 1 && redZ >= 0 && redZ < Z - 1)
                        {
                            redZ--;
                        }
                        else if (redZ == Z - 1 && redY >= 0 && redY < Y - 1)
                        {
                            redY++;
                        }
                        else if (redY == 0 && redZ >= 0 && redZ < Z - 1)
                        {
                            redZ++;
                        }
                    }
                    else if (redUp == true)
                    {
                        redX--;
                    }
                    else if (redDown == true)
                    {
                        redX++;
                    }

                    if ((redX == 0 || redX == X - 1) && (redY > 0 || redY < X - 1) && (redZ > 0 || redZ < Z - 1))
                    {
                        redLoss = true;
                    }
                    else if (grid[redX, redY, redZ] == 2)
                    {
                        redLoss = true;
                    }

                    grid[redX, redY, redZ] = 1;
                }
                else if (inputRedMovement[movingCycles] == 'L' && redRight == true && redLeft == false && redUp == false && redDown == false)
                {
                    redRight = false;
                    redLeft = false;
                    redUp = true;
                    redDown = false;
                }
                else if (inputRedMovement[movingCycles] == 'L' && redRight == false && redLeft == false && redUp == true && redDown == false)
                {
                    redRight = false;
                    redLeft = true;
                    redUp = false;
                    redDown = false;
                }
                else if (inputRedMovement[movingCycles] == 'L' && redRight == false && redLeft == true && redUp == false && redDown == false)
                {
                    redRight = false;
                    redLeft = false;
                    redUp = false;
                    redDown = true;
                }
                else if (inputRedMovement[movingCycles] == 'L' && redRight == false && redLeft == false && redUp == false && redDown == true)
                {
                    redRight = true;
                    redLeft = false;
                    redUp = false;
                    redDown = false;
                }
                else if (inputRedMovement[movingCycles] == 'R' && redRight == true && redLeft == false && redUp == false && redDown == false)
                {
                    redRight = false;
                    redLeft = false;
                    redUp = false;
                    redDown = true;
                }
                else if (inputRedMovement[movingCycles] == 'R' && redRight == false && redLeft == false && redUp == false && redDown == true)
                {
                    redRight = false;
                    redLeft = true;
                    redUp = false;
                    redDown = false;
                }
                else if (inputRedMovement[movingCycles] == 'R' && redRight == false && redLeft == true && redUp == false && redDown == false)
                {
                    redRight = false;
                    redLeft = false;
                    redUp = true;
                    redDown = false;
                }
                else if (inputRedMovement[movingCycles] == 'R' && redRight == false && redLeft == false && redUp == true && redDown == false)
                {
                    redRight = true;
                    redLeft = false;
                    redUp = false;
                    redDown = false;
                }

                if (inputBlueMovement[movingCycles] == 'M')
                {
                    if (blueLeft == true)
                    {
                        if (blueZ == 0 && blueY >= 0 && blueY < Y - 1)
                        {
                            blueY++;
                        }
                        else if (blueY == Y - 1 && blueZ >= 0 && blueZ < Z - 1)
                        {
                            blueZ++;
                        }
                        else if (blueZ == Z - 1 && blueY >= 0 && blueY < Y - 1)
                        {
                            blueY--;
                        }
                        else if (blueY == 0 && blueZ >= 0 && blueZ < Z - 1)
                        {
                            blueZ--;
                        }
                    }
                    else if (blueLeft == true)
                    {
                        if (blueZ == 0 && blueY >= 0 && blueY < Y - 1)
                        {
                            blueY--;
                        }
                        else if (blueY == Y - 1 && blueZ >= 0 && blueZ < Z - 1)
                        {
                            blueZ--;
                        }
                        else if (blueZ == Z - 1 && blueY >= 0 && blueY < Y - 1)
                        {
                            blueY++;
                        }
                        else if (blueY == 0 && blueZ >= 0 && blueZ < Z - 1)
                        {
                            blueZ++;
                        }
                    }
                    else if (blueUp == true)
                    {
                        blueX--;
                    }
                    else if (blueDown == true)
                    {
                        blueX++;
                    }

                    if ((blueX == 0 || blueX == X - 1) && (blueY > 0 || blueY < X - 1) && (blueZ > 0 || blueZ < Z - 1))
                    {
                        blueLoss = true;
                    }
                    else if (grid[blueX, blueY, blueZ] == 1)
                    {
                        blueLoss = true;
                    }

                    grid[blueX, blueY, blueZ] = 2;
                }
                else if (inputBlueMovement[movingCycles] == 'L' && blueRight == true && blueLeft == false && blueUp == false && blueDown == false)
                {
                    blueRight = false;
                    blueLeft = false;
                    blueUp = true;
                    blueDown = false;
                }
                else if (inputBlueMovement[movingCycles] == 'L' && blueRight == false && blueLeft == false && blueUp == true && blueDown == false)
                {
                    blueRight = false;
                    blueLeft = true;
                    blueUp = false;
                    blueDown = false;
                }
                else if (inputBlueMovement[movingCycles] == 'L' && blueRight == false && blueLeft == true && blueUp == false && blueDown == false)
                {
                    blueRight = false;
                    blueLeft = false;
                    blueUp = false;
                    blueDown = true;
                }
                else if (inputBlueMovement[movingCycles] == 'L' && blueRight == false && blueLeft == false && blueUp == false && blueDown == true)
                {
                    blueRight = true;
                    blueLeft = false;
                    blueUp = false;
                    blueDown = false;
                }
                else if (inputBlueMovement[movingCycles] == 'R' && blueRight == true && blueLeft == false && blueUp == false && blueDown == false)
                {
                    blueRight = false;
                    blueLeft = false;
                    blueUp = false;
                    blueDown = true;
                }
                else if (inputBlueMovement[movingCycles] == 'R' && blueRight == false && blueLeft == false && blueUp == false && blueDown == true)
                {
                    blueRight = false;
                    blueLeft = true;
                    blueUp = false;
                    blueDown = false;
                }
                else if (inputBlueMovement[movingCycles] == 'R' && blueRight == false && blueLeft == true && blueUp == false && blueDown == false)
                {
                    blueRight = false;
                    blueLeft = false;
                    blueUp = true;
                    blueDown = false;
                }
                else if (inputBlueMovement[movingCycles] == 'R' && blueRight == false && blueLeft == false && blueUp == true && blueDown == false)
                {
                    blueRight = true;
                    blueLeft = false;
                    blueUp = false;
                    blueDown = false;
                }

                PrintingResults(redLoss, blueLoss, movingCycles);
            }
        }
    }
}
