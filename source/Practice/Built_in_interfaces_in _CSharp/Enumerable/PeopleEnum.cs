using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Built_in_interfaces_in__CSharp.Enumerable
{
    class PeopleEnum : IEnumerator
    {
        public Person[] _person;

        int position = -1;

        public PeopleEnum(Person[] list)
        {
            _person = list;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < _person.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public Person Current
        {
            get
            {
                try
                {
                    return _person[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
