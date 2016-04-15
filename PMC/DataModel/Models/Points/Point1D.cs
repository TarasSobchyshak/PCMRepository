namespace DataModel.Models.Points
{
    /// <summary>
    /// Represents a single numarical value (x).
    /// </summary>
    /// <typeparam name="T">Value type.</typeparam>
    public class Point1D<T> : Point<T> 
    {
        /// <summary>
        /// 
        /// </summary>
        public Point1D()
        {
            X = default(T);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        public Point1D(T x)
        {
            X = x;
        }

        /// <summary>
        /// 
        /// </summary>
        public T X
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
            return string.Format("[{0}]", X);
        }
    }
}
