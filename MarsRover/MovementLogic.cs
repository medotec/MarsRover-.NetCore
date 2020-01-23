using System;

namespace MarsRover
{
    /// <summary>
    /// A class representing The Movement Logic of a robot
    /// </summary>
    public static class MovementLogic
    {
        /// <summary>
        /// Rotates the Robot 90 degrees to the Right
        /// </summary>
        /// <param name="robot">A Robot Object</param>
        public static void RotateRight(this Robot robot)
        {
            if (robot.Orientation == Orientation.W)
            {
                robot.Orientation = Orientation.N;
                return;
            }
            robot.Orientation += 1;
        }

        /// <summary>
        /// Rotates the Robot 90 degrees to the Left
        /// </summary>
        /// <param name="robot">A Robot Object</param>
        public static void RotateLeft(this Robot robot)
        {
            if (robot.Orientation == Orientation.N)
            {
                robot.Orientation = Orientation.W;
                return;
            }
            robot.Orientation -= 1;
        }
        
        /// <summary>
        /// Moves the Robot 1 Step Forward
        /// </summary>
        /// <param name="robot">A Robot Object</param>
        public static void MoveForward(this Robot robot)
        {
            switch (robot.Orientation)
            {
                case Orientation.N: // Moves 1 Step to the North
                    if (robot.Position.Y == robot.Plateau.NorthBorder) // Validates that the robot has enough space to move
                        throw new ArgumentOutOfRangeException($"The robot {robot.Name} can not Move any more as it is the end of the plateau.");
                    robot.Position = new Position(robot.Position.X, robot.Position.Y + 1); 
                    break;
                case Orientation.E: // Moves 1 Step to the East
                    if (robot.Position.Y == robot.Plateau.EastBorder) // Validates that the robot has enough space to move
                        throw new ArgumentOutOfRangeException($"The robot {robot.Name} can not Move any more as it is the end of the plateau.");
                    robot.Position = new Position(robot.Position.X + 1, robot.Position.Y);
                    break;
                case Orientation.S: // Moves 1 Step to the South
                    if (robot.Position.Y == robot.Plateau.SouthBorder) // Validates that the robot has enough space to move
                        throw new ArgumentOutOfRangeException($"The robot {robot.Name} can not Move any more as it is the end of the plateau.");
                    robot.Position = new Position(robot.Position.X, robot.Position.Y - 1);
                    break;
                case Orientation.W: // Moves 1 Step to the West
                    if (robot.Position.Y == robot.Plateau.EastBorder) // Validates that the robot has enough space to move
                        throw new ArgumentOutOfRangeException($"The robot {robot.Name} can not Move any more as it is the end of the plateau.");
                    robot.Position = new Position(robot.Position.X - 1, robot.Position.Y);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Please enter a valid argument.");
            }
        }

        //public static void MoveForward(this Robot robot, int steps)
        //{
        //    switch (robot.Orientation)
        //    {
        //        case Orientation.N:
        //            robot.Position = new Position(robot.Position.X, robot.Position.Y + steps);
        //            break;
        //        case Orientation.E:
        //            robot.Position = new Position(robot.Position.X + steps, robot.Position.Y);
        //            break;
        //        case Orientation.S:
        //            robot.Position = new Position(robot.Position.X, robot.Position.Y - steps);
        //            break;
        //        case Orientation.W:
        //            robot.Position = new Position(robot.Position.X - steps, robot.Position.Y);
        //            break;
        //        default:
        //            throw new ArgumentOutOfRangeException();
        //    }
        //}

        public static void Movement(this Robot robot, Char c)
        {
            switch (c)
            {
                case 'L':
                    robot.RotateLeft();
                    break;

                case 'R':
                    robot.RotateRight();
                    break;

                case 'M':
                    robot.MoveForward();
                    break;

                default:
                    throw new ArgumentOutOfRangeException($"Order [{c}] is not a valid Order, Please Enter L, R Or M.");
            }
        }

    }
}