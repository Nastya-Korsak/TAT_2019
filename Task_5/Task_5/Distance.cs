namespace Task_5
{
    /// <summary>
    /// Class Distance determining object Distance.
    /// </summary>
    class Distance
    {
        /// <summary>
        /// Method for determining distance between points.
        /// </summary>
        /// <param name="point">Starting point </param>
        /// <param name="newPoint">Ending point</param>
        /// <returns>Return distances</returns>
        public int Calculate(Point point,Point newPoint)
        {
            return ((newPoint.X - point.X) ^ 2 + (newPoint.Y - point.Y) ^ 2 + (newPoint.Z - point.Z) ^ 2) ^ (1 / 2);
        }
    }
}
