using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class Program {
        static void Main(string[] args) {
            int mostOtenNumber = 0;
            int highestNumberOfRepetitions = 0;
            int numberOfRepetitions = 0;
            Console.Write("Enter the length of the array: ");

            int[] arr = new int[int.Parse(Console.ReadLine())];


            for (int i = 0; i < arr.Length; i++) {
                Console.Write("Enter " + i + " array element = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (int i in arr){
                foreach (int j in arr) {
                    if (i == j) {
                        numberOfRepetitions++;
                    }
                }
                    
                if (highestNumberOfRepetitions < numberOfRepetitions) {
                    highestNumberOfRepetitions = numberOfRepetitions;
                    mostOtenNumber = i;
                }
                numberOfRepetitions = 0;
            }
            Console.WriteLine("The number {0} is repeated most of all, he number of its repetitions is {1}", mostOtenNumber, highestNumberOfRepetitions);
            Console.ReadKey(true);
        }
    }
}
