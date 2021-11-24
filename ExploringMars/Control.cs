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
                    if (positionProbe.direction == 'S')
                        positionProbe.Y -= 1;
                    if (positionProbe.direction == 'E')
                        positionProbe.X += 1;
                    if (positionProbe.direction == 'W')
                        positionProbe.X -= 1;
                }

                if (move == 'L')
                {
                    if (positionProbe.direction == 'N')
                        positionProbe.direction = 'W';
                    if (positionProbe.direction == 'W')
                        positionProbe.direction = 'S';
                    if (positionProbe.direction == 'S')
                        positionProbe.direction = 'E';
                    if (positionProbe.direction == 'E')
                        positionProbe.direction = 'N';
                }

                if (move == 'R')
                {
                    if (positionProbe.direction == 'N')
                        positionProbe.direction = 'E';
                    if (positionProbe.direction == 'E')
                        positionProbe.direction = 'S';
                    if (positionProbe.direction == 'S')
                        positionProbe.direction = 'W';
                    if (positionProbe.direction == 'W')
                        positionProbe.direction = 'N';
                }

            }


            return $"{positionProbe.X.ToString()} {positionProbe.Y.ToString()} {positionProbe.direction}";
        }
    }
}
