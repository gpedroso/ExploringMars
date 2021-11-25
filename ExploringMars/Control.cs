using System;
using System.Collections.Generic;
using System.Text;

namespace ExploringMars
{
    public static class Control
    {
        public static (int X, int Y) GetSpaceLimit(string inputSpaceLimit)
        {
            (int X, int Y) spaceLimit = (0, 0);

            string[] limit = inputSpaceLimit.Split(" ");

            spaceLimit.X = Int32.Parse(limit[0]);
            spaceLimit.Y = Int32.Parse(limit[1]);


            return spaceLimit;
        }

        public static (int X, int Y, char direction) GetInitPosition(string inputPosition)
        {
            (int X, int Y, char direction) initPosition = (0, 0, new char());

            string[] position = inputPosition.Split(" ");

            initPosition.X = Int32.Parse(position[0]);
            initPosition.Y = Int32.Parse(position[1]);
            initPosition.direction = Convert.ToChar(position[2]);

            return initPosition;
        }

        public static List<string> RunProbesControl(List<string> inputs)
        {
            List<string> result = new List<string>();


            (int X, int Y) spaceLimit = Control.GetSpaceLimit(inputs[0]);

            for (int i = 1; i < inputs.Count; i += 2)
            {
                var initPosition = Control.GetInitPosition(inputs[i]);
                var probePath = inputs[i + 1];
                result.Add(Control.ControlProbe(spaceLimit, initPosition, probePath));
            }

            return result;
        }
           

        public static string ControlProbe((int X, int Y) spaceLimit, (int X, int Y, char direction) positionProbe, string pathProbe)
        {
            foreach (char move in pathProbe)
            {
                if (move == 'M')
                {
                    if ((positionProbe.direction == 'N') && (positionProbe.Y < spaceLimit.Y))
                        positionProbe.Y += 1;
                    else if ((positionProbe.direction == 'S') && (positionProbe.Y > 0))
                        positionProbe.Y -= 1;
                    else if ((positionProbe.direction == 'E') && (positionProbe.X < spaceLimit.X))
                        positionProbe.X += 1;
                    else if ((positionProbe.direction == 'W') && (positionProbe.X > 0))
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
