using System.Collections;

namespace Practice2.TestOne
{
    public class Items:IEnumerable
    {
        private string[] _items = new string[10];

        private int index = 0;

        public void AddItem(string item)
        {
            _items[index++] = item;
        }

        public void RemoveItem(int index)
        {
            _items[index] = "";
        }

        public IEnumerator GetEnumerator()
        {
            return new ItemsEnumerator(ref _items);
        }
    }
}
