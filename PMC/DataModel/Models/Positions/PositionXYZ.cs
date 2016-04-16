using DataModel.Models.Points;
using System.Text;

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

        /// <summary>
        /// Represents a position in a string format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Position:");
            if (_points.Length > 0)
            {
                foreach (var c in _points)
                {
                    sb.Append("\t").Append(c.ToString());
                }
            }
            else sb.Append("\tNo data points");
            return sb.ToString();
        }
    }
}
