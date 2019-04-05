using System;

namespace App2
{
    /// <summary>
    /// Calass for building triagle
    /// </summary>
    class BuilderEquilateral: Builder
    {
        public BuilderEquilateral(Builder builder) : base(builder)
        {
        }
        /// <summary>
        /// Method for definition triagle and create equilateral triangle
        /// </summary>
        /// <param name="point1">first treagle's point</param>
        /// <param name="point2">second treagle's point</param>
        /// <param name="point3">third treagle's point</param>
        /// <returns>Return equilateral triangle</returns>
        public override Triangle Create(Point point1, Point point2, Point point3)
        {
            double length12 = point1.CalculateLenght(point2);
            double length13 = point1.CalculateLenght(point3);
            double length23 = point2.CalculateLenght(point3);

            if (length12==length13 && length12==length23)
            {
                EquilateralTriangle equilateralTriangle = new EquilateralTriangle(point1, point2, point3);
                return equilateralTriangle;
            }
            else
            {
                return builder.Create(point1, point2, point3);
            }
        }
    }
}
