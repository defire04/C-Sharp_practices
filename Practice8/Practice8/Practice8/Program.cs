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
            Smartphone dimasPhone = new Smartphone(380979779777, "1080x1920", 4.5, "black", 1200, true, 390989857675, true, 10, new List<Camera>() { new Camera(20), new Camera(12)});
            Person dima = new Person("Dima", dimasPhone);

            Operator kyivstar = new Operator();

            List<Person> peopleWhomDimaCalled = new List<Person>();
            peopleWhomDimaCalled.Add(new Person("Andy", new RotaryPhone(380981111111111)));
            peopleWhomDimaCalled.Add(new Person("Max", new PushButtonPhone(3809822222222)));
            peopleWhomDimaCalled.Add(new Person("Sasha", new MobilePhoneWithBlackScreen(38098223333333, "480×800", 3.5, "black")));
            peopleWhomDimaCalled.Add(new Person("Mary", new MobilePhoneWithColorScreen(380982244444, "560x1000", 4.6, "orange", 1000, false)));
            peopleWhomDimaCalled.Add(new Person("Mary", new Smartphone(380982244544, "560x1000", 4.6, "orange", 1000, false, true, 8, new List<Camera>() { new Camera(20) })));


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

            Console.WriteLine("========================Test Photo and Video================================");
            dimasPhone.MakePhoto();
            dimasPhone.RecordVideo();

        }
    }
}
