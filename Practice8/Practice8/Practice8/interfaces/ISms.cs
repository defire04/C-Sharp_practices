using Practice8.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice8.interfaces
{
    interface ISms
    {

        string SendMessage();
        void AcceptMessage(string message, Person sender);
    }
}
