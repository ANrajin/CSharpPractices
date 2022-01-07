using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_in_CSharp
{
    class Tree<T>
    {
        private T[] nodes = new T[100];
        private int index;


        public void AddNodes(T node)
        {
            nodes[index++] = node;
        }

        public T DeleteNode(T node)
        {
            //set the default value according to use case datatype
            T currentItem = nodes[--index];
            nodes[--index] = default(T);

            return currentItem;
        }

        public void TreeList()
        {
            foreach(var item in nodes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
