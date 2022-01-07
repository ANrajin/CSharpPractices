using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_in_CSharp
{
    public enum Color
    {
        Red, Green, Blue, Black, Yellow
    }

    public enum Size
    {
        xs, s, m, l,xl
    }

    class Product
    {
        public string name;
        public Color color;
        public Size size;

        public Product(string name, Color color, Size size)
        {

        }
    }

    class OCP
    {
    }
}
