namespace Task_5
{
    /// <summary>
    /// Interface. Defines the methods that are overridden in classes.
    /// </summary>
    interface IFlyable
    {
        /// <summary>
        /// Method for determining distances.
        /// </summary>
        /// <param name="newPoint">Point of arrival</param>
        void FlyTo (Point newPoint);

        /// <summary>
        /// Method for determining object.
        /// </summary>
        /// <returns>Return string with object's name</returns>
        string WhoAmI();

        /// <summary>
        /// Method for determining time in transit.
        /// </summary>
        /// <returns>Return time</returns>
        double GetFlyTime();
    }
}
