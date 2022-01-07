using System.Collections;

namespace Practice2.Test2
{
    class PeopleEnumerator : IEnumerator
    {
        public Person[] _people;

        private int index = 0;

        public PeopleEnumerator(Person[] list)
        {
            _people = list;
        }

        public object Current
        {
            get
            {
                return _people[index++];
            }
        }

        public bool MoveNext()
        {
            return index >= _people.Length ? false : true;
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
