using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace foto_select
{
    interface IMyIterator : IEnumerator
    {
        bool MovePrevious();
    }

    class ReversibleIterator<T> : IMyIterator
    {
        public T[] _items;

        int position = -1;

        public ReversibleIterator(T[] list)
        {
            _items = list;
        }
        public object Current
        {
            get
            {
                try
                {
                    return _items[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            bool inArray = (position < _items.Length);
            position = inArray ? position : _items.Length;
            return inArray;
        }

        public bool MovePrevious()
        {
            position--;
            bool inArray = (position > -1);
            position = inArray ? position : -1;
            return inArray;
        }

        public void Reset()
        {
            position = -1;
        }
    }

    public class MyCollection<T> : IEnumerable
    {
        private T[] _items;
        public MyCollection(T[] pArray)
        {
            _items = new T[pArray.Length];
            for (int i = 0; i < pArray.Length; i++)
            {
                _items[i] = pArray[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new ReversibleIterator<T>(_items);
        }
    }


}
