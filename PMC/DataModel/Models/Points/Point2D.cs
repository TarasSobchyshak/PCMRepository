namespace DataModel.Models.Points
{
    /// <summary>
    /// Represents a numarical pair (x, y).
    /// </summary>
    /// <typeparam name="T">Values type.</typeparam>
    public class Point2D<T> : Point1D<T> 
    {
        /// <summary>
        /// 
        /// </summary>
        public Point2D() : base()
        {
            Y = default(T);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point2D(T x, T y) : base(x)
        {
            Y = y;
        }

        /// <summary>
        /// 
        /// </summary>
        public T Y
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
            return string.Format("[{0}; {1}]", X, Y);
        }
    }
}
