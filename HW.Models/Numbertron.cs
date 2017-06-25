using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            /*
            Random rand = new Random();
            int n = rand.Next(0, 101);                 
            NewNumber(n);
            */




            bool moreThanAHundred = true;

            while (moreThanAHundred)
            {
                RNGCryptoServiceProvider Rand = new RNGCryptoServiceProvider();
                byte[] randomNumber = new byte[1];
                Rand.GetNonZeroBytes(randomNumber);
                if (randomNumber[0] < 101)
                {
                    NewNumber(randomNumber[0]);
                    break;
                }

            }
            

            



        }
    }
}
