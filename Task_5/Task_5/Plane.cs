namespace Task_5
{
    /// <summary>
    /// Class Plane determining object Plane and object's properties.
    /// </summary>
    class Plane : IFlyable
    {
        private  Point point;
        double speed;
        double timeOfFlight;
        private int distance;

        /// <summary>
        /// Constructor defines initial settings.
        /// </summary>
        public Plane()
        {
            point.SetPoint(0, 0, 0);
            distance = 0;
            timeOfFlight = 0;
            speed = 200;
        }

        /// <summary>
        /// Method searchs distances and sets the new initial settings for the object
        /// </summary>
        /// <param name="newPoint">Point of arrival</param>
        public void FlyTo(Point newPoint)
        {
            Distance calculateDdistance = new Distance();
            distance = calculateDdistance.Calculate(point, newPoint);
            point.SetPoint(newPoint.X, newPoint.Y, newPoint.Z);
        }

        /// <summary>
        /// Method for determining time in transit.
        /// </summary>
        /// <returns>Return time in transit</returns>
        public double GetFlyTime()
        {
            int speedChange = 10;
            int distanceChange = 10;

            while (distance <= distanceChange)
            {
                timeOfFlight += distanceChange / speed;
                distance -= distanceChange;
                speed += speedChange;
            }
            timeOfFlight += distance / speed;
            return timeOfFlight;
        }

        /// <summary>
        /// Method for determining object.
        /// </summary>
        /// <returns>Return string with object's name</returns>
        public string WhoAmI()
        {
            return "I'm Plane";
        }
    }
}
