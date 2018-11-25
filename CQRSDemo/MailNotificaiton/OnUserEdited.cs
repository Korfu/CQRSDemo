using CQRSDemo.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.MailNotificaiton
{
    class OnUserEdited : IEventHandler<UserEdited>
    {
        public void Handle(UserEdited @event)
        {
            Console.WriteLine($"Wysylam email, że się edytował {@event.Login}");
        }
    }
}
