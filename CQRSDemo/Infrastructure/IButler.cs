using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo
{
    public interface IButler
    {
        void Do<TCommand>(TCommand command);
        void Tell<TEvent>(TEvent @event);
    }
}
