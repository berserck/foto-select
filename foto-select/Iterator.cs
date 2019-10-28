using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace foto_select
{
    public class ReversibleIterator<T> 
    {
        public T[] _items;

        int position = -1;


        public ReversibleIterator(T[] list)
        {
            _items = list;
        }
        public T Current
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

        public int Position { get => position; }

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

}
