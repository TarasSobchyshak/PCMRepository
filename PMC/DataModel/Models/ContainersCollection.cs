using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{

    [AttributeUsage(AttributeTargets.All)]
    public class ValidTypeAttribute : ValidationAttribute
    {
        public ValidTypeAttribute(string str, params Type[] type)
        {
            _type = type;
        }

        private Type[] _type;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            return ValidationResult.Success;
        }
    }
    /// <summary>
    /// Represents a strongly typed collection of containers that can be accessed by index or via <see cref="IEnumerable"/>.
    /// </summary>
    /// <typeparam name="T">Type of point's coordinates.</typeparam>
    public class ContainersCollection<T> : IEnumerable<Container<T>>
    {
        //static string qwe = typeof(T).ToString();

        /// <summary>
        /// Initializes a new instance of <see cref="ContainersCollection{T}"/>
        /// </summary>
        /// <param name="containers">A list whose elements are copied to new collection</param>
        //[ValidType(qwe, new Type[] { typeof(double), typeof(float), typeof(short), typeof(int), typeof(long), typeof(decimal) })]
        public ContainersCollection(IList<Container<T>> containers)
        {
            if (!IsValidType()) throw new ArrayTypeMismatchException("Attempt to store element of not numeric type.");
            if (!IsPositionsNumberValid(containers)) throw new ArgumentException("All matrices in all containers must have the same number of positions.");
        }

        private static Type[] validTypes = { typeof(double), typeof(float), typeof(short), typeof(int), typeof(long), typeof(decimal) };
        private IList<Container<T>> _containers { set; get; }

        public static bool IsPositionsNumberValid(IList<Container<T>> containers)
        {
            return (containers.Any()
                && containers[0].Any()
                && containers[0][0].Any()
                && containers.All(c => c.All(m => m.Count() == containers[0][0][0].Count())));
        }
        public static bool IsValidType()
        {
            return validTypes.Contains(typeof(T));
        }
        /// <summary>
        /// Accessor for accessing data by index.
        /// </summary>
        public Container<T> this[int i]
        {
            get { return _containers[i]; }
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
