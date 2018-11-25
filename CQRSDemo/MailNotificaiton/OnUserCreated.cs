using System;

namespace CQRSDemo.MailNotificaiton
{
    class OnUserCreated : IEventHandler<UserCreated>
    {
        public void Handle(UserCreated @event)
        {
            Console.WriteLine($"wyslalaem email, że się dodał{@event.Name} !");
        }
    }
}
