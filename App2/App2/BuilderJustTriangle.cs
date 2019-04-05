using System;

namespace App2
{
    /// <summary>
    /// Calass for building triagle
    /// </summary>
    class BuilderJustTriangle: Builder
    {
        public BuilderJustTriangle(Builder builder) : base(builder)
        {
        }

        /// <summary>
        /// Method for definition triagle and create just triangle
        /// </summary>
        /// <param name="point1">first treagle's point</param>
        /// <param name="point2">second treagle's point</param>
        /// <param name="point3">third treagle's point</param>
        /// <returns>Return just triangle</returns>
        public override Triangle Create(Point point1, Point point2, Point point3)
        {
            try
            {
                if ((point1.X == point2.X && point2.X == point3.X) || (point1.Y == point2.Y && point2.Y == point3.Y))
                {
                    throw new FormatException();
                }
                else
                {
                    JustTriangle justTriangle = new JustTriangle(point1, point2, point3);
                    return justTriangle;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error!!!");
                return null;
            }
        }
    }
}
