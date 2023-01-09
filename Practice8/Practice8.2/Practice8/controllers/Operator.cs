using Practice8.models;
using System;
using System.Collections.Generic;

namespace Practice8.controllers
{
    class Operator
    {
        public void Call(Person caller, Person callRecipient)
        {
            Phone phone = caller.Phone;
            phone.Call();
            //phone.Characteristics();

            //Console.WriteLine(personReceivingACall.Name + ", would you like to receive a call?\n(yes/no)");
            //if (Console.ReadLine().ToLower().Equals("yes"))
            //{
            //    AcceptCall(caller, personReceivingACall);
            //}
            AcceptCall(caller, callRecipient);
        }

        private void AcceptCall(Person caller, Person callRecipient)
        {
            Phone phone = callRecipient.Phone;
            phone.AcceptCall();
            phone.Characteristics();

           if(!(phone.GetType() == typeof(RotaryPhone)))
           {
                GetPhoneThatCanShowIncomingNumber(((PushButtonPhone)phone)).ShowWhoCall(caller);    
           }
        }

        public void SendMessage(Person sender, Person messageRecipient)
        {
            if (sender.Phone is MobilePhoneWithBlackScreen)
            {
                string message = GetPhoneThatCanSendMessages((MobilePhoneWithBlackScreen)sender.Phone).SendMessage();
                AcceptMessage(sender, messageRecipient, message);
            }
            else
            {
                Console.WriteLine("{0}, your phone does not support sending messages. Buy a new phone!", sender.Name);
            }
        }

        private void AcceptMessage(Person sender, Person messageRecipient, String message)
        {
            if (messageRecipient.Phone is MobilePhoneWithBlackScreen)
            {
                GetPhoneThatCanSendMessages((MobilePhoneWithBlackScreen)messageRecipient.Phone).AcceptMessage(message, sender);
            }
            else
            {
                Console.WriteLine("{0}, your phone does not support receiving messages. Buy a new phone!", messageRecipient.Name);
            }
        }

        public void SendMms(Person sender, Person messageRecipient)
        {
            //Phone a = new Smartphone();
            if (sender.Phone is MobilePhoneWithColorScreen)
            {
                string message = GetPhoneThatCanSendMms((MobilePhoneWithColorScreen)sender.Phone).SendMms();
                AcceptMms(sender, messageRecipient, message);
            }
            else
            {
                Console.WriteLine("{0}, your phone does not support sending MMS. Buy a new phone!", sender.Name);
            }
        }

        private void AcceptMms(Person sender, Person messageRecipient, String message)
        {
            if (messageRecipient.Phone is MobilePhoneWithColorScreen)
            {
                GetPhoneThatCanSendMms((MobilePhoneWithColorScreen)messageRecipient.Phone).AcceptMms(message, sender);
            }
            else
            {
                Console.WriteLine("{0}, your phone does not support receiving MMS. Buy a new phone!", messageRecipient.Name);
            }
        }

        private T GetPhoneThatCanSendMessages<T>(T phone) where T : MobilePhoneWithBlackScreen
        {
            return ((T)phone);
        }

        private T GetPhoneThatCanShowIncomingNumber<T>(T phone) where T : PushButtonPhone
        {
            return ((T)phone);
        }

        private T GetPhoneThatCanSendMms<T>(T phone) where T : MobilePhoneWithColorScreen
        {
            return ((T)phone);
        }
    }
}
