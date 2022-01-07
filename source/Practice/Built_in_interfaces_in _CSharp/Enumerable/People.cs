using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Built_in_interfaces_in__CSharp.Enumerable
{
    public class People : IEnumerable
    {
        public Person[] _people;
        public Person _person;

        public People(Person[] pArray)
        {
            _people = new Person[pArray.Length];

            for(var i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }


        public Person this[int index]
        {
            get
            {
                return _people[index];
            }
            set
            {
                _people[index] = value;
            }
        }

        public Person this[string index]
        {
            get
            {
                foreach(var x in _people)
                {
                    if(x._firstname == index)
                    {
                        _person = x;
                    }
                }

                return _person;
            }
            set
            {
                var person = this[index];
                person._firstname = value._firstname;
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
