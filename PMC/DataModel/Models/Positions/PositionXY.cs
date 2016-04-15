using DataModel.Models.Points;

namespace DataModel.Models.Positions
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PositionXY<T> : Position<T> 
    {
        /// <summary>
        /// 
        /// </summary>
        public PositionXY(): base()
        {
            _points = new Point2D<T>[0];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="points"></param>
        public PositionXY(params Point2D<T>[] points): base(points)
        {
        }
    }
}
