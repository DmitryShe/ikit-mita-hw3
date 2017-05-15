using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Спорщики\nVer 1.0");
            Console.WriteLine("Джей и Молчаливый Боб решают споры с помощью Числотрона - устройства, которое генерирует целые числа.\n" +
                "Джей получает очки за каждое четное число, выданное Числотроном.\n" +
                "Молчаливый Боб получает очки за нечетные.\n");

            int userKey = -1;
            while (userKey <= 0)
            {
                try
                {
                    Console.WriteLine("Введите количество чисел для того чтобы решить спор: необходимо ввести целое число, больше 0");
                    int.TryParse(Console.ReadLine(), out userKey);
                }

                catch(Exception e)
                {
                    Console.WriteLine("вот так, то так..." + e);
                }
            }

            var Jay = new Jay("Jay");
            var Bob = new SilentBob("SilentBob");          
            
            var numbertron = new Numbertron();

            numbertron.NewNumber += Jay.FetchNewNumber;
            numbertron.NewNumber += Bob.FetchNewNumber;

            for (int i = 0; i < userKey; i++)
            {
                numbertron.Generate();
                
            }

            //Console.WriteLine("Очки {0}: " + Jay.Score + "\n" + "Очки {1}: " + Bob.Score, Jay.Name, Bob.Name);

            if (Jay.Score > Bob.Score)
                Console.WriteLine("Победитель : " + Jay.Name + "!");
            else if (Jay.Score < Bob.Score)
                Console.WriteLine("Победитель : " + Bob.Name + "!");
            else
                Console.WriteLine("DRAW");

            Console.ReadKey();

        }
    }
}
