using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    class Stack<T>
    {
        private List<T> _List = new List<T>();

        private int _index;
        public void Push(T x)
        {
            _List.Add(x);
            _index++;
        }
        public T Pop()
        {
            _index--;
            return _List[_index];
        }
    }
}
