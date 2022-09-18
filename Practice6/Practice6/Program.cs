using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написати програму, що виконує наступні функції (ВИКОНАТИ ВСІ 8 (ВІСІМ) ПУНКТІВ):

            //Виводить на екран введене число з клавіатури в зворотному порядку (1234->4321)
            //Виводить будь-яку строку в зворотному порядку (АБВ->ВБА)
            //Дробові числа виводяться в зворотному порядку і ціла частина і дробова (123.456->321.654)
            //Виводити будь-яку строку в зворотному порядку і всі елементи після “магічного знаку” теж в зворотному (АБВ,ГДЕ->ВБА,ЕДГ)
            //Реалізувати пункти 1-4 за допомогою методів, перевантаживши методи для різних типів
            //Реалізувати пункти 1-4 за допомогою рекурсії, методи для різних типів перевантажити
            //Реалізувати метод, що буде масив повертати задом навпаки (Використання Array.Reverse() заборонено!)
            //Виконати пункт 7 з використанням ключових слів ref i out

            string[] strArr = new string[] { "abs", "ds", "dd" };

            Console.WriteLine(flip(1234) + "\n" +
                              flip("Adg") + "\n" +
                              flip(12.36) + "\n" +
                              flip("АБВ,ГДЕ", ',') + "\n" 
                              );

            printArr(strArr);
            flipArrWithRef(ref strArr);
            printArr(strArr);



            Console.ReadKey();
        }

        static string flip(int integer)
        {
            string result = "";
            while (integer != 0)
            {
                result += integer % 10;
                integer /= 10;
            }

            return result;
        }

        static string flip(string str)
        {
            string result = "";
            for (int i = str.Length - 1; i > -1; i--)
            {
               result += str[i];
            }

            return result;
        }


        static string flip(double doubl)
        {

            string [] strArr = doubl.ToString().Split(',');
            string result = "";

            int temp;
            foreach(string i in strArr) {
                temp = int.Parse(i);
                while (temp != 0)
                {
                    result += temp % 10;
                    temp /= 10;
                }

                result += ".";
            }


            return result.Substring(0, result.Length - 1);
        }

        static string flip(string str, char magicSymbol)
        {
            string[] strArr = str.Split(magicSymbol);
            string result = "";
            foreach (string i in strArr)
            {
                result += flip(i) + magicSymbol;
            }

            return result.Substring(0, result.Length - 1);
        }

        static void flipArrWithRef<T>(ref T [] arr ) {
            T[] reverseArr = new T [arr.Length];
            for (int j = 0, i = arr.Length -1 ; i > -1 ; i--, j++) {
                reverseArr[j] = arr[i];
            }
            arr = reverseArr;
        }


            static void printArr<T>(T[] arr)
        {
            foreach(T element in  arr)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }
    }
}
