using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceLinq.CustomQuery
{
    public static class IEnumerableExtension
    {
        public static IEnumerable<T> NewWhere<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            foreach(var item in items)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}
