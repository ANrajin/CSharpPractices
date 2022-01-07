using System.Collections;

namespace Practice2.Test2
{
    class People : IEnumerable
    {
        private Person[] _people;

        public People(Person[] list)
        {
            _people = new Person[list.Length];

            for(var i = 0; i < list.Length; i++)
            {
                _people[i] = list[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new PeopleEnumerator(_people);
        }
    }
}
