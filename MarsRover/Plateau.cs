namespace MarsRover
{
    /// <summary>
    /// A Class representing a single plateau for one or more robots
    /// </summary>
    public class Plateau
    {
        /// <summary>
        /// The plateau constructor
        /// </summary>
        /// <param name="x">The X-Co-Ordinate of the Upper Right point</param>
        /// <param name="y">The Y-Co-Ordinate of the Upper Right point</param>
        public Plateau(int x, int y)
        {
            SouthBorder = 0;
            WestBorder = 0;
            NorthBorder = y;
            EastBorder = x;
        }

        /// <summary>
        /// Represents the Intercept of
        /// the South border with the Y-Axis
        /// </summary>
        public int SouthBorder;

        /// <summary>
        /// Represents the Intercept of
        /// the West border with the X-Axis
        /// </summary>
        public int WestBorder;

        /// <summary>
        /// Represents the Intercept of
        /// the North border with the Y-Axis
        /// </summary>
        public int NorthBorder;

        /// <summary>
        /// Represents the Intercept of
        /// the East border with the X-Axis
        /// </summary>
        public int EastBorder;

    }
}