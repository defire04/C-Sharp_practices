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
            Phone dimasPhone = new MobilePhoneWithColorScreen(380979779777, "600×1200", 4.5, "black", 1200, true, 390989857675);
            Person dima = new Person("Dima", dimasPhone);


            Operator kyivstar = new Operator();

            List<Person> peopleWhomDimaCalled = new List<Person>();
            peopleWhomDimaCalled.Add(new Person("Andy", new RotaryPhone(380981111111111)));
            peopleWhomDimaCalled.Add(new Person("Max", new PushButtonPhone(3809822222222)));
            peopleWhomDimaCalled.Add(new Person("Sasha", new MobilePhoneWithBlackScreen(38098223333333, "480×800", 3.5, "black")));
            peopleWhomDimaCalled.Add(new Person("Mary", new MobilePhoneWithColorScreen(380982244444, "560x1000", 4.6, "orange", 1000, false)));



            Console.WriteLine("Characteristics of Dima's phone");
            dima.Phone.Characteristics();
            Console.WriteLine("---------------------------");

            foreach (Person person in peopleWhomDimaCalled)
            {
                kyivstar.Call(dima, person);
                Console.WriteLine("---------------------------");
            }


            Console.WriteLine("========================Test SMS================================");

            kyivstar.SendMessage(dima, peopleWhomDimaCalled[2]);
            kyivstar.SendMessage(dima, peopleWhomDimaCalled[1]);

            Console.WriteLine("========================Test MMS================================");

            kyivstar.SendMms(dima, peopleWhomDimaCalled[3]);
            kyivstar.SendMms(dima, peopleWhomDimaCalled[2]);
        }
    }
}
