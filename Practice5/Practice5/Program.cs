using System;
using System.Collections;

namespace Practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дана матриця розміру m *n.Вивести кількість
            //1) рядків; 2) стовпчиків,
            //елементи яких монотонно зростають(спадають). 

            //Console.Write("Enter the length of the array: ");

            //int[,] arr = new int [int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];

            int[,] arr = { {1,2,2,4 },
                           {5,2,6,2 },
                           {3,5,7,1 }};

            int rows = arr.GetUpperBound(0) + 1;    // количество строк
            int columns = arr.Length / rows;        // количество столбцов

           
            ArrayList ressultListForRows = new ArrayList();
            ArrayList ressultListForColumns = new ArrayList();

            int[] forRows = new int[columns];
            int[] forColumns = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(arr[i, j] + " ");
                    forRows[j] = arr[i, j];

                }
                if (checkIfNumbersIncreaseMonotonically(forRows) || checkIfNumbersDecreaseMonotonically(forRows)){
                    ressultListForRows.Add(i);
                }
                Console.WriteLine();
            }

            Console.Write("Numbers increase or decrease monotonously in rows: ");

            foreach (int i in ressultListForRows)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {

                    //  Console.WriteLine(arr[i, j] + " ");
                    forColumns[i] = arr[i, j];
                }

                //foreach (int b in forColumns)
                //{
                //    Console.Write(b);
                //}
                //Console.WriteLine(checkWhetherNumbersIncreaseMonotonicallyInRows(forColumns));
                //Console.WriteLine();


                if (checkIfNumbersIncreaseMonotonically(forColumns) || checkIfNumbersDecreaseMonotonically(forColumns))
                {
                    ressultListForColumns.Add(j);
                }

            }

            Console.Write("Numbers increase or decrease monotonously in colums: ");

            foreach (int i in ressultListForColumns)
            {
                Console.Write(i + " ");
            }


            //int[] arr = { 5, 4, 3, 2, 1 };
            //Console.WriteLine(checkIfNumbersIncreaseMonotonically(arr));

            //Console.WriteLine(checkIfNumbersDecreaseMonotonically(arr));

            Console.ReadKey(true);
        }


        static bool checkIfNumbersIncreaseMonotonically(int[] arr)
        {
            bool flag = true;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    flag = false;
                }
            }
            return flag;
        }

        static bool checkIfNumbersDecreaseMonotonically(int[] arr)
        {
            bool flag = true;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    flag = false;
                }
            }
            return flag;
        }
    }
}
