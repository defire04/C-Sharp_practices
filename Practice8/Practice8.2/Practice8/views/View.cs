using System;
using System.Collections.Generic;
using System.Text;

namespace Practice8.views
{
    class View
    {

        public static void PrintListInARow<T>(List<T> list)
        {
            foreach (T element in list)
            {
                Console.Write(element);
            }
            Console.WriteLine();
        }

        public static void PrintListInAСolumn<T>(List<T> list)
        {
            foreach (T element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
        }
    }
}
