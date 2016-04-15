using DataModel.Models.Positions;
using System.Collections;
using System.Collections.Generic;

namespace DataModel.Models.Matrices
{
    /// <summary>
    /// Represents a collection of positions that can be accessed by index or via <see cref="IEnumerable{Position}"/>.
    /// </summary>
    public abstract class Matrix<T> : IEnumerable<Position<T>> 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="positions"></param>
        public Matrix(params Position<T>[] positions)
        {
            _positions = positions;
        }

        /// <summary>
        /// 
        /// </summary>
        protected Position<T>[] _positions;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Position<T> this[int i]
        {
            get { return _positions[i]; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
