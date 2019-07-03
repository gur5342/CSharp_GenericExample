using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //var stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);

            //Console.WriteLine(stack.Pop());

            var pit = new Stack<Pitcher>();
            pit.Push(new Pitcher(10, "린드블럼"));
            pit.Push(new Pitcher(11, "김광현"));

            Console.WriteLine(pit.Pop().ToString());
            Console.WriteLine(pit.Pop().ToString());
        }
    }
}
