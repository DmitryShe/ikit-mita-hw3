using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public delegate void DNumberTron(int i);

    public class Numbertron
    {
        public event DNumberTron NewNumber;
        public void Generate()
        {
            Random rand = new Random();
            int n = rand.Next(0, 101);                 
            NewNumber(n);

            
        }
    }
}
