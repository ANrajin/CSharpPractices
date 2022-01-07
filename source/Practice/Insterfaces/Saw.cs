using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insterfaces
{
    class Saw:ITool
    {
        public void close()
        {
            
        }

        public int count()
        {
            throw new NotImplementedException();
        }

        public void open()
        {
            throw new NotImplementedException();
        }
    }
}
