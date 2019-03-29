namespace Task_5
{
    /// <summary>
    /// Class Space Ship determining object Space Ship and object's properties.
    /// </summary>
    class SpaceShip : IFlyable
    {
        Point point;
        double speed;
        double timeOfFlight;
        private int distance;

        /// <summary>
        /// Constructor defines initial settings.
        /// </summary>
        public SpaceShip()
        {
            point.SetPoint(0, 0, 0);
            speed = 8000; //  km/s
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
            timeOfFlight = (double)distance / speed;
            return timeOfFlight;
        }

        /// <summary>
        /// Method for determining object.
        /// </summary>
        /// <returns>Return string with object's name</returns>
        public string WhoAmI()
        {
            return "I'm Space Ship";
        }
    }
}
