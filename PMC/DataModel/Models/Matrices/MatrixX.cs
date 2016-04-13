using DataModel.Models.Points;
using DataModel.Models.Positions;

namespace DataModel.Models.Matrices
{
    public class MatrixX<T> : Matrix<Point1D<T>, T>
    {
        public MatrixX(PositionX<T>[] positions): base(positions)
        {
        }
    }
}
