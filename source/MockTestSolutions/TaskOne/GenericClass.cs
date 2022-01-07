using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    public class GenericClass<T> where T : class
    {
        public T _data;

        public GenericClass(T param)
        {
            _data = param;
        }

    }
}
