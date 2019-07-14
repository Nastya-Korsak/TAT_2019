namespace Task_5
{
    /// <summary>
    /// Structur for determining point's coordinate
    /// </summary>
    struct Point
    {
        private int coordinate_x;
        private int coordinate_y;
        private int coordinate_z;

        /// <summary>
        /// Method to set the value of the points.
        /// </summary>
        /// <param name="x">Coordinate x</param>
        /// <param name="y">Coordinate y</param>
        /// <param name="z">coordinate z</param>
        public void SetPoint(int x, int y, int z)
        {
            coordinate_x = x;
            coordinate_y = y;
            coordinate_z = z;
        }

        /// <summary>
        /// Gets and sets the value of a coordinate x
        /// </summary>
        public int X
        {
            get { return coordinate_x; }
            set { coordinate_x = value; }
        }

        /// <summary>
        /// Gets and sets the value of a coordinate y
        /// </summary>
        public int Y
        {
            get { return coordinate_y; }
            set { coordinate_y = value; }
        }

        /// <summary>
        /// Gets and sets the value of a coordinate z
        /// </summary>
        public int Z
        {
            get { return coordinate_z; }
            set { coordinate_z = value; }
        }
    }
}