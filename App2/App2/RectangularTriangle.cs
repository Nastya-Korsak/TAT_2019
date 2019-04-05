using System;

namespace App2
{
    /// <summary>
    /// Class triangle describes Rectangular Triangle and worcs with points
    /// </summary>
    class RectangularTriangle : Triangle
    {
        double length12;
        double length13;
        double length23;

        /// <summary>
        /// Constructor for definition points
        /// </summary>
        /// <param name="point1">first treagle's point</param>
        /// <param name="point2">second treagle's point</param>
        /// <param name="point3">third treagle's point</param>
        public RectangularTriangle(Point point1, Point point2, Point point3) : base(point1, point2, point3)
        {
            length12 = point1.CalculateLenght(point2);
            length13 = point1.CalculateLenght(point3);
            length23 = point2.CalculateLenght(point3);
        }

        /// <summary>
        /// Method for calculate square for Rectangular Triangle
        /// </summary>
        /// <returns> Return square</returns>
        public override double GetSquare()
        {
            if (length12 == Math.Sqrt(length13 * length13 + length23 * length23))
            {
                return length13 * length23 / 2;
            }
            else if (length13 == Math.Sqrt(length12 * length12 + length23 * length23))
            {
                return length12 * length23 / 2;
            }
            else if (length23 == Math.Sqrt(length12 * length12 + length13 * length13))
            {
                return length13 * length12 / 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
