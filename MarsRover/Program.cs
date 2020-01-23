using System;
using static System.Console;


namespace MarsRover
{
    class Program
    {
        static void Main()
        {
            // Takes the input and store is in a collection...
            string[] plateauStrings = ReadLine()?.Split(' ');
            string[] robot1Strings = ReadLine()?.Split(' ');
            char[] robot1Directions = ReadLine()?.ToCharArray();
            string[] robot2Strings = ReadLine()?.Split(' ');
            char[] robot2Directions = ReadLine()?.ToCharArray();

            // Null Validation
            if (plateauStrings != null)
            {
                Plateau plateau = new Plateau(int.Parse(plateauStrings[0]), int.Parse(plateauStrings[1])); // Creats a new Plateau
                if (robot1Strings != null)
                {
                    Robot robot1 = new Robot // Creates a new Robot
                    {
                        Id = 1,
                        Name = "Robot 1",
                        Plateau = plateau,
                        Position = new Position(int.Parse(robot1Strings[0]), int.Parse(robot1Strings[1])),
                        Orientation = (Orientation)Enum.Parse(typeof(Orientation), robot1Strings[2], true)
                    };
                    if (robot1Directions != null)
                        foreach (char c in robot1Directions) // Robot Movement
                        {
                            robot1.Movement(c);
                        }

                    if (robot2Strings != null)
                    {
                        Robot robot2 = new Robot // Creates a new Robot
                        {
                            Id = 2,
                            Name = "Robot 2",
                            Plateau = plateau,
                            Position = new Position(int.Parse(robot2Strings[0]), int.Parse(robot2Strings[1])),
                            Orientation = (Orientation)Enum.Parse(typeof(Orientation), robot2Strings[2], true)
                        };
                        if (robot2Directions != null)
                            foreach (char c in robot2Directions) // Robot Movement
                            {
                                robot2.Movement(c);
                            }

                        Console.WriteLine($"{robot1.Position.X} {robot1.Position.Y} {robot1.Orientation}");
                        Console.WriteLine($"{robot2.Position.X} {robot2.Position.Y} {robot2.Orientation}");
                    }
                }
            }
        }
    }
}
