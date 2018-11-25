using CQRSDemo;
using System;

namespace SMSNotification
{
    class OnUserCreated : IEventHandler<UserCreated>
    {
        public void Handle(UserCreated @event)
        {
            Console.WriteLine("send SMS");
        }
    }
}
