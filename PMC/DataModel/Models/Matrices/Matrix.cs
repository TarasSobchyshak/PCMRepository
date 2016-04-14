using DataModel.Models.Positions;
using System.Collections;
using System.Collections.Generic;

namespace DataModel.Models.Matrices
{
    /// <summary>
    /// Represents a collection of positions that can be accessed by index or via <see cref="IEnumerable{Position}"/>.
    /// </summary>
    public abstract class Matrix<T> : IEnumerable<Position<T>> where T : struct
    {
        public Matrix(params Position<T>[] positions)
        {
            _positions = positions;
        }

        protected Position<T>[] _positions;

        public Position<T> this[int i]
        {
            get { return _positions[i]; }
        }

        public IEnumerator<Position<T>> GetEnumerator()
        {
            return ((IEnumerable<Position<T>>)_positions).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Position<T>>)_positions).GetEnumerator();
        }
    }
}
