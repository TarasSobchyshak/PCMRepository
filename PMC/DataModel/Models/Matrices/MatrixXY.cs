using DataModel.Models.Positions;

namespace DataModel.Models.Matrices
{
    public class MatrixXY<T> : Matrix<T> where T : struct
    {
        public MatrixXY(params PositionXY<T>[] positions) : base(positions)
        {
        }
    }
}
