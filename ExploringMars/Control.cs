using System;
using System.Collections.Generic;
using System.Text;

namespace ExploringMars
{
    public static class Control
    {
        public static string ControlProbe((int X, int Y) spaceLimit, (int X, int Y, char direction) positionProbe, string pathProbe)
        {
            foreach (char move in pathProbe)
            {
                if (move == 'M')
                {
                    if (positionProbe.direction == 'N')
                        positionProbe.Y += 1;
                    else if (positionProbe.direction == 'S')
                        positionProbe.Y -= 1;
                    else if (positionProbe.direction == 'E')
                        positionProbe.X += 1;
                    else if (positionProbe.direction == 'W')
                        positionProbe.X -= 1;
                }

                if (move == 'L')
                {
                    if (positionProbe.direction == 'N')
                        positionProbe.direction = 'W';
                    else if (positionProbe.direction == 'W')
                        positionProbe.direction = 'S';
                    else if (positionProbe.direction == 'S')
                        positionProbe.direction = 'E';
                    else if (positionProbe.direction == 'E')
                        positionProbe.direction = 'N';
                }

                if (move == 'R')
                {
                    if (positionProbe.direction == 'N')
                        positionProbe.direction = 'E';
                    else if (positionProbe.direction == 'E')
                        positionProbe.direction = 'S';
                    else if (positionProbe.direction == 'S')
                        positionProbe.direction = 'W';
                    else if (positionProbe.direction == 'W')
                        positionProbe.direction = 'N';
                }

            }


            return $"{positionProbe.X.ToString()} {positionProbe.Y.ToString()} {positionProbe.direction}";
        }
    }
}
