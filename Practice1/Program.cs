using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            
          
            double I;
            double U;
            double R;

            string strU;
            string strR;

            bool isUEnteredCorrectly;
            bool isREnteredCorrectly;

            Console.WriteLine("I = U / R\n" +
                " R- оми\n U - вольти\n I - ампери");
            do
            {
                Console.Write("Введiть напругу (U): ");
                strU = Console.ReadLine();
                isUEnteredCorrectly = double.TryParse(strU, out U);
                if (!isUEnteredCorrectly)
                {
                    Console.WriteLine("Напруга введена некорректно!");
                }
            }
            while (!isUEnteredCorrectly);

            do
            {
                Console.Write("Введiть опiр (R):");
                strR = Console.ReadLine();
                isREnteredCorrectly = double.TryParse(strR, out R);
                if (!isREnteredCorrectly)
                {
                    Console.WriteLine("Опiр введен некорректно!");
                }
            }
            while (!isREnteredCorrectly);


            if (R <= 0)
            {
                Console.WriteLine("Погана людина!");
                Console.ReadLine();
                return;
            }
            I = U / R;
            Console.WriteLine("I = {0} / {1}\nI = {2}", U, R, I);
            Console.ReadKey();
        }
    }
}
