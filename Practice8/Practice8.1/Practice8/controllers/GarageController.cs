using Practice8.models;
using System;
using System.Collections.Generic;


namespace Practice8.controllers
{
    class GarageController
    {
        public static void addCarToGarage(Garage garage, Car newCar)
        {
            garage.getCarList().Add(newCar);
        }

        public static void driveCarsToGarage(Garage garage, List<Car> newCarList)
        {
            foreach (Car car in newCarList)
            {
                garage.getCarList().Add(car);
            }
        }


        public static void deleteCarFromGarage(Garage garage, Car car)
        {
            garage.getCarList().Remove(car);
        }

        public static void removeCarsFromGarage(Garage garage, List<Car> removeCarList)
        {
            foreach (Car car in removeCarList)
            {
                garage.getCarList().Remove(car);
            }
        }

        public static Car takeCarFromGarage(Garage garage, Car takenCar)
        {
            foreach (Car car in garage.getCarList())
            {
                if (car.Equals(takenCar))
                {
                    garage.getCarList().Remove(takenCar);
                    Console.WriteLine("-----------------------\n" + garage.getOwner() + " take " + car + "\n------------------------\n");
                    return car;
                }
            }

            Console.WriteLine("-----------------------\n" + garage.getOwner() + " cant take this car " + takenCar + "\n------------------------\n");
            return new Car("", "", 0, 0);
        }


        public static HashSet<Car> chooseCarAccordingToTheParameters(Garage garage, Car carYouAreLookingFor)
        {
            HashSet<Car> result = new HashSet<Car>();

            Car car1 = takeCarFromGarage(garage, carYouAreLookingFor);

            if (!car1.getBrand().Equals("") && car1.getYearOfIssue() != 0)
            {
                result.Add(car1);
            }
            else
            {
                foreach (Car car in garage.getCarList())
                {

                    if (!carYouAreLookingFor.getBrand().Equals(""))
                    {
                        if (car.getBrand().Equals(carYouAreLookingFor.getBrand()))
                        {
                            result.Add(car);
                        }
                    }

                    if (!carYouAreLookingFor.getColor().Equals(""))
                    {
                        if (car.getColor().Equals(carYouAreLookingFor.getColor()))
                        {
                            result.Add(car);
                        }
                    }


                    if (carYouAreLookingFor.getMaxSpeed() != 0)
                    {
                        if (car.getMaxSpeed() == carYouAreLookingFor.getMaxSpeed())
                        {
                            result.Add(car);
                        }
                    }

                    if (!carYouAreLookingFor.getYearOfIssue().Equals(null))
                    {
                        if (car.getYearOfIssue().Equals(carYouAreLookingFor.getYearOfIssue()))
                        {
                            result.Add(car);
                        }
                    }


                }
            }





            return result;
        }
    }
}