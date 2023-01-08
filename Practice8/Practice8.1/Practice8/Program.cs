using Practice8.controllers;
using Practice8.models;
using System;
using System.Collections.Generic;


namespace Practice8
{
    class Program
    {
        static void Main(string[] args)
        {

            Garage sheikhGarage = new Garage("Sheikh");

            List<Car> carList = new List<Car>();

            carList.Add(new Car("Audi", "Black", 220, 2008));
            carList.Add(new Car("Audi", "White", 220, 2010));
            carList.Add(new Car("Bmw", "Blue", 200, 2000));
            carList.Add(new Car("Chevrolet", "Yellow", 300, 2016));
            carList.Add(new Car("Chevrolet", "Black", 300, 2022));
            carList.Add(new Car("Ferrari", "Red", 400, 2022));
            carList.Add(new Car("Ferrari", "Red", 380, 2021));

            GarageController.driveCarsToGarage(sheikhGarage, carList);

            printList(sheikhGarage.getCarList());

            GarageController.takeCarFromGarage(sheikhGarage, new Car("Ferrari", "Red", 400, 2022));

            printList(sheikhGarage.getCarList());



            printList(GarageController.chooseCarAccordingToTheParameters(sheikhGarage, new Car("", "Red", 0, 2022)));






            Console.ReadKey();
        }

        public static void printList<T>(List<T> list)
        {
            foreach (T el in list)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("-----------------------");
        }

        public static void printList<T>(HashSet<T> list)
        {
            foreach (T el in list)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("-----------------------");
        }

    }

}
