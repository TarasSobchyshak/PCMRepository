using DataModel.Models.Points;
using System.Text;

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

        /// <summary>
        /// Represents a position in a string format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Position:");
            foreach (var c in _points)
            {
                sb.Append("\t").Append(c.ToString());
            }
            return sb.ToString();
        }
    }
}
