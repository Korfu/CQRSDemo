using CQRSDemo.Commands;
using CQRSDemo.Events;
using CQRSDemo.SMSnotification;
using Ninject;
using System;

namespace CQRSDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel container = new StandardKernel();
            container.Bind<IButler>().To<Please>();

            container.Bind<ICommandHandler<AddUser>>().To<AddUSerHandler>();
            container.Bind<IEventHandler<UserCreated>>().To<OnUserCreated>();
            container.Bind<IEventHandler<UserCreated>>().To<MailNotificaiton.OnUserCreated>();

            container.Bind<ICommandHandler<DeleteUser>>().To<DeleteUserHandler>();
            container.Bind<IEventHandler<UserDeleted>>().To<OnUserDeleted>();
            container.Bind<IEventHandler<UserDeleted>>().To<MailNotificaiton.OnUserDeleted>();

            container.Bind<ICommandHandler<EditUser>>().To<EditUserHandler>();
            container.Bind<IEventHandler<UserEdited>>().To<OnUserEdited>();
            container.Bind<IEventHandler<UserEdited>>().To<MailNotificaiton.OnUserEdited>();

            var please = container.Get<IButler>();

            please.Do(new AddUser("Mic", "Michal Matuszek"));
            please.Do(new DeleteUser("Korfu"));
            please.Do(new EditUser("Pinky"));

            Console.ReadKey();
        }
    }
}
