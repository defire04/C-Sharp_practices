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

            Phone maxPhone = new PushButtonTelephone(3809822222222);
            Person max = new Person("Max", maxPhone);


            Operator kyivstar = new Operator();

            kyivstar.Call(dima, max);

        }


    }
}
