using DataModel.Models.Positions;

namespace DataModel.Factories.IFactories
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPositionFactory<T> 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointsCount"></param>
        /// <returns></returns>
        PositionX<T> CreatePositionX(int pointsCount);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointsCount"></param>
        /// <returns></returns>
        PositionXY<T> CreatePositionXY(int pointsCount);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointsCount"></param>
        /// <returns></returns>
        PositionXYZ<T> CreatePositionXYZ(int pointsCount);
    }
}
