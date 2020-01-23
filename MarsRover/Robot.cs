namespace MarsRover
{
    /// <summary>
    /// A class representing one robot object
    /// </summary>
    public class Robot

    {
        ///<summary>
        ///The Robot unique Identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Robot's Given Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Position of the Robot in X & Y Co-Ordinates
        /// Relative to the plateau.
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        /// The plateau on which the robot runs
        /// </summary>
        public Plateau Plateau { get; set; }

        /// <summary>
        /// The Orientation of the robot as an Enum.
        /// </summary>
        public Orientation Orientation { get; set; }
    }
}