using System;

namespace App2
{
    /// <summary>
    /// Structur for describes object point 
    /// </summary>
    struct Point
    {
        /// <summary>
        /// Method for fast define object point
        /// </summary>
        /// <param name="x">Coordinate x</param>
        /// <param name="y">Coordinate y</param>
        public void Define(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        private double x;
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        private double y;
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double CalculateLenght(Point otherPoint)
        {
            return Math.Sqrt((X - otherPoint.X) * (X - otherPoint.X) + (Y - otherPoint.Y) * (Y - otherPoint.Y));
        }
    }
}
