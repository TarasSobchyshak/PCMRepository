using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataModel
{
    /// <summary>
    /// Represents a strongly typed collection of containers that can be accessed by index or via <see cref="IEnumerable"/>.
    /// </summary>
    /// <typeparam name="T">Type of point's coordinates.</typeparam>
    public class ContainersCollection<T> : IEnumerable<Container<T>>
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ContainersCollection{T}"/>
        /// </summary>
        /// <param name="containers">A list whose elements are copied to new collection</param>
        public ContainersCollection(List<Container<T>> containers)
        {
            if (NotValid(containers))
            {
                throw new ArgumentException("All matrices in all containers must have the same number of positions.");
            }
        }

        private List<Container<T>> _containers { set; get; }

        /// <summary>
        /// Accessor for accessing data by index.
        /// </summary>
        public Container<T> this[int i]
        {
            get { return _containers[i]; }
        }

        private bool NotValid(List<Container<T>> containers)
        {
            return (!(containers.Any()
                && containers[0].Any()
                && containers[0][0].Any()
                && containers.All(c => c.All(m => m.Count() == containers[0][0][0].Count()))));
        }

        /// <summary>
        /// Accessor for accessing data via IEnumerable.
        /// </summary>
        public IEnumerator<Container<T>> GetEnumerator()
        {
            return _containers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _containers.GetEnumerator();
        }
    }
}
