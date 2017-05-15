using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{    
    public class SilentBob : Gambler
    {
        string Name;

        public SilentBob(string name) : base(name)
        {
            this.Name = name;
        }

        public override void FetchNewNumber(int number)
        {
            if (!number.IsEven()) Score++;
        }


    }

}
