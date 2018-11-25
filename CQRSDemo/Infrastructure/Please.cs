using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo
{
    public class Please : IButler
    {
        private readonly IKernel _container;

        public Please(IKernel container)
        {
            _container = container;
        }

        public void Do<TCommand>(TCommand command)
        {
            var handler = _container.Get<ICommandHandler<TCommand>>();
            handler.Handle(command);
        }

        public void Tell<TEvent>(TEvent @event)
        {
            var handlers = _container.GetAll<IEventHandler<TEvent>>();

            foreach (var handler in handlers)
            {
                handler.Handle(@event);
            }
        }
    }
}
