using DataModel.Models.Points;
using DataModel.Models.Positions;

namespace DataModel.Models.Matrices
{
    public class MatrixXY<T> : Matrix<Point2D<T>, T>
    {
        public MatrixXY(PositionXY<T>[] positions) : base(positions)
        {
        }
    }
}
