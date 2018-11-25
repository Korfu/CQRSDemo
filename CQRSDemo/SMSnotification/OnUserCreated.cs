using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.SMSnotification
{
    public class OnUserCreated : IEventHandler<UserCreated>
    {
        public void Handle(UserCreated @event)
        {
            Console.WriteLine("Wysylam SMS");
        }
    }

}
