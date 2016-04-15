using DataModel.Models.Positions;
using System.Text;

namespace DataModel.Models.Matrices
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MatrixXYZ<T> : Matrix<T> 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="positions"></param>
        public MatrixXYZ(params PositionXYZ<T>[] positions) : base(positions)
        {
        }

        /// <summary>
        /// Represents a matrix in a string format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Matrix:");
            foreach (var c in _positions)
            {
                sb.Append("\r\n").Append(c.ToString());
            }
            return sb.ToString();
        }
    }
}
