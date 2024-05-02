using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar4
{
    internal static class ListOperations
    {
        public static IEnumerable<T> MyWhere<T>( this IEnumerable<T> values, Func<T, bool> predicate)
        {
            foreach (var item in values)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}
