using System;

namespace Task_5
{
    /// <summary>
    /// Class bird defines object bird and object's properties.
    /// </summary>
    class Bird : IFlyable
    {
        Point point;
        double speed;
        double timeOfFlight;
        private int distance;

        /// <summary>
        /// Constructor defines initial settings.
        /// </summary>
        public Bird()
        {
            point.SetPoint(0, 0, 0);
            distance = 0;
        }

        /// <summary>
        /// Method searchs distances and sets the new initial settings for the object
        /// </summary>
        /// <param name="newPoint">Point of arrival</param>
        public void FlyTo(Point newPoint)
        {
            Distance calculateDdistance = new Distance();
            distance = calculateDdistance.Calculate(point,newPoint);
            point.SetPoint(newPoint.X, newPoint.Y, newPoint.Z);
        }

        /// <summary>
        /// Method for determining time in transit.
        /// </summary>
        /// <returns>Return time in transit</returns>
        public double GetFlyTime()
        {
            int maxSpeedForBird = 20;
            Random rnd = new Random();
            speed= rnd.Next(0, maxSpeedForBird);

            if (speed == 0 )
            {
                point.SetPoint(0, 0, 0);
                return 0;
            }

            timeOfFlight = (double)distance / speed;
            return timeOfFlight;
        }

        /// <summary>
        /// Method for determining object.
        /// </summary>
        /// <returns>RReturn string with object's name</returns>
        public string WhoAmI()
        {
            return "I'm Bird";
        }
    }
}
