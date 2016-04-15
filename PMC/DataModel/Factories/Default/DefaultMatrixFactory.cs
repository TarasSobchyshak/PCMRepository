using DataModel.Factories.IFactories;
using DataModel.Models.Matrices;
using DataModel.Models.Positions;

namespace DataModel.Factories.Default
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DefaultMatrixFactory<T> : IMatrixFactory<T> 
    {
        /// <summary>
        /// 
        /// </summary>
        public DefaultMatrixFactory()
        {
            _positionFactory = new DefaultPositionFactory<T>();
        }

        private IPositionFactory<T> _positionFactory;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="positionCount"></param>
        /// <param name="pointsCount"></param>
        /// <returns></returns>
        public MatrixX<T> CreateMatrixX(int positionCount, params int[] pointsCount)
        {
            var positions = new PositionX<T>[positionCount];
            for (int i = 0; i < positionCount; ++i)
            {
                positions[i] = _positionFactory.CreatePositionX(pointsCount[i]);
            }
            return new MatrixX<T>(positions);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="positionCount"></param>
        /// <param name="pointsCount"></param>
        /// <returns></returns>
        public MatrixXY<T> CreateMatrixXY(int positionCount, params int[] pointsCount)
        {
            var positions = new PositionXY<T>[positionCount];
            for (int i = 0; i < positionCount; ++i)
            {
                positions[i] = _positionFactory.CreatePositionXY(pointsCount[i]);
            }
            return new MatrixXY<T>(positions);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="positionCount"></param>
        /// <param name="pointsCount"></param>
        /// <returns></returns>
        public MatrixXYZ<T> CreateMatrixXYZ(int positionCount, params int[] pointsCount)
        {
            var positions = new PositionXYZ<T>[positionCount];
            for (int i = 0; i < positionCount; ++i)
            {
                positions[i] = _positionFactory.CreatePositionXYZ(pointsCount[i]);
            }
            return new MatrixXYZ<T>(positions);
        }
    }
}
