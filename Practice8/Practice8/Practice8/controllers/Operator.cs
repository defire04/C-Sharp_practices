using Practice8.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice8.controllers
{
    class Operator
    {
        public void Call(Person caller, Person personReceivingACall)
        {
        
            Phone phone = caller.Phone;
            phone.Call();
            phone.Characteristics();


            Console.WriteLine(personReceivingACall.Name + ", would you like to receive a call?");
            if (Console.ReadLine().ToLower().Equals("yes"))
            {
                AcceptCall(caller, personReceivingACall);
            }

        }

        public void AcceptCall(Person caller, Person personReceivingACall)
        {
            Phone phone = personReceivingACall.Phone;
            phone.AcceptCall();
            phone.Characteristics();

          if (phone.GetType() == typeof(PushButtonTelephone))
            {
                ((PushButtonTelephone)phone).ShowWhoCall(caller);
            }


        }
    }
}
