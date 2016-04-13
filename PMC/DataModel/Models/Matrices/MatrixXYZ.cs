using DataModel.Models.Points;
using DataModel.Models.Positions;

namespace DataModel.Models.Matrices
{
    public class MatrixXYZ<T> : Matrix<Point3D<T>, T>
    {
        public MatrixXYZ(PositionXYZ<T>[] positions) : base(positions)
        {
        }
    }
}
