using DataModel.Models.Matrices;

namespace DataModel.Factories.IFactories
{
    public interface IMatrixFactory<T> where T : struct
    {
        MatrixX<T> CreateMatrixX(int positionCount, params int[] pointsCount);
        MatrixXY<T> CreateMatrixXY(int positionCount, params int[] pointsCount);
        MatrixXYZ<T> CreateMatrixXYZ(int positionCount, params int[] pointsCount);
    }
}
