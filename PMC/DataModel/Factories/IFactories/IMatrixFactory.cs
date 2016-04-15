using DataModel.Models.Matrices;

namespace DataModel.Factories.IFactories
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IMatrixFactory<T> 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="positionCount"></param>
        /// <param name="pointsCount"></param>
        /// <returns></returns>
        MatrixX<T> CreateMatrixX(int positionCount, params int[] pointsCount);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="positionCount"></param>
        /// <param name="pointsCount"></param>
        /// <returns></returns>
        MatrixXY<T> CreateMatrixXY(int positionCount, params int[] pointsCount);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="positionCount"></param>
        /// <param name="pointsCount"></param>
        /// <returns></returns>
        MatrixXYZ<T> CreateMatrixXYZ(int positionCount, params int[] pointsCount);
    }
}
