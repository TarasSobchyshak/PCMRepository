using DataModel.Models.Positions;

namespace DataModel.Models.Matrices
{
    public class MatrixXYZ<T> : Matrix<T> where T : struct
    {
        public MatrixXYZ(params PositionXYZ<T>[] positions) : base(positions)
        {
        }
    }
}
