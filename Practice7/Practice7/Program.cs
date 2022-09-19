using System;
using System.Collections.Generic;


namespace Practice7
{
    class Program {
        static void Main(string[] args) {

            //Створити ліст стрінгових значень, дозволити можливість заповнення з клавіатури. Вивести кількість елементів рівної двожини.

            List<string> strList = new List<string>();
            string newElement;

            Dictionary<int, int> result = new Dictionary<int, int>();
            while (true) {

                Console.Write("Enter new list element(if you want to finish write 'END'): ");
                newElement = Console.ReadLine();

                if (newElement.Equals("END")) {
                    break;
                }

                strList.Add(newElement);
            }

            int count = 0;
            foreach(string i in strList) {
                foreach(string j in strList) {
                        if(i.Length == j.Length) {
                            count++;
                        }
                }

                if (count > 1) {
                    if (!result.ContainsKey(i.Length)) {
                        result.Add(i.Length, count);
                    }
                }
                count = 0;
            }


            foreach (var i in result) {
                Console.WriteLine($"elements with length {i.Key} equals {i.Value}");
            }

           
            Console.ReadKey();
        }
    }
}
