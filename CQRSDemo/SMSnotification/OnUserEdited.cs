using CQRSDemo.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.SMSnotification
{
    class OnUserEdited : IEventHandler<UserEdited>
    {
        public void Handle(UserEdited @event)
        {
            Console.WriteLine($"Wysylam SMS że się edytował {@event.Login}");
        }
    }
}
