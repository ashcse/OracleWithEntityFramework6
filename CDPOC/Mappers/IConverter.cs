using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CDPOC.Mappers
{
    /// <summary>
    /// Interface to provide conversion from any source type to any target type
    /// </summary>
    /// <typeparam name="TSource">Source type</typeparam>
    /// <typeparam name="TTarget">Target type</typeparam>
    public interface IConverter<in TSource, out TTarget> where TSource: class where TTarget : class
    {
        /// <summary>
        /// Converts one source type object to target type object
        /// </summary>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        TTarget Convert(TSource sourceType);

        /// <summary>
        /// Converts collection of source type objects to collection of destination type objects
        /// </summary>
        /// <param name="sourceColl">Source type objects</param>
        /// <returns>Target type objects</returns>
        IEnumerable<TTarget> Convert(IEnumerable<TSource> sourceColl);
    }
}
