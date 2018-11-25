using CQRSDemo.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.MailNotificaiton
{
    class OnUserDeleted : IEventHandler<UserDeleted>
    {
        public void Handle(UserDeleted @event)
        {
            Console.WriteLine($"Wysylam email, że się usunał {@event.Login}");
        }
    }
}
