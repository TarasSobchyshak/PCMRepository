using System.Collections;
using System.Collections.Generic;

namespace DataModel
{
    /// <summary>
    /// Represents a strongly typed collection of matrices that can be accessed by index or via <see cref="IEnumerable"/>.
    /// </summary>
    /// <typeparam name="T">Type of point's coordinates.</typeparam>
    public class Container<T> : IEnumerable<Matrix<T>>
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Container{T}"/>
        /// </summary>
        /// <param name="matrices">A list whose elements are copied to new collection</param>
        public Container(List<Matrix<T>> matrices)
        {
            _matrices = matrices;
        }

        private List<Matrix<T>> _matrices { set; get; }

        /// <summary>
        /// Accessor for accessing data by index.
        /// </summary>
        public Matrix<T> this[int i]
        {
            get { return _matrices[i]; }
        }

        /// <summary>
        /// Accessor for accessing data via IEnumerable.
        /// </summary>
        public IEnumerator<Matrix<T>> GetEnumerator()
        {
            return _matrices.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _matrices.GetEnumerator();
        }
    }
}
