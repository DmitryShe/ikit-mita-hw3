using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public class Jay : Gambler
    {
        string Name;

        public Jay(string name) : base (name)
        {
            this.Name = name;
        }

        public override void FetchNewNumber(int number)
        {
            if (number.IsEven()) Score++;
            
            Console.WriteLine("Jay score: " + Score);
            

        }

       
    }
}
