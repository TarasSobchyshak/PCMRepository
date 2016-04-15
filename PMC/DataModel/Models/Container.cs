using DataModel.Models.Matrices;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Models
{
    /// <summary>
    /// Represents a strongly typed collection of matrices that can be accessed by index or via <see cref="IEnumerable"/>.
    /// </summary>
    public class Container<T> : IEnumerable<Matrix<T>> 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matrices">A list whose elements are copied to new collection</param>
        public Container(params Matrix<T>[] matrices)
        {
            _matrices = matrices;
        }

        private Matrix<T>[] _matrices { set; get; }

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
            return ((IEnumerable<Matrix<T>>)_matrices).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Matrix<T>>)_matrices).GetEnumerator();
        }

        /// <summary>
        /// Represents a container in a string format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Container:\r\n\r\n");
            foreach (var c in _matrices)
            {
                sb.Append(c.ToString()).Append("\r\n\r\n");
            }
            return sb.ToString();
        }
    }
}
