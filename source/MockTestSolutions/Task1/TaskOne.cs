using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTestSolutions
{
    public class TaskOne<T>where T: class
    {
        public T Data { get; set; }

        public TaskOne(T param)
        {
            Data = param;
        }
    }
}
