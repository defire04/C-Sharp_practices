using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Practice10.controllers
{
    public static class Flipper
    {
        public static string Flip(this int integer)
        {
            string result = "";
            while (integer != 0)
            {
                result += integer % 10;
                integer /= 10;
            }

            return result;
        }

        public static string Flip(this string str)
        {
            string result = "";
            for (int i = str.Length - 1; i > -1; i--)
            {
                result += str[i];
            }

            return result;
        }


        public static string Flip(this double doubl)
        {
            string[] strArr = doubl.ToString().Split(new char[] { ',', '.' });
            return Flip(strArr[0]) + "." + Flip(strArr[1]);

        }

        public static string Flip(this string str, char magicSymbol)
        {
            string[] strArr = str.Split(magicSymbol);
            string result = "";
            foreach (string i in strArr)
            {
                result += Flip(i) + magicSymbol;
            }

            return result[0..^1];
        }

        public static T[] Flip<T>(this T[] arr)
        {
            T[] reverseArr = new T[arr.Length];
            for (int j = 0, i = arr.Length - 1; i > -1; i--, j++)
            {
                reverseArr[j] = arr[i];
            }


            return reverseArr;
        }
    }
}
