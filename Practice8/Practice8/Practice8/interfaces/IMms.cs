using Practice8.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice8.interfaces
{
    interface IMms
    {
        string SendMms();
        void AcceptMms(string mms, Person sender);
    }
}
