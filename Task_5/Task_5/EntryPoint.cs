using System;

namespace Task_5
{
    /// <summary>
    /// Entry point. The main class. It have method for start program.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Method defines the actions performed when the program starts.
        /// </summary>
        /// <param name="args">Not used</param>
        static void Main(string[] args)
        {
            Point point = new Point();
            point.SetPoint(100,200,300);
            Bird bird = new Bird();
            TimeOfFlight time = new TimeOfFlight();

            bird.FlyTo(point);
            time.Print(bird,bird.GetFlyTime());
            Console.WriteLine(bird.WhoAmI());

            Plane plane = new Plane();
            plane.FlyTo(point);
            time.Print(plane,plane.GetFlyTime());
            Console.WriteLine(plane.WhoAmI());

            SpaceShip spaceShip = new SpaceShip();
            spaceShip.FlyTo(point);
            time.Print(spaceShip,spaceShip.GetFlyTime());
            Console.WriteLine(spaceShip.WhoAmI());
        }
    }
}
