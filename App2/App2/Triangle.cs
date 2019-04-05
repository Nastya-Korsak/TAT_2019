namespace App2
{
    /// <summary>
    /// Abstract class triangle describes triange and worcs with points
    /// </summary>
    abstract class Triangle
    {
        protected Point point1;
        protected Point point2;
        protected Point point3;

        /// <summary>
        /// Constructor for definition points
        /// </summary>
        /// <param name="point1">first treagle's point</param>
        /// <param name="point2">second treagle's point</param>
        /// <param name="point3">third treagle's point</param>
        public Triangle(Point point1, Point point2,Point point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
        }

        /// <summary>
        /// method for calculate square
        /// </summary>
        /// <returns></returns>
        public abstract double GetSquare();
    }
}
