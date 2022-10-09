using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn;
            int nk;


            double sum = 0;

            do
	        {
                Console.WriteLine("NN");
                nn = int.Parse(Console.ReadLine());
	        } while (nn <= 0);
           

            do
	        {
                Console.WriteLine("NK");
                 nk = int.Parse(Console.ReadLine());
	        } while (nn >= nk);

           

            for (int k = nn; k < nk; k++)
            {
                sum += (Math.Pow(k, 2) + Math.Pow(-1, (k - 1)) * 2 * k - 1) / (Math.Pow(k, 2) + 8);
            }

            Console.WriteLine(sum);


            Console.ReadKey();


        }

        

}
 

