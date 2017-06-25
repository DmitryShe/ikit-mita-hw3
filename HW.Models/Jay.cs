using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public class Jay : Gambler
    {        

        public Jay() : base ("Jay")
        {
            
        }

        public override void FetchNewNumber(int number)
        {
            if (number.IsEven()) Score++;
            Console.WriteLine(number);
            Console.WriteLine("Jay score: " + Score);
            

        }

       
    }
}
