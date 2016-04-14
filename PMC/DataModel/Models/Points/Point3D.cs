namespace DataModel.Models.Points
{
    /// <summary>
    /// Represents a single numarical triple (x, y, z).
    /// </summary>
    /// <typeparam name="T">Values type.</typeparam>
    public class Point3D<T> : Point2D<T> where T : struct
    {
        public Point3D() : base()
        {
            Z = default(T);
        }
        public Point3D(T x, T y, T z) : base(x, y)
        {
            Z = z;
        }

        public T Z
        {
            private set;
            get;
        }

        public override string ToString()
        {
            return string.Format("[{0}; {1}; {2}]", X, Y, Z);
        }
    }
}
