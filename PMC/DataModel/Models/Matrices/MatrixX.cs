using DataModel.Models.Positions;

namespace DataModel.Models.Matrices
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MatrixX<T> : Matrix<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="positions"></param>
        public MatrixX(params PositionX<T>[] positions) : base(positions)
        {
        }
    }
}
