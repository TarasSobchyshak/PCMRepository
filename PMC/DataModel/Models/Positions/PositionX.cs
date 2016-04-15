using DataModel.Models.Points;

namespace DataModel.Models.Positions
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PositionX<T> : Position<T>
    {
        /// <summary>
        /// 
        /// </summary>
        public PositionX(): base()
        {
            _points = new Point1D<T>[0];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="points"></param>
        public PositionX(params Point1D<T>[] points): base(points)
        {
        }
    }
}
