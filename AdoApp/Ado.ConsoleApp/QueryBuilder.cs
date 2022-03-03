using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ado.ConsoleApp
{
    public static class QueryBuilder<T>
    {
        public static string Insert(T item, string table, IEnumerable<PropertyInfo> propertyInfos)
        {
            StringBuilder query = new StringBuilder($"insert into {table}s (");

            foreach (var propInfo in propertyInfos)
            {
                query.Append($"{propInfo.Name}, ");
            }

            query.Remove(query.ToString().Length - 2, 2);
            query.Append(") values (");

            foreach (var propInfo in propertyInfos)
            {
                query.Append($"@{propInfo.Name}, ");
            }
            query.Remove(query.ToString().Length - 2, 2);
            query.Append(")");

            return query.ToString();
        }

        public static string Update(T item, string table, IEnumerable<PropertyInfo> propertyInfos, int Id)
        {
            throw new NotImplementedException();
        }

        public static string Delete()
        {
            throw new NotImplementedException();
        }

        public static IDictionary<string, object> GetParams(T item, IEnumerable<PropertyInfo> propertyInfos)
        {
            Dictionary<string, object> queryParam = new Dictionary<string, object>();

            foreach (var propInfo in propertyInfos)
            {
                queryParam.Add($"@{propInfo.Name}", propInfo.GetValue(item));
            }

            return queryParam;
        }
    }
}
