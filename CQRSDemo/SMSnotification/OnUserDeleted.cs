using CQRSDemo.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.SMSnotification
{
    class OnUserDeleted : IEventHandler<UserDeleted>
    {
        public void Handle(UserDeleted @event)
        {
            Console.WriteLine($"Wysylam SMS że się usunał {@event.Login}");
        }
    }
}
