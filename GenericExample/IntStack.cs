using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    class IntStack
    {
        private List<int> _List = new List<int>();

        private int _index;
        public void Push(int x)
        {
            _List.Add(x);
            _index++;
        }
        public int Pop()
        {
            _index--;
            return _List[_index];
        }
    }
}
