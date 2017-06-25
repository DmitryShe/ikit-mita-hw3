using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{    
    public class SilentBob : Gambler
    {
        

        public SilentBob() : base("Silent Bob")
        {
           
        }

        public override void FetchNewNumber(int number)
        {
            if (!number.IsEven()) Score++;
            Console.WriteLine("Silent Bob score: " + Score);
            
        }


    }

}
