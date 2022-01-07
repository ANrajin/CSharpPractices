using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    public class Class1
    {
        private string _data;

        public string CallPrivate(string param)
        {
            PrivateMethod(param);

            return _data;
        }

        private void PrivateMethod(string param)
        {
            _data = param;
        }
    }
}
