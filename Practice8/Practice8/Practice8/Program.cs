using Practice8.controllers;
using Practice8.models;
using Practice8.views;
using System;
using System.Collections.Generic;

namespace Practice8
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone dimasPhone = new PushButtonTelephone(380979779777);
            Person dima = new Person("Dima", dimasPhone);

            Operator kyivstar = new Operator();

            List<Person> peopleWhomDimaCalled = new List<Person>();
            peopleWhomDimaCalled.Add(new Person("Andy", new RotaryPhone(380981111111111)));
            peopleWhomDimaCalled.Add(new Person("Max", new PushButtonTelephone(3809822222222)));
            peopleWhomDimaCalled.Add(new Person("Sasha", new MobilePhoneWithBlackScreen(3809822222222, "480×800", 3.5, "black")));



            Console.WriteLine("Characteristics of Dima's phone" );
            dima.Phone.Characteristics();
            Console.WriteLine("---------------------------");

            foreach (Person person in peopleWhomDimaCalled)
            {
                kyivstar.Call(dima, person);
                Console.WriteLine("---------------------------");
            }

            

        }


    }
}
