using System;

namespace CQRSDemo.SMSnotification
{
    public class OnUserCreated : IEventHandler<UserCreated>
    {
        public void Handle(UserCreated @event)
        {
            Console.WriteLine($"Wysylam SMS, że się dodał {@event.Name}");
        }
    }

}
