using System;
using System.Collections.Generic;
using System.Text;

namespace Practice10.controllers
{
    public static class Printer
    {
        public static void PrintArr<T>(this T[] arr)
        {
            foreach (T element in arr)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }
    }
}
