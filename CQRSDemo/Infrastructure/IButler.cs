using CQRSDemo.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo
{
    public interface IButler
    {
        void Do<TCommand>(TCommand command);
        void Tell<TEvent>(TEvent @event);
        TQuery Give<TQuery>(TQuery  query);
    }
}
