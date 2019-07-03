using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    class Pitcher : IComparable<Pitcher>
    {
        public Pitcher(int playcount, string name)
        {
            PlayCount = playcount;
            Name = name;
        }

        public int PlayCount { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"등판 횟수 : {PlayCount}, 투수명 : {Name} ";
        }

        public int CompareTo(Pitcher other)
        {
            return PlayCount - other.PlayCount; 
        }
    }
}
