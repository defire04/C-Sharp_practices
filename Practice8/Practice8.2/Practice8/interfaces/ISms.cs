using Practice8.models;

namespace Practice8.interfaces
{
    interface ISms
    {
        string SendMessage();
        void AcceptMessage(string message, Person sender);
    }
}
