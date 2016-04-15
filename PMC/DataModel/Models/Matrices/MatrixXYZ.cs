using DataModel.Models.Positions;

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
    }
}
