namespace App2
{
    /// <summary>
    /// Class triangle describes Just Triangle and worcs with points
    /// </summary>
    class JustTriangle : Triangle
    {
        /// <summary>
        /// Constructor for definition points
        /// </summary>
        /// <param name="point1">first treagle's point</param>
        /// <param name="point2">second treagle's point</param>
        /// <param name="point3">third treagle's point</param>
        public JustTriangle(Point point1, Point point2, Point point3) : base(point1,  point2, point3)
        {
        }

        /// <summary>
        /// Method for calculate square for Just Triangle
        /// </summary>
        /// <returns> Return square</returns>
        public override double GetSquare()
        {
            return (1 / 2) * ((point1.X - point3.X) * (point2.Y - point3.Y) - (point1.Y - point3.Y) * (point2.X - point3.X));
        }
    }
}
