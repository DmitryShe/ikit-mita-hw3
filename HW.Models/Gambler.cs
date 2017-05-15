using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public abstract class Gambler
    {
        public Gambler(string name)
        {
            Name = name;
        }

        public readonly string Name;
        public int Score { get; internal set; }

        public abstract void FetchNewNumber(int number);
        
    }
}
