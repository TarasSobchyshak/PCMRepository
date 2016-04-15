namespace DataModel.Models.Points
{
    /// <summary>
    /// Represents a single numarical triple (x, y, z).
    /// </summary>
    /// <typeparam name="T">Values type.</typeparam>
    public class Point3D<T> : Point2D<T> 
    {
        /// <summary>
        /// 
        /// </summary>
        public Point3D() : base()
        {
            Z = default(T);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Point3D(T x, T y, T z) : base(x, y)
        {
            Z = z;
        }

        /// <summary>
        /// 
        /// </summary>
        public T Z
        {
            private set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("[{0}; {1}; {2}]", X, Y, Z);
        }
    }
}
