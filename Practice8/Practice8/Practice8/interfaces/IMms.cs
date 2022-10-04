using Practice8.models;

namespace Practice8.interfaces
{
    interface IMms
    {
        string SendMms();
        void AcceptMms(string mms, Person sender);
    }
}
