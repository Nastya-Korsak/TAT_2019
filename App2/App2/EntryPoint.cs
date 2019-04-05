using System;

namespace App2
{
    /// <summary>
    /// Entry Point. In this program works with Triangle
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Point point1=new Point();
            Point point2 = new Point();
            Point point3 = new Point();

            point1.Define(1,2);
            point2.Define(2,2);
            point3.Define(2,3);

            BuilderRectangular buildertriangle = new BuilderRectangular(new BuilderEquilateral(new BuilderJustTriangle(null)));

            Triangle triangle;
            triangle= buildertriangle.Create(point1,point2,point3);

            Console.WriteLine(triangle.GetSquare().ToString());

        }
    }
}
