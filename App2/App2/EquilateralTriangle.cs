using System;

namespace App2
{
    /// <summary>
    /// Class triangle describes Equilateral Triangle and worcs with points
    /// </summary>
    class EquilateralTriangle : Triangle
    {
        double length;

        /// <summary>
        /// Constructor for definition points
        /// </summary>
        /// <param name="point1">first treagle's point</param>
        /// <param name="point2">second treagle's point</param>
        /// <param name="point3">third treagle's point</param>
        public EquilateralTriangle(Point point1, Point point2, Point point3) : base(point1, point2, point3)
        {
            length = point1.CalculateLenght(point2);
        }

        /// <summary>
        /// Method for calculate square for Equilateral Triangle
        /// </summary>
        /// <returns> Return square</returns>
        public override double GetSquare()
        {
            return Math.Sqrt(3.0) * length * length / 4;
        }
    }
}
