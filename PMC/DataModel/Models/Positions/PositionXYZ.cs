using DataModel.Models.Points;

namespace DataModel.Models.Positions
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PositionXYZ<T> : Position<T> 
    {
        /// <summary>
        /// 
        /// </summary>
        public PositionXYZ() : base()
        {
            _points = new Point3D<T>[0];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="points"></param>
        public PositionXYZ(params Point3D<T>[] points) : base(points)
        {
        }
    }
}
