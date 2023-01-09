using Practice10.controllers;
using System;
using System.Linq;

namespace Practice10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(
                       1234.Flip() + "\n" +
                       12.34.Flip() + "\n" +
                       "АБВ".Flip() + "\n" +
                       "АБВ,ГДЕ".Flip(',')

            );
            new int[] { 1, 2, 3, 4 }.Flip().PrintArr();
            new int[] { 1, 2, 3, 4 }.MakePairedElementsFirst().PrintArr();

            Console.ReadKey();
        }
    }
    // 7. Створити розширяючий метод для масиву цілих чисел, який спочатку виводить парні елементи, а потім непарні. 
    public static class Extension
    {
        public static int[] MakePairedElementsFirst(this int[] arr)
        {
            return Array.FindAll(arr, x => x % 2 == 0).Concat(Array.FindAll(arr, x => x % 2 != 0)).ToArray();
        }
    }
}
