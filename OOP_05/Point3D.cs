namespace OOP_05
{
    public class Point3D : IComparable<Point3D>, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int _x)
        {
            X = _x;
        }
        public Point3D(int _x, int _y) : this(_x)
        {
            Y = _y;
        }
        public Point3D(int _x, int _y, int _z) : this(_x, _y)
        {
            Z = _z;
        }

        #region Q2
        //2.Override the ToString Function to produce this output:

        public override string ToString()
        {
            return $"Point Coordinates: ({X},{Y},{Z})";
        }

        public int CompareTo(Point3D? other)
        {
            if (this.X > other.X)
                return 1;
            else if (this.X < other.X)
                return -1;
            else
            {
                if (this.Y > other.Y)
                    return 1;
                else if (this.Y < other.Y)
                    return -1;
                else
                    return 0;
            }
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
        #endregion

    }
}
