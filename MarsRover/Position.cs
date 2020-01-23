namespace MarsRover
{
    /// <summary>
    /// A Class representing a single point on the Grid
    /// </summary>
    public struct Position
    {
        /// <summary>
        /// the Position constructor
        /// </summary>
        /// <param name="x">X-axis Position</param>
        /// <param name="y">Y-axis position</param>
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Represents the position along the X-Axis
        /// (Horizontal)
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Represents the position along the Y-Axis
        /// (Vertical)
        /// </summary>
        public int Y { get; set; }
    }
}