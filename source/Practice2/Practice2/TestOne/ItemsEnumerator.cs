using System;
using System.Collections;

namespace Practice2.TestOne
{
    class ItemsEnumerator : IEnumerator
    {
        public string[] _items;
        public int index = 0;

        public ItemsEnumerator(ref string[] items)
        {
            this._items = items;
        }

        public object Current
        {
            get
            {
                return _items[index++];
            }
        }

        public bool MoveNext()
        {
            return index >= _items.Length ? false : true;
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
