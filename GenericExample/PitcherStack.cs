using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    class PitcherStack
    {
        private List<Pitcher> _List = new List<Pitcher>();

        private int _index;
        public void Push(Pitcher x)
        {
            _List.Add(x);
            _index++;
        }
        public Pitcher Pop()
        {
            _index--;
            return _List[_index];
        }

    }
}
