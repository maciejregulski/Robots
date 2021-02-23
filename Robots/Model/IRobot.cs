namespace Robots.Model
{
    public interface IRobot
    {
        int Id { get; }

        /// <summary>
        /// Indicates if the robot has the capacity to process the job. Thread safe boolean.
        /// </summary>
        bool Busy { get; }

        /// <summary>
        /// Tells the robot to abort current job. Thread safe boolean.
        /// </summary>
        bool Abort { get; set; }

        /// <summary>
        /// Paint job duration interval, different for each color.
        /// </summary>
        int Interval { get; set; }

        /// <summary>
        /// Counts completed paint operation.
        /// </summary>
        int Completed { get; }

        /// <summary>
        /// Counts total processing time.
        /// </summary>
        int ProcessingTime { get; }

        /// <summary>
        /// Paints element in desired color.
        /// </summary>
        /// <param name="element">Argument implementing IElement interface.</param>
        void Paint(IElement element);

        /// <summary>
        /// Measures robot processing time.
        /// </summary>
        /// <param name="elapsed"></param>
        void AddExecutionTime(int elapsed);
    }
}
