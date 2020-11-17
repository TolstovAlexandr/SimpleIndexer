using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    public class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();
        public Person this[int index]
        {
            get => (Person)arPeople[index];
            set => arPeople.Insert(index, value);
        }
        IEnumerator IEnumerable.GetEnumerator() => arPeople.GetEnumerator();
        public int Count
        {
            get => arPeople.Count;
        }
    }
}
