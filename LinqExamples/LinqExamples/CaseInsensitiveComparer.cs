using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y) => string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
    }
}
