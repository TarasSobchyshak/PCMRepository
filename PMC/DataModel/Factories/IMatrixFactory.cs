using DataModel.Models.Matrices;
using System.Collections.Generic;
using System.Linq;

namespace DataModel.Factories
{
    public interface IMatrixFactory<T>
    {
        MatrixX<T> CreateMatrixX(int positionCount, int pointCount);
        MatrixXY<T> CreateMatrixXY(int positionCount, int pointCount);
        MatrixXYZ<T> CreateMatrixXYZ(int positionCount, int pointCount);
    }

    public class DefaultMatrixFactory<T> : IMatrixFactory<T>
    {
        public DefaultMatrixFactory()
        {
            _positionFactory = new DefaultPositionFactory<T>();
        }

        private IPositionFactory<T> _positionFactory;
        public MatrixX<T> CreateMatrixX(int positionCount, int pointCount)
        {
            var positions = Enumerable.Range(1, positionCount)
                .Select(r => _positionFactory.CreatePositionX(pointCount));
            return new MatrixX<T>(positions.ToArray());
        }

        public MatrixXY<T> CreateMatrixXY(int positionCount, int pointCount)
        {
            var positions = Enumerable.Range(1, positionCount)
                .Select(r => _positionFactory.CreatePositionXY(pointCount));
            return new MatrixXY<T>(positions.ToArray());
        }

        public MatrixXYZ<T> CreateMatrixXYZ(int positionCount, int pointCount)
        {
            var positions = Enumerable.Range(1, positionCount)
                .Select(r => _positionFactory.CreatePositionXYZ(pointCount));
            return new MatrixXYZ<T>(positions.ToArray());
        }
    }
}
