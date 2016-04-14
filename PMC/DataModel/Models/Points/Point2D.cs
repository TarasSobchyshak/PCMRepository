namespace DataModel.Models.Points
{
    /// <summary>
    /// Represents a numarical pair (x, y).
    /// </summary>
    /// <typeparam name="T">Values type.</typeparam>
    public class Point2D<T> : Point1D<T> where T : struct
    {
        public Point2D() : base()
        {
            Y = default(T);
        }
        public Point2D(T x, T y) : base(x)
        {
            Y = y;
        }

        public T Y
        {
            private set;
            get;
        }

        public override string ToString()
        {
            return string.Format("[{0}; {1}]", X, Y);
        }
    }
}
