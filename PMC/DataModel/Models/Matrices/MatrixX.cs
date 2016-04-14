using DataModel.Models.Positions;

namespace DataModel.Models.Matrices
{
    public class MatrixX<T> : Matrix<T> where T: struct
    {
        public MatrixX(params PositionX<T>[] positions) : base(positions)
        {
        }
    }
}
