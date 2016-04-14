using DataModel.Models.Positions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataModel.Models
{
    /// <summary>
    /// Represents a strongly typed collection of containers that can be accessed by index or via <see cref="IEnumerable"/>.
    /// </summary>
    public class ContainersCollection<T> : IEnumerable<Container<T>> where T : struct
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="containers">A list whose elements are copied to new collection</param>
        public ContainersCollection(params Container<T>[] containers)
        {
            //if (!IsPositionsNumberValid(containers))
            //{
            //    throw new ArgumentException("All X and XY matrices in all containers must have the same number of positions.");
            //}
            _containers = containers;
        }

        private Container<T>[] _containers { set; get; }

        private bool IsPositionsNumberValid(Container<T>[] containers)
        {
            return
                containers.Any() &&
                containers.All(c => c.Any()) &&

                containers.All(c => c.All(m => m.Where(p => p.GetType() == typeof(PositionXYZ<>)).All(t => t.Count() == 1)));


            // containers.All(c => c.Where(m => m.GetType() != typeof(PositionXYZ<>))
            //                        .All(m => m.Count() == c[0][0].Count()));
        }

        /// <summary>
        /// Accessor for accessing data via IEnumerable.
        /// </summary>
        public IEnumerator<Container<T>> GetEnumerator()
        {
            return ((IEnumerable<Container<T>>)_containers).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Container<T>>)_containers).GetEnumerator();
        }

        /// <summary>
        /// Accessor for accessing data by index.
        /// </summary>
        public Container<T> this[int i]
        {
            get { return _containers[i]; }
        }
    }
}
