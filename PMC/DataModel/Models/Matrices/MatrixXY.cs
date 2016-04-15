using DataModel.Models.Positions;

namespace DataModel.Models.Matrices
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MatrixXY<T> : Matrix<T> 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="positions"></param>
        public MatrixXY(params PositionXY<T>[] positions) : base(positions)
        {
        }
    }
}
