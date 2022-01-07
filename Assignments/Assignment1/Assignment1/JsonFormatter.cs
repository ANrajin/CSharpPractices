using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections;

namespace Assignment1
{
    public class JsonFormatter<T>
    {
        public static string Converter(object item)
        {
            StringBuilder str = new StringBuilder();

            IEnumerable<PropertyInfo> propertyInfos = item.GetType().GetProperties();

            if(!item.GetType().IsPrimitive && item.GetType() != typeof(string))
            {
                var isArray = typeof(IEnumerable).IsAssignableFrom(item.GetType()) ? true : false;

                if(isArray)
                    str.Append("[");
                else
                    str.Append("{");

                if (!isArray)
                {
                    foreach(var property in propertyInfos)
                    {
                        if(property.PropertyType == typeof(string))
                            str.Append($"\"{property.Name}\": \"{property.GetValue(item)}\", ");
                        else if(property.PropertyType == typeof(DateTime))
                            str.Append($"\"{property.Name}\": \"{property.GetValue(item).ToString()}\", ");
                        else if (property.PropertyType == typeof(int) || property.PropertyType == typeof(double) || property.PropertyType == typeof(float))
                        {
                            str.Append($"\"{property.Name}\": {property.GetValue(item)}, ");
                        }
                        else
                            str.Append($"\"{property.Name}\": {Converter(property.GetValue(item))}, ");
                    }
                }
                else
                {
                    foreach(var i in item as IEnumerable)
                    {
                        if(i.GetType().IsPrimitive || i.GetType() == typeof(string))
                            str.Append($"\"{i}\", ");
                        else
                            str.Append($"{Converter(i)}, ");
                    }
                }

                //str.Remove(str.ToString().Length - 2, 2);

                if (isArray)
                    str.Append("]");
                else
                    str.Append("}");
            }
            else
            {
                str.Append(item.ToString());
            }

            return str.ToString();
        }
    }
}
