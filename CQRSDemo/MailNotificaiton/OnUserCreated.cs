using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.MailNotificaiton
{
    class OnUserCreated : IEventHandler<UserCreated>
    {
        public void Handle(UserCreated @event)
        {
            Console.WriteLine("wyslalaem email!");
        }
    }
}
