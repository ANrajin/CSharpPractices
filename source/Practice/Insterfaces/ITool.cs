using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insterfaces
{
    public interface ITool
    {
        void open();
        void close();

        int count();
    }
}
